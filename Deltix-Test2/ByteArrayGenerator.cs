using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeltixTest2
{
    class ByteArrayGenerator
    {
        // public
        public ByteArrayGenerator()
        {
            mRandom = new Random((int)DateTime.Now.Ticks);
            mSourceString = new byte[Constants.kSourceStringLength + Constants.kMaxStringLength];
            for (int i = 0; i < Constants.kSourceStringLength + Constants.kMaxStringLength; ++i)
            {
                mSourceString[i] = (byte)mRandom.Next(Constants.kMinCharacter, Constants.kMaxCharacter);
            }
        }

        public byte[] generate()
        {
            int index = mRandom.Next(Constants.kSourceStringLength);
            int size = mRandom.Next(Constants.kMaxStringLength);
            byte[] ret = new byte[size];
            Array.Copy(mSourceString, index, ret, 0, size);
            return ret;
        }

        // private
        private Random mRandom;
        private byte[] mSourceString;
    }
}
