using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace DeltixTest2
{
    public partial class MainWindow : Form, IDataReceiver
    {
        // public
        public MainWindow()
        {
            InitializeComponent();

            Debug.init();
            LatencyCounter.init();

            Load += onLoad;
            FormClosing += onFormClosing;
            channelsList.SelectedIndexChanged += onSelectedChannelChanged;
            intervalEdit.ValueChanged += onIntervalValueChanged;
            clientsList.SelectedIndexChanged += onSelectedClientChanged;
            addClientButton.Click += onAddClient;
            removeClientButton.Click += onRemoveClient;
            subscribeButton.Click += onSubscribeChannel;
            unsubscribeButton.Click += onUnsubscribeAllChannels;

            mDataSource = new TestDataSource(Constants.kChannelsCount);
            mDataSource.addDataReceiver(this);

            for (int i = 0; i < Constants.kChannelsCount; ++i)
            {
                channelsList.Items.Add((i + 1).ToString());
            }

            mDataReceiver = new DataReceiver(mDataSource);
            mSubscribers = new Dictionary<string, Subscriber>();
            mRandom = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < Constants.kInitialSubscribersCount; ++i)
            {
                addClient();
            }

            channelsCountLabel.Text = String.Concat("Channels (", channelsList.Items.Count.ToString(), "):");

            mLatencyTimer = new System.Timers.Timer(1000);
            mLatencyTimer.AutoReset = true;
            mLatencyTimer.Elapsed += onLatencyTimer;
        }

        public void onDataCame(int channelNumber, byte[] data)
        {
            DataCame d = new DataCame(onSenderDataCame);
            Invoke(d, new object[] { channelNumber, data });
        }

        // private
        private void onSenderDataCame(int channelNumber, byte[] data)
        {
            if (channelsList.SelectedIndex == -1)
                return;
            if (selectedChannel() != channelNumber)
                return;
            senderDataLabel.Text = System.Text.Encoding.ASCII.GetString(data);
        }

        delegate void ClientDataCame(string clientId, ByteArrayDataPackage package);
        private void onClientDataCame(string clientId, ByteArrayDataPackage package)
        {
            ClientDataCame d = new ClientDataCame(onReceiverDataCame);
            Invoke(d, new object[] { clientId, package });
        }
        private void onReceiverDataCame(string clientId, ByteArrayDataPackage package)
        {
            if (selectedClient() != clientId)
                return;
            if (clientsChannelsList.SelectedIndex == -1)
                return;
            if (selectedClientsChannel() != package.channelNumber)
                return;
            receiverDataLabel.Text = System.Text.Encoding.ASCII.GetString(package.data);
        }

        private void onLoad(object sender, EventArgs e)
        {
            mLatencyTimer.Start();
            mDataSource.start();
        }
        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            mLatencyTimer.Stop();
            if (mDataSource.isRunning())
            {
                mDataSource.stopped += onDataSourceStopped;
                mDataSource.removeDataReceiver(this);
                mDataSource.stop();
                e.Cancel = true;
            }
        }
        private void onDataSourceStopped()
        {
            if (InvokeRequired)
            {
                Action d = new Action(onDataSourceStopped);
                Invoke(d);
            }
            else
            {
                Close();
            }
        }

        private void onSelectedChannelChanged(object sender, EventArgs e)
        {
            if (channelsList.SelectedIndex == -1)
            {
                intervalEdit.Enabled = false;
                return;
            }
            intervalEdit.Enabled = true;
            intervalEdit.Value = mDataSource.interval(selectedChannel());
        }
        private void onIntervalValueChanged(object sender, EventArgs e)
        {
            if (channelsList.SelectedIndex == -1)
            {
                intervalEdit.Enabled = false;
                return;
            }
            mDataSource.setInterval(selectedChannel(), (int)intervalEdit.Value);
        }

        private int selectedChannel()
        {
            return int.Parse(channelsList.Text);
        }

        private void onSelectedClientChanged(object sender, EventArgs e)
        {
            receiverDataLabel.Text = "";
            updateClientsChannels(selectedClient());
            updateClientsChannelsCount();
        }

        private void updateClientsChannels(string clientId)
        {
            clientsChannelsList.Items.Clear();
            if (String.IsNullOrEmpty(clientId))
                return;
            List<int> channels = mSubscribers[clientId].channels();
            foreach (int channel in channels)
            {
                clientsChannelsList.Items.Add(channel.ToString());
            }
        }

        private void onAddClient(object sender, EventArgs e)
        {
            string clientId = addClient();
            clientsList.SetSelected(clientsList.FindString(clientId), true);
        }
        private void onRemoveClient(object sender, EventArgs e)
        {
            string clientId = selectedClient();
            if (String.IsNullOrEmpty(clientId))
                return;
            removeClient(clientId);
        }
        private void onSubscribeChannel(object sender, EventArgs e)
        {
            string clientId = selectedClient();
            if (String.IsNullOrEmpty(clientId))
                return;
            addChannel(clientId);
        }
        private void onUnsubscribeAllChannels(object sender, EventArgs e)
        {
            string clientId = selectedClient();
            if (String.IsNullOrEmpty(clientId))
                return;
            removeAllChannels(clientId);
        }

        private string selectedClient()
        {
            return clientsList.Text;
        }
        private int selectedClientsChannel()
        {
            return int.Parse(clientsChannelsList.Text);
        }
        private string addClient()
        {
            Subscriber s = mDataReceiver.addSubscriber();
            s.dataCame += (package) => onClientDataCame(s.id, package);
            mSubscribers.Add(s.id, s);
            for (int i = 0; i < Constants.kDefaultSubscribersChannelsCount; ++i)
            {
                addChannel(s.id);
            }
            clientsList.Items.Add(s.id);
            updateClientsCount();
            return s.id;
        }
        private void removeClient(string clientId)
        {
            if (!mSubscribers.ContainsKey(clientId))
                return;
            removeAllChannels(clientId);
            mSubscribers.Remove(clientId);
            clientsList.Items.Remove(clientId);
            updateClientsCount();
        }
        private void addChannel(string clientId)
        {
            int channel = 0;
            do
            {
                channel = mRandom.Next(1, Constants.kChannelsCount);
            }
            while (mSubscribers[clientId].isSubscribed(channel));
            mSubscribers[clientId].subscribe(channel);
            if (selectedClient() == clientId)
            {
                updateClientsChannels(clientId);
                clientsChannelsList.SetSelected(clientsChannelsList.FindString((channel).ToString()), true);
            }
            updateClientsChannelsCount();
        }
        private void removeAllChannels(string clientId)
        {
            mSubscribers[clientId].unsubscribeAll();
            if (selectedClient() == clientId)
            {
                updateClientsChannels(clientId);
            }
            updateClientsChannelsCount();
        }

        private void updateClientsCount()
        {
            clientsCountLabel.Text = String.Concat("Clients (", clientsList.Items.Count.ToString(), "):");
        }
        private void updateClientsChannelsCount()
        {
            clientsChannelsCountLabel.Text = String.Concat("Channels (", clientsChannelsList.Items.Count.ToString(), "):");
        }

        private void onLatencyTimer(object sender, ElapsedEventArgs e)
        {
            if (!mLatencyTimer.Enabled)
                return;
            Action d = new Action(updateLatency);
            Invoke(d);
        }
        private void updateLatency()
        {
            latencyLabel.Text = String.Concat("Avarage latency = " + LatencyCounter.avarageLatency().ToString() + "ms");
        }

        private TestDataSource mDataSource;
        private DataReceiver mDataReceiver;
        private Dictionary<string, Subscriber> mSubscribers;
        private Random mRandom;
        private System.Timers.Timer mLatencyTimer;
    }
}
