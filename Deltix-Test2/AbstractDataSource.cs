using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DeltixTest2
{
    abstract class AbstractDataSource
    {
        // public
        public AbstractDataSource()
        {
            mReceiversLock = new ReaderWriterLock();
            mReceivers = new List<IDataReceiver>();
        }

        public abstract int channelsCount { get; }

        public abstract void start();
        public abstract void stop();
        public abstract bool isRunning();
        public event Action stopped;

        public void addDataReceiver(IDataReceiver receiver)
        {
            using (WriteLocker wl = new WriteLocker(ref mReceiversLock))
            {
                mReceivers.Add(receiver);
            }
        }
        public void removeDataReceiver(IDataReceiver receiver)
        {
            using (WriteLocker wl = new WriteLocker(ref mReceiversLock))
            {
                mReceivers.Remove(receiver);
            }
        }

        public void onDataCame(int channelNumber, byte[] data)
        {
            List<IDataReceiver> receivers;
            using (ReadLocker wl = new ReadLocker(ref mReceiversLock))
            {
                receivers = mReceivers.ConvertAll<IDataReceiver>(p => p);
            }
            foreach (IDataReceiver receiver in receivers)
            {
                receiver.onDataCame(channelNumber, data);
            }
        }

        // protected
        protected void onStopped()
        {
            if (stopped != null)
                stopped();
        }

        // private
        private ReaderWriterLock mReceiversLock;
        private List<IDataReceiver> mReceivers;
    }
}
