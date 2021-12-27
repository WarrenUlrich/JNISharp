namespace JNISharp.ToolInterface;

using JNISharp.NativeInterface;
using System.Runtime.InteropServices;


public static partial class JVMTI
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct EventCallbacks
    {
        /*
         * typedef void (JNICALL *jvmtiEventVMInit)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, void> VMInit;

        /*
         * typedef void (JNICALL *jvmtiEventVMDeath)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, void> VMDeath;

        /*
         * typedef void (JNICALL *jvmtiEventThreadStart)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, void> ThreadStart;

        /*
         * typedef void (JNICALL *jvmtiEventThreadEnd)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, void> ThreadEnd;

        /*
         * typedef void (JNICALL *jvmtiEventClassFileLoadHook)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jclass class_being_redefined, 
             jobject loader, 
             const char* name, 
             jobject protection_domain, 
             jint class_data_len, 
             const unsigned char* class_data, 
             jint* new_class_data_len, 
             unsigned char** new_class_data);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, void> ClassFileLoadHook;

        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, void> ClassLoad;

        /*
         * typedef void (JNICALL *jvmtiEventClassPrepare)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jclass klass);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, void> ClassPrepare;

        /*
         * typedef void (JNICALL *jvmtiEventVMStart)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, void> VmStart;

        /*
         * typedef void (JNICALL *jvmtiEventException)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             jlocation location, 
             jobject exception, 
             jmethodID catch_method, 
             jlocation catch_location);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void> Exception;

        /*
         * typedef void (JNICALL *jvmtiEventExceptionCatch)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             jlocation location, 
             jobject exception);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void> ExceptionCatch;

        /*
         * typedef void (JNICALL *jvmtiEventSingleStep)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             jlocation location);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void> SingleStep;

        /*
         * typedef void (JNICALL *jvmtiEventFramePop)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             jboolean was_popped_by_exception);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, bool, void> FramePop;

        /*
         * typedef void (JNICALL *jvmtiEventBreakpoint)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             jlocation location);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void> BreakPoint;

        /*
         * typedef void (JNICALL *jvmtiEventFieldAccess)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             jlocation location, 
             jclass field_klass, 
             jobject object, 
             jfieldID field);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void> FieldAccess;

        /*
         * typedef void (JNICALL *jvmtiEventFieldModification)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             jlocation location, 
             jclass field_klass, 
             jobject object, 
             jfieldID field, 
             char signature_type, 
             jvalue new_value);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, char, JValue, void> FieldModify;

        /*
         * typedef void (JNICALL *jvmtiEventMethodEntry)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, void> MethodEntry;

        /*
         * typedef void (JNICALL *jvmtiEventMethodExit)
            (jvmtiEnv *jvmti_env, 
            JNIEnv* jni_env, 
            jthread thread, 
            jmethodID method, 
            jboolean was_popped_by_exception, 
            jvalue return_value);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, bool, JValue, void> MethodExit;

        /*
         * typedef void (JNICALL *jvmtiEventNativeMethodBind)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jmethodID method, 
             void* address, 
             void** new_address_ptr);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void> NativeMethodBind;

        /*
         * typedef void (JNICALL *jvmtiEventCompiledMethodLoad)
            (jvmtiEnv *jvmti_env, 
             jmethodID method, 
             jint code_size, 
             const void* code_addr, 
             jint map_length, 
             const jvmtiAddrLocationMap* map, 
             const void* compile_info);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr, void> CompiledMethodLoad;

        /*
         * typedef void (JNICALL *jvmtiEventCompiledMethodUnload)
            (jvmtiEnv *jvmti_env, 
             jmethodID method, 
             const void* code_addr);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, void> CompiledMethodUnload;

        /*
         * typedef void (JNICALL *jvmtiEventDynamicCodeGenerated)
            (jvmtiEnv *jvmti_env, 
             const char* name, 
             const void* address, 
             jint length);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, int, void> DynamicCodeGenerated;

        /*
         * typedef void (JNICALL *jvmtiEventDataDumpRequest)
            (jvmtiEnv *jvmti_env);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, void> DataDumpRequest;

        public IntPtr Reserved72;

        /*
         * typedef void (JNICALL *jvmtiEventMonitorWait)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jobject object, 
             jlong timeout);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, long, void> MonitorWait;

        /*
         * typedef void (JNICALL *jvmtiEventMonitorWaited)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jobject object, 
             jboolean timed_out);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, bool, void> MonitorWaited;

        /*
         * typedef void (JNICALL *jvmtiEventMonitorContendedEnter)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jobject object);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, void> MonitorContendedEnter;

        /*
         * typedef void (JNICALL *jvmtiEventMonitorContendedEntered)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jobject object);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, void> MonitorContendedEnterer;

        public IntPtr Reserved77;

        public IntPtr Reserved78;

        public IntPtr Reserved79;

        /*
         * typedef void (JNICALL *jvmtiEventResourceExhausted)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jint flags, 
             const void* reserved, 
             const char* description);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, IntPtr, IntPtr, void> ResourceExhausted;

        /*
         * typedef void (JNICALL *jvmtiEventGarbageCollectionStart)
            (jvmtiEnv *jvmti_env);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, void> GarbageCollectionStart;

        /*
         * typedef void (JNICALL *jvmtiEventGarbageCollectionFinish)
            (jvmtiEnv *jvmti_env);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, void> GarbageCollectionFinish;

        /*
         * typedef void (JNICALL *jvmtiEventObjectFree)
            (jvmtiEnv *jvmti_env, 
             jlong tag);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, long, void> ObjectFree;

        /*
         * typedef void (JNICALL *jvmtiEventVMObjectAlloc)
            (jvmtiEnv *jvmti_env, 
             JNIEnv* jni_env, 
             jthread thread, 
             jobject object, 
             jclass object_klass, 
             jlong size);
         */
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, void> VmObjectAlloc;
    }
}
