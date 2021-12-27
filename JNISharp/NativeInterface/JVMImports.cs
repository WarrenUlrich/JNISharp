namespace JNISharp.NativeInterface;

using System.Runtime.InteropServices;

internal unsafe static class JVMImports
{
    [DllImport("jvm.dll", CallingConvention = CallingConvention.Winapi)]
    internal static extern JNI.Result JNI_CreateJavaVM(out JavaVM* jvm, out JNIEnv* env, JavaVMInitArgs* args);

    [DllImport("jvm.dll", CallingConvention = CallingConvention.Winapi)]
    internal static extern JNI.Result JNI_GetDefaultJavaVMInitArgs(IntPtr argsPtr);

    [DllImport("jvm.dll", CallingConvention = CallingConvention.Winapi)]
    internal static extern JNI.Result JNI_GetCreatedJavaVMs(out JavaVM* jvm, int bufferLength, out int createdVMs);
}
