using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public class JThrowableException : Exception
    {
        public JThrowable Throwable { get; init; }

        public JThrowableException() { }

        public JThrowableException(JThrowable throwable) : base()
        {
            this.Throwable = throwable;
        }
    }
}
