using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public static partial class JNI
    {
        public enum ReferenceType
        {
            Local = 0,
            Global = 1,
            WeakGlobal = 2
        }
    }
}
