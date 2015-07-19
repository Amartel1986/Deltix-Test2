using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace DeltixTest2
{
    class TestDataSource : AbstractDataSource
    {
        // public
        public TestDataSource(int channelsCount) :
            base()
        {
            mChannelsCount = channelsCount;
            mGenerator = new ByteArrayGenerator();
            mTimers = new List<System.Timers.Timer>();
        }

        public override int channelsCount
        {
            get
            {
                return mChannelsCount;
            }
        }

        public override void start()
        {
            stop();
            for (int i = 0; i < channelsCount; ++i)
            {
                createChannel(i + 1);
            }
        }
        public override void stop()
        {
            double lastTimerInterval = 0;
            foreach (System.Timers.Timer t in mTimers)
            {
                t.Stop();
                if (t.Interval > lastTimerInterval)
                    lastTimerInterval = t.Interval;
            }
            mTimers.Clear();
            System.Timers.Timer lastTimer = new System.Timers.Timer(lastTimerInterval + 1);
            lastTimer.AutoReset = false;
            lastTimer.Elapsed += onLastTimer;
            lastTimer.Start();
        }
        public override bool isRunning()
        {
            return mTimers.Count > 0;
        }

        public int interval(int channelNumber)
        {
            return (int)mTimers[channelNumber - 1].Interval;
        }
        public void setInterval(int channelNumber, int intervalMs)
        {
            mTimers[channelNumber - 1].Interval = intervalMs;
        }

        // private
        private void createChannel(int channelNumber)
        {
            System.Timers.Timer timer = new System.Timers.Timer(Constants.kDefaultIntervalMs);
            timer.AutoReset = true;
            timer.Elapsed += (timerSender, timerEvent) => onTimer(timerSender, timerEvent, channelNumber);
            mTimers.Add(timer);
            timer.Start();
        }

        private void onTimer(object sender, ElapsedEventArgs e, int channelNumber)
        {
            if (mTimers.Count >= channelNumber)
            {
                onDataCame(channelNumber, mGenerator.generate());
            }
        }

        private void onLastTimer(object sender, ElapsedEventArgs e)
        {
            onStopped();
        }

        private int mChannelsCount;
        private ByteArrayGenerator mGenerator;
        private List<System.Timers.Timer> mTimers;
    }
}
