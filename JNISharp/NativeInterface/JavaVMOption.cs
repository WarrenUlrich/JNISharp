using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JavaVMOption
    {
        public IntPtr OptionString;

        public IntPtr ExtraInfo;

        public JavaVMOption(string optionString)
        {
            this.OptionString = Marshal.StringToHGlobalAnsi(optionString);
            this.ExtraInfo = IntPtr.Zero;
        }
    }
}
