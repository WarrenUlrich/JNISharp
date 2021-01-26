using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public class JString : JObject
    {
        public JString() : base() { }

        public string GetString() => JNI.GetJStringString(this);
    }
}
