namespace JNISharp.ToolInterface;


public class JMethodSignature
{
    public string Name { get; init; }

    public string Signature { get; init; }

    public string Generic { get; init; }

    public JMethodAccessFlags AccessFlags { get; init; }

    public JMethodSignature(string name, string sig, string generic, JMethodAccessFlags flags)
    {
        this.Name = name;
        this.Signature = sig;
        this.Generic = generic;
        this.AccessFlags = flags;
    }
}
