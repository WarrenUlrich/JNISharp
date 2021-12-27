namespace JNISharp.ToolInterface;

public static partial class JVMTI
{
    public enum Version
    {
        V1 = 0x30010000,
        V1_1 = 0x30010100,
        V1_2 = 0x30010200,
        V = 0x30000000 + (1 * 0x10000) + (2 * 0x100) + 1
    }
}
