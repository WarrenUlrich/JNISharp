using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public class JThrowable : JObject
    {
        public JThrowable() { }

        public string GetMessage() => JNI.FindClass("java/lang/Throwable").CallObjectMethod<JString>(this, "toString", "()Ljava/lang/String;").GetString();
    }
}
