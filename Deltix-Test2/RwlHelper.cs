using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DeltixTest2
{
    class ReadLocker : IDisposable
    {
        public ReadLocker(ref ReaderWriterLock rwl)
        {
            mRwl = rwl;
            mRwl.AcquireReaderLock(Constants.kLockTimoutMs);
        }

        public void Dispose()
        {
            mRwl.ReleaseReaderLock();
        }

        private ReaderWriterLock mRwl;
    }

    class WriteLocker : IDisposable
    {
        public WriteLocker(ref ReaderWriterLock rwl)
        {
            mRwl = rwl;
            mRwl.AcquireWriterLock(Constants.kLockTimoutMs);
        }

        public void Dispose()
        {
            mRwl.ReleaseWriterLock();
        }

        private ReaderWriterLock mRwl;
    }
}
