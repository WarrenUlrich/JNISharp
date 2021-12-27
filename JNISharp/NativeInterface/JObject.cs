namespace JNISharp.NativeInterface;

public class JObject : IDisposable
{
    private bool Disposed { get; set; }

    public IntPtr Handle { get; init; }

    internal JNI.ReferenceType ReferenceType { get; init; }

    public JObject() { }

    protected virtual void Dispose(bool disposing)
    {
        if (Disposed)
            return;

        switch (this.ReferenceType)
        {
            case JNI.ReferenceType.Local:
                JNI.DeleteLocalRef(this);
                break;

            case JNI.ReferenceType.Global:
                JNI.DeleteGlobalRef(this);
                break;

            case JNI.ReferenceType.WeakGlobal:
                JNI.DeleteWeakGlobalRef(this);
                break;
        }

        Disposed = true;
    }

    public bool Valid()
    {
        return this.Handle != IntPtr.Zero;
    }

    ~JObject()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
