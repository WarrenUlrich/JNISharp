using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.ToolInterface
{
    public class JVMTIErrorException : Exception
    {
        public JVMTIErrorException(JVMTI.Error error) : base($"JVMTI Error: {error}") { }

        public JVMTIErrorException(JVMTI.Error error, Exception inner) : base($"JVMTI Error: {error}", inner) { }
    }
}
