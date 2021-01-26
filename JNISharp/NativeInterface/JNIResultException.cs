using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public class JNIResultException : Exception
    {
        public JNI.Result Result { get; init; }

        public JNIResultException(JNI.Result result) : base($"JNI error occurred: {result}") 
        {
            this.Result = result;
        }
    }
}
