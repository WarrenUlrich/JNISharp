namespace JNISharp.ToolInterface;

using JNISharp.NativeInterface;
using System.Collections;

internal class JVMTIArray<T> : IDisposable, IEnumerable<T>
{
    private bool Disposed { get; set; }

    private IntPtr Handle { get; init; }

    private T[] Elements { get; init; }

    internal JVMTIArray(IntPtr handle, int length)
    {
        unsafe
        {
            this.Handle = handle;
            IntPtr* arr = (IntPtr*)handle;
            Type t = typeof(T);

            if (t == typeof(JMethodID))
            {
                JMethodID[] buffer = new JMethodID[length];

                for (int i = 0; i < length; i++)
                    buffer[i] = arr[i];

                this.Elements = (T[])(object)buffer;
            }
            else if (t == typeof(JFieldID))
            {
                JFieldID[] buffer = new JFieldID[length];

                for (int i = 0; i < length; i++)
                    buffer[i] = arr[i];

                this.Elements = (T[])(object)buffer;
            }
            else if (t == typeof(JClass))
            {
                JClass[] buffer = new JClass[length];

                for (int i = 0; i < length; i++)
                    buffer[i] = new JClass() { Handle = arr[i], ReferenceType = JNI.ReferenceType.Local };

                this.Elements = (T[])(object)buffer;
            }
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (this.Disposed)
            return;

        JVMTI.Deallocate(this.Handle);

        this.Disposed = true;
    }

    ~JVMTIArray()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    public IEnumerator<T> GetEnumerator()
    {
        //for (int i = 0; i < this.Elements.Length; i++)
        //yield return this.Elements[i];

        return ((IEnumerable<T>)this.Elements).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
