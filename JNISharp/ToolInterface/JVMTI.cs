using JNISharp.NativeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.ToolInterface
{
    public unsafe static partial class JVMTI
    {
        internal static JVMTIEnv* Env;

        internal static Dictionary<string, JClass> LoadedClassCache { get; set; } = new();

        static JVMTI()
        {
            if(Env == null)
            {
                unsafe
                {
                    var err = JNI.VM->Functions->GetEnv(JNI.VM, out IntPtr env, (int)JVMTI.Version.V1);

                    if (err != JNI.Result.Ok)
                        throw new Exception("Failed to initialize JVMTI");

                    if (env == IntPtr.Zero)
                        throw new Exception($"Failed to initialize JVMTI");

                    Env = (JVMTIEnv*)env;
                }                
            }
        }

        public static JClass GetLoadedClass(string sig)
        {
            if(LoadedClassCache.TryGetValue(sig, out JClass found))
            {
                return found;
            }
            else
            {
                foreach (JClass cls in GetLoadedClasses())
                {
                    if (GetClassSignature(cls).Item1 == sig)
                    {
                        JClass global = JNI.NewGlobalRef<JClass>(cls);

                        LoadedClassCache.Add(sig, global);
                        return global;
                    }
                }
            }

            return null;
        }

        public static IEnumerable<JClass> GetLoadedClasses()
        {
            unsafe
            {
                var err = Env->Functions->GetLoadedClasses(Env, out int length, out IntPtr arrayHandle);

                if (err != JVMTI.Error.None)
                    throw new JVMTIErrorException(err);

                return new JVMTIArray<JClass>(arrayHandle, length);
            }
        }

        public static Tuple<string, string> GetClassSignature(JClass cls)
        {
            var err = Env->Functions->GetClassSignature(Env, cls.Handle, out IntPtr sigPtr, out IntPtr genericPtr);

            if (err != JVMTI.Error.None && err != JVMTI.Error.ClassNotPrepared)
                throw new JVMTIErrorException(err);

            string sigString = null;
            string genericString = null;

            if(sigPtr != IntPtr.Zero)
            {
                sigString = Marshal.PtrToStringAnsi(sigPtr);

                if(genericPtr != IntPtr.Zero)
                {
                    genericString = Marshal.PtrToStringAnsi(genericPtr);
                }
            }
            Deallocate(sigPtr);
            Deallocate(genericPtr);

            return new Tuple<string, string>(sigString, genericString);
        }

        public static JClassSignature GetSignature(this JClass cls)
        {
            unsafe
            {
                var err = Env->Functions->GetClassSignature(Env, cls.Handle, out IntPtr sigPtr, out IntPtr genericPtr);

                if (err != JVMTI.Error.None && err != JVMTI.Error.ClassNotPrepared)
                    throw new JVMTIErrorException(err);

                string sigString = null;
                string genericString = null;

                if(sigPtr != IntPtr.Zero)
                {
                    sigString = Marshal.PtrToStringAnsi(sigPtr);
                    
                    if(genericPtr != IntPtr.Zero)
                    {
                        genericString = Marshal.PtrToStringAnsi(genericPtr);
                    }
                }

                Deallocate(sigPtr);
                Deallocate(genericPtr);

                return new JClassSignature(
                    sigString, 
                    genericString, 
                    cls.GetFields().Select(f => f.GetSignature(cls)), 
                    cls.GetMethods().Select(m => m.GetSignature()));
            }
        }

        public static IEnumerable<JMethodID> GetMethods(this JClass cls)
        {
            unsafe
            {
                var err = Env->Functions->GetClassMethods(Env, cls.Handle, out int length, out IntPtr handle);
                if (err != JVMTI.Error.None && err != JVMTI.Error.ClassNotPrepared)
                    throw new JVMTIErrorException(err);

                return new JVMTIArray<JMethodID>(handle, length);
            }
        }

        public static IEnumerable<JFieldID> GetFields(this JClass cls)
        {
            unsafe
            {
                var err = Env->Functions->GetClassFields(Env, cls.Handle, out int length, out IntPtr handle);
                if (err != JVMTI.Error.None && err != JVMTI.Error.ClassNotPrepared)
                    throw new JVMTIErrorException(err);

                return new JVMTIArray<JFieldID>(handle, length);
            }
        }

        public static JMethodSignature GetSignature(this JMethodID methodID)
        {
            unsafe
            {
                var err = Env->Functions->GetMethodName(Env, methodID, out IntPtr namePtr, out IntPtr sigPtr, out IntPtr genericPtr);
                if (err != JVMTI.Error.None && err != JVMTI.Error.ClassNotPrepared)
                    throw new JVMTIErrorException(err);

                string name = null;
                string sig = null;
                string generic = null;

                if(namePtr != IntPtr.Zero)
                {
                    name = Marshal.PtrToStringAnsi(namePtr);

                    if(sigPtr != IntPtr.Zero)
                    {
                        sig = Marshal.PtrToStringAnsi(sigPtr);
                        if(genericPtr != IntPtr.Zero)
                        {
                            generic = Marshal.PtrToStringAnsi(genericPtr);
                        }
                    }
                }

                Deallocate(namePtr);
                Deallocate(sigPtr);
                Deallocate(genericPtr);

                err = Env->Functions->GetMethodModifiers(Env, methodID, out int modifier);
                if (err != JVMTI.Error.None)
                    throw new Exception($"Failed to get JMethodID modifier. Error: {err}");


                return new JMethodSignature(name, sig, generic, (JMethodAccessFlags)modifier);
            }
        }

        public static JFieldSignature GetSignature(this JFieldID fieldID, JClass cls)
        {
            unsafe
            {
                var err = Env->Functions->GetFieldName(Env, cls.Handle, fieldID, out IntPtr namePtr, out IntPtr sigPtr, out IntPtr genericPtr);
                if (err != JVMTI.Error.None && err != JVMTI.Error.ClassNotPrepared)
                    throw new JVMTIErrorException(err);

                string name = null;
                string sig = null;
                string generic = null;

                if(namePtr != IntPtr.Zero)
                {
                    name = Marshal.PtrToStringAnsi(namePtr);
                    Deallocate(namePtr);
                    if(sigPtr != IntPtr.Zero)
                    {
                        sig = Marshal.PtrToStringAnsi(sigPtr);
                        Deallocate(sigPtr);
                        if(genericPtr != IntPtr.Zero)
                        {
                            generic = Marshal.PtrToStringAnsi(genericPtr);
                            Deallocate(genericPtr);
                        }
                    }
                }

                err = Env->Functions->GetFieldModifiers(Env, cls.Handle, fieldID, out int flags);
                if (err != JVMTI.Error.None && err != JVMTI.Error.ClassNotPrepared)
                    throw new JVMTIErrorException(err);

                return new JFieldSignature(name, sig, generic, (JFieldAccessFlags)flags);
            }
        }

        public static void Deallocate(IntPtr address)
        {
            unsafe
            {
                Env->Functions->Deallocate(Env, address);
            }
        }
    }
}
