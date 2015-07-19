using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DeltixTest2
{
    static class Debug
    {
        static public void init()
        {
            mLog = new System.IO.StreamWriter("out.log", true);
        }

        static public void log(string s)
        {
            Monitor.Enter(mLog);
            mLog.Write("[" + DateTime.Now.ToString() + "] ");
            mLog.Write(s);
            mLog.WriteLine();
            mLog.Flush();
            Monitor.Exit(mLog);
        }

        static private System.IO.StreamWriter mLog;
    }
}
