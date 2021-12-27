namespace JNISharp.NativeInterface;

public class JThrowableException : Exception
{
    public JThrowable Throwable { get; init; }

    public JThrowableException() { }

    public JThrowableException(JThrowable throwable) : base()
    {
        this.Throwable = throwable;
    }
}
