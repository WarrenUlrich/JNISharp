using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public static partial class JNI
    {
        public enum ReleaseMode
        {
            Default = 0,
            Commit = 1,
            Abort = 2
        }
    }
}
