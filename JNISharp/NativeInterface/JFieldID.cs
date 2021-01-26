using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public readonly struct JFieldID : IEquatable<JFieldID>
    {
        public readonly IntPtr Handle { get; init; }

        internal JFieldID(IntPtr handle)
        {
            this.Handle = handle;
        }

        public static implicit operator IntPtr(JFieldID fieldID) => fieldID.Handle;

        public static implicit operator JFieldID(IntPtr pointer) => new JFieldID(pointer);

        public bool Equals(JFieldID other)
        {
            return this.Handle == other.Handle;
        }
    }
}
