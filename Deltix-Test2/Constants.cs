using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeltixTest2
{
    static class Constants
    {
        // ByteArrayGenerator
        public static int kSourceStringLength = 1000;
        public static int kMaxStringLength = 100;
        public static int kMinCharacter = 32;
        public static int kMaxCharacter = 127;
        // Channel
        public static int kDefaultIntervalMs = 50;
        // DataSource
        public static int kChannelsCount = 1000;
        // DataReceiver
        public static int kInitialSubscribersCount = 100;
        public static int kDefaultSubscribersChannelsCount = 10;
        // LatencyCounter
        public static int kMaxSamplesCount = 1000;
        // Common
        public static int kLockTimoutMs = 1000;
    }
}
