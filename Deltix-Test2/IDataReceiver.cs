using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeltixTest2
{
    public delegate void DataCame(int channelNumber, byte[] data);

    interface IDataReceiver
    {
        void onDataCame(int channelNumber, byte[] data);
    }
}
