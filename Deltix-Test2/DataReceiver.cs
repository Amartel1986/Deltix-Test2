using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DeltixTest2
{
    class DataReceiver : IDataReceiver
    {
        // public
        public DataReceiver(AbstractDataSource dataSource)
        {
            mDataSource = dataSource;
            mDataSource.addDataReceiver(this);
            mSubscribersLock = new ReaderWriterLock();
            mSubscribers = new List<HashSet<Subscriber>>(dataSource.channelsCount);
            for (int i = 0; i < dataSource.channelsCount; ++i)
            {
                mSubscribers.Add(new HashSet<Subscriber>());
            }
        }

        public Subscriber addSubscriber()
        {
            return new Subscriber(this);
        }

        public void subscribe(Subscriber s, int channelNumber)
        {
            using (WriteLocker wl = new WriteLocker(ref mSubscribersLock))
            {
                if (channelNumber > mSubscribers.Count)
                    return;
                mSubscribers[channelNumber - 1].Add(s);
            }
        }
        public void unsubscribeAll(Subscriber s)
        {
            using (WriteLocker wl = new WriteLocker(ref mSubscribersLock))
            {
                for (int i = 0; i < mDataSource.channelsCount; ++i)
                {
                    mSubscribers[i].Remove(s);
                }
            }
        }
        public bool isSubscribed(Subscriber s, int channelNumber)
        {
            using (ReadLocker wl = new ReadLocker(ref mSubscribersLock))
            {
                if (channelNumber > mSubscribers.Count)
                    return false;
                return mSubscribers[channelNumber - 1].Contains(s);
            }
        }

        public List<int> channels(Subscriber s)
        {
            List<int> ret = new List<int>();
            using (ReadLocker rl = new ReadLocker(ref mSubscribersLock))
            {
                for (int i = 0; i < mSubscribers.Count; ++i)
                {
                    if (mSubscribers[i].Contains(s))
                    {
                        ret.Add(i + 1);
                    }
                }
            }
            return ret;
        }

        public void onDataCame(int channelNumber, byte[] data)
        {
            ByteArrayDataPackage package = new ByteArrayDataPackage(channelNumber, data);
            LatencyCounter.receivedPackage(package.id);
            Subscriber[] mReveiverSubscribers;
            using (ReadLocker rl = new ReadLocker(ref mSubscribersLock))
            {
                mReveiverSubscribers = new Subscriber[mSubscribers[package.channelNumber - 1].Count];
                mSubscribers[package.channelNumber - 1].CopyTo(mReveiverSubscribers);
            }
            foreach (Subscriber s in mReveiverSubscribers)
            {
                s.onDataCame(package);
            }
            LatencyCounter.gavePackage(package.id);
        }

        // private
        private AbstractDataSource mDataSource;
        ReaderWriterLock mSubscribersLock;
        List<HashSet<Subscriber>> mSubscribers;
    }
}
