using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DeltixTest2
{
    class AvarageCounter
    {
        // public
        public AvarageCounter(int maxCount)
        {
            mMaxCount = maxCount;
            mList = new List<double>();
            mSum = 0;
        }

        public void add(double value)
        {
            mList.Add(value);
            while (mList.Count > mMaxCount)
            {
                mSum -= mList[0];
                mList.RemoveAt(0);
            }
            mSum += value;
        }

        public double avarage
        {
            get
            {
                if (mList.Count == 0)
                    return 0;
                return mSum / mList.Count;
            }
        }

        // private
        private int mMaxCount;
        private List<double> mList;
        private double mSum;
    };

    static class LatencyCounter
    {
        // public
        public static void init()
        {
            mCounter = new AvarageCounter(Constants.kMaxSamplesCount);
            mPendingPackages = new Dictionary<string, DateTime>();
        }

        public static void receivedPackage(string id)
        {
            Monitor.Enter(mPendingPackages);
            mPendingPackages.Add(id, DateTime.Now);
            Monitor.Exit(mPendingPackages);
        }

        public static void gavePackage(string id)
        {
            Monitor.Enter(mPendingPackages);
            mCounter.add((DateTime.Now - mPendingPackages[id]).TotalMilliseconds);
            mPendingPackages.Remove(id);
            Monitor.Exit(mPendingPackages);
        }

        public static double avarageLatency()
        {
            return mCounter.avarage;
        }

        // private
        private static AvarageCounter mCounter;
        private static Dictionary<string, DateTime> mPendingPackages;
    }
}
