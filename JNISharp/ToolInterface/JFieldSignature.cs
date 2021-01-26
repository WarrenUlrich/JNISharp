using JNISharp.NativeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JNISharp.ToolInterface
{
    public class JFieldSignature
    {
        [JsonInclude]
        public string Name { get; init; }

        [JsonInclude]
        public string Signature { get; init; }


        [JsonInclude]
        public string Generic { get; init; }

        [JsonInclude]
        public JFieldAccessFlags AccessFlags { get; init; }

        public JFieldSignature(string name, string sig, string generic, JFieldAccessFlags flags)
        {
            this.Name = name;
            this.Signature = sig;
            this.Generic = generic;
            this.AccessFlags = flags;
        }
    }
}
