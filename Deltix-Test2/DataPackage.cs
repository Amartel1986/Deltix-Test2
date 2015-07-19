using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeltixTest2
{
    public class DataPackage<T>
    {
        // public
        public DataPackage(int channelNumber, T data)
        {
            mId = Guid.NewGuid().ToString();
            mChannelNumber = channelNumber;
            mData = data;
        }

        public string id
        {
            get
            {
                return mId;
            }
        }
        public int channelNumber
        {
            get
            {
                return mChannelNumber;
            }
        }
        public T data
        {
            get
            {
                return mData;
            }
        }

        // private
        private string mId;
        private int mChannelNumber;
        private T mData;
    }

    public class ByteArrayDataPackage : DataPackage<byte[]>
    {
        public ByteArrayDataPackage(int channelNumber, byte[] data) :
            base(channelNumber, data)
        {
        }
    }
}
