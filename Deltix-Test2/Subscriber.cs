using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeltixTest2
{
    public delegate void SubscriberDataCame(ByteArrayDataPackage package);

    class Subscriber
    {
        // public
        public Subscriber(DataReceiver dataReceiver)
        {
            mDataReceiver = dataReceiver;
            mId = Guid.NewGuid().ToString();
        }

        public string id
        {
            get
            {
                return mId;
            }
        }

        public void subscribe(int channelNumber)
        {
            mDataReceiver.subscribe(this, channelNumber);
        }
        public void unsubscribeAll()
        {
            mDataReceiver.unsubscribeAll(this);
        }
        public bool isSubscribed(int channelNumber)
        {
            return mDataReceiver.isSubscribed(this, channelNumber);
        }
        public List<int> channels()
        {
            return mDataReceiver.channels(this);
        }

        public event SubscriberDataCame dataCame;
        public void onDataCame(ByteArrayDataPackage package)
        {
            if (dataCame != null)
                dataCame(package);
        }

        // private
        private DataReceiver mDataReceiver;
        private string mId;
    }
}
