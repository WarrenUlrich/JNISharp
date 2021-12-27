namespace JNISharp.ToolInterface;

using System.Text.Json.Serialization;

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
