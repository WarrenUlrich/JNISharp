namespace JNISharp.ToolInterface;

using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal readonly unsafe struct JVMTIEnv
{
    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct FunctionTable
    {
        internal readonly IntPtr Reserved1;

        // jvmtiError (JNICALL *SetEventNotificationMode) (jvmtiEnv* env,  jvmtiEventMode mode, jvmtiEvent event_type, jthread event_thread, ...);
        internal readonly delegate* unmanaged[Stdcall]<IntPtr, JVMTI.EventMode, JVMTI.Event, IntPtr, JVMTI.Error> SetEventNotificationMode;

        internal readonly IntPtr Reserved3;

        // jvmtiError (JNICALL *GetAllThreads) (jvmtiEnv* env, jint* threads_count_ptr, jthread** threads_ptr);
        internal readonly delegate* unmanaged[Stdcall]<IntPtr, out int, out IntPtr, JVMTI.Error> GetAllThreads;

        // jvmtiError (JNICALL *SuspendThread) (jvmtiEnv* env, jthread thread);
        internal readonly delegate* unmanaged[Stdcall]<IntPtr, IntPtr, JVMTI.Error> SuspendThread;

        internal readonly IntPtr ResumeThread;

        internal readonly IntPtr StopThread;

        internal readonly IntPtr InterruptThread;

        internal readonly IntPtr GetThreadInfo;

        internal readonly IntPtr GetOwnedMonitorInfo;

        internal readonly IntPtr GetCurrentContendedMonitor;

        internal readonly IntPtr RunAgentThread;

        internal readonly IntPtr GetTopThreadGroups;

        internal readonly IntPtr GetThreadGroupInfo;

        internal readonly IntPtr GetThreadGroupChildren;

        internal readonly IntPtr GetFrameCount;

        internal readonly IntPtr GetThreadState;

        internal readonly IntPtr GetCurrentThread;

        internal readonly IntPtr GetFrameLocation;

        internal readonly IntPtr NotifyFramePop;

        internal readonly IntPtr GetLocalObject;

        internal readonly IntPtr GetLocalInt;

        internal readonly IntPtr GetLocalLong;

        internal readonly IntPtr GetLocalFloat;

        internal readonly IntPtr GetLocalDouble;

        internal readonly IntPtr SetLocalObject;

        internal readonly IntPtr SetLocalInt;

        internal readonly IntPtr SetLocalLong;

        internal readonly IntPtr SetLocalFloat;

        internal readonly IntPtr SetLocalDouble;

        internal readonly IntPtr CreateRawMonitor;

        internal readonly IntPtr DestroyRawMonitor;

        internal readonly IntPtr RawMonitorEnter;

        internal readonly IntPtr RawMonitorExit;

        internal readonly IntPtr RawMonitorWait;

        internal readonly IntPtr RawMonitorNotify;

        internal readonly IntPtr RawMonitorNotifyAll;

        internal readonly IntPtr SetBreakpoint;

        internal readonly IntPtr ClearBreakpoint;

        internal readonly IntPtr Reserved40;

        internal readonly IntPtr SetFieldAccessWatch;

        internal readonly IntPtr ClearFieldAccessWatch;

        internal readonly IntPtr SetFieldModificationWatch;

        internal readonly IntPtr ClearFieldModificationWatch;

        internal readonly IntPtr IsModifiableClass;

        internal readonly IntPtr Allocate;

        // jvmtiError (JNICALL *Deallocate) (jvmtiEnv* env, unsigned char* mem);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, JVMTI.Error> Deallocate;

        // jvmtiError (JNICALL *GetClassSignature) (jvmtiEnv* env, jclass klass, char** signature_ptr, char** generic_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out IntPtr, out IntPtr, JVMTI.Error> GetClassSignature;

        internal readonly IntPtr GetClassStatus;

        // jvmtiError (JNICALL *GetSourceFileName) (jvmtiEnv* env, jclass klass, char** source_name_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out IntPtr, JVMTI.Error> GetSourceFileName;

        // jvmtiError (JNICALL *GetClassModifiers) (jvmtiEnv* env, jclass klass, jint* modifiers_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out int, JVMTI.Error> GetClassModifiers;

        // jvmtiError (JNICALL *GetClassMethods) (jvmtiEnv* env, jclass klass, jint* method_count_ptr, jmethodID** methods_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out int, out IntPtr, JVMTI.Error> GetClassMethods;

        // jvmtiError (JNICALL *GetClassFields) (jvmtiEnv* env, jclass klass, jint* field_count_ptr, jfieldID** fields_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out int, out IntPtr, JVMTI.Error> GetClassFields;

        // jvmtiError (JNICALL *GetImplementedInterfaces) (jvmtiEnv* env, jclass klass, jint* interface_count_ptr, jclass** interfaces_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out int, out IntPtr, JVMTI.Error> GetImplementedInterfaces;

        internal readonly IntPtr IsInterface;

        internal readonly IntPtr IsArrayClass;

        internal readonly IntPtr GetClassLoader;

        internal readonly IntPtr GetObjectHashCode;

        internal readonly IntPtr GetObjectMonitorUsage;

        // jvmtiError (JNICALL *GetFieldName) (jvmtiEnv* env, jclass klass, jfieldID field, char** name_ptr, char** signature_ptr, char** generic_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, IntPtr, out IntPtr, out IntPtr, out IntPtr, JVMTI.Error> GetFieldName;

        internal readonly IntPtr GetFieldDeclaringClass;

        // jvmtiError (JNICALL *GetFieldModifiers) (jvmtiEnv* env, jclass klass, jfieldID field, jint* modifiers_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, IntPtr, out int, JVMTI.Error> GetFieldModifiers;

        internal readonly IntPtr IsFieldSynthetic;

        // jvmtiError (JNICALL *GetMethodName) (jvmtiEnv* env, jmethodID method, char** name_ptr, char** signature_ptr, char** generic_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out IntPtr, out IntPtr, out IntPtr, JVMTI.Error> GetMethodName;

        internal readonly IntPtr GetMethodDeclaringClass;

        // jvmtiError (JNICALL *GetMethodModifiers) (jvmtiEnv* env, jmethodID method, jint* modifiers_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out int, JVMTI.Error> GetMethodModifiers;

        internal readonly IntPtr Reserved67;

        internal readonly IntPtr GetMaxLocals;

        internal readonly IntPtr GetArgumentsSize;

        internal readonly IntPtr GetLineNumberTable;

        internal readonly IntPtr GetMethodLocation;

        internal readonly IntPtr GetLocalVariableTable;

        internal readonly IntPtr SetNativeMethodPrefix;

        internal readonly IntPtr SetNativeMethodPrefixes;

        // jvmtiError (JNICALL *GetBytecodes) (jvmtiEnv* env, jmethodID method, jint* bytecode_count_ptr, unsigned char** bytecodes_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out int, out IntPtr, JVMTI.Error> GetBytecodes;

        internal readonly IntPtr IsMethodNative;

        internal readonly IntPtr IsMethodSynthetic;

        // jvmtiError (JNICALL *GetLoadedClasses) (jvmtiEnv* env, jint* class_count_ptr, jclass** classes_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, out int, out IntPtr, JVMTI.Error> GetLoadedClasses;

        internal readonly IntPtr GetClassLoaderClasses;

        internal readonly IntPtr PopFrame;

        internal readonly IntPtr ForceEarlyReturnObject;

        internal readonly IntPtr ForceEarlyReturnInt;

        internal readonly IntPtr ForceEarlyReturnLong;

        internal readonly IntPtr ForceEarlyReturnFloat;

        internal readonly IntPtr ForceEarlyReturnDouble;

        internal readonly IntPtr ForceEarlyReturnVoid;

        internal readonly IntPtr RedefineClasses;

        internal readonly IntPtr GetVersionNumber;

        // jvmtiError (JNICALL *GetCapabilities) (jvmtiEnv* env, jvmtiCapabilities* capabilities_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, JVMTI.Error> GetCapabilities;

        internal readonly IntPtr GetSourceDebugExtension;

        internal readonly IntPtr IsMethodObsolete;

        internal readonly IntPtr SuspendThreadList;

        internal readonly IntPtr ResumeThreadList;

        internal readonly IntPtr Reserved94;

        internal readonly IntPtr Reserved95;

        internal readonly IntPtr Reserved96;

        internal readonly IntPtr Reserved97;

        internal readonly IntPtr Reserved98;

        internal readonly IntPtr Reserved99;

        internal readonly IntPtr GetAllStackTraces;

        internal readonly IntPtr GetThreadListStackTraces;

        internal readonly IntPtr GetThreadLocalStorage;

        internal readonly IntPtr SetThreadLocalStorage;

        internal readonly IntPtr GetStackTrace;

        internal readonly IntPtr Reserved105;

        internal readonly IntPtr GetTag;

        internal readonly IntPtr SetTag;

        internal readonly IntPtr ForceGarbageCollection;

        internal readonly IntPtr IterateOverObjectsReachableFromObject;

        internal readonly IntPtr IterateOverReachableObjects;

        internal readonly IntPtr IterateOverHeap;

        internal readonly IntPtr IterateOverInstancesOfClass;

        internal readonly IntPtr Reserved113;

        internal readonly IntPtr GetObjectsWithTags;

        internal readonly IntPtr FollowReferences;

        internal readonly IntPtr IterateThroughHeap;

        internal readonly IntPtr Reserved117;

        internal readonly IntPtr Reserved118;

        internal readonly IntPtr Reserved119;

        internal readonly IntPtr SetJNIFunctionTable;

        internal readonly IntPtr GetJNIFunctionTable;

        // jvmtiError (JNICALL *SetEventCallbacks) (jvmtiEnv* env, const jvmtiEventCallbacks* callbacks, jint size_of_callbacks);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, JVMTI.EventCallbacks*, int, JVMTI.Error> SetEventCallbacks;

        internal readonly IntPtr GenerateEvents;

        internal readonly IntPtr GetExtensionFunctions;

        internal readonly IntPtr GetExtensionEvents;

        internal readonly IntPtr SetExtensionEventCallback;

        internal readonly IntPtr DisposeEnvironment;

        internal readonly IntPtr GetErrorName;

        internal readonly IntPtr GetJLocationFormat;

        // jvmtiError (JNICALL *GetSystemProperties) (jvmtiEnv* env, jint* count_ptr,char*** property_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, out int, out IntPtr, JVMTI.Error> GetSystemProperties;

        // jvmtiError (JNICALL *GetSystemProperty) (jvmtiEnv* env, const char* property, char** value_ptr);
        internal readonly delegate* unmanaged[Stdcall]<JVMTIEnv*, IntPtr, out IntPtr, JVMTI.Error> GetSystemProperty;

        internal readonly IntPtr SetSystemProperty;

        internal readonly IntPtr GetPhase;

        internal readonly IntPtr GetCurrentThreadCpuTimerInfo;

        internal readonly IntPtr GetCurrentThreadCpuTime;

        internal readonly IntPtr GetThreadCpuTimerInfo;

        internal readonly IntPtr GetThreadCpuTime;

        internal readonly IntPtr GetTimerInfo;

        internal readonly IntPtr GetTime;

        // jvmtiError (JNICALL *GetPotentialCapabilities) (jvmtiEnv* env, jvmtiCapabilities* capabilities_ptr);
        //internal readonly delegate* unmanaged[Stdcall]<IntPtr, JvmtiCapabilities*, JVMTI.Error> GetPotentialCapabilities;

        internal readonly IntPtr Reserved141;

        // jvmtiError (JNICALL *AddCapabilities) (jvmtiEnv* env, const jvmtiCapabilities* capabilities_ptr);
        //internal readonly delegate* unmanaged[Stdcall]<IntPtr, JvmtiCapabilities*, JVMTI.Error> AddCapabilities;

        internal readonly IntPtr RelinquishCapabilities;

        internal readonly IntPtr GetAvailableProcessors;

        internal readonly IntPtr GetClassVersionNumbers;

        internal readonly IntPtr GetConstantPool;

        internal readonly IntPtr GetEnvironmentLocalStorage;

        internal readonly IntPtr SetEnvironmentLocalStorage;

        internal readonly IntPtr AddToBootstrapClassLoaderSearch;

        internal readonly IntPtr SetVerboseFlag;

        internal readonly IntPtr AddToSystemClassLoaderSearch;

        internal readonly IntPtr RetransformClasses;

        internal readonly IntPtr GetOwnedMonitorStackDepthInfo;

        internal readonly IntPtr GetObjectSize;

        internal readonly IntPtr GetLocalInstance;
    }

    internal readonly FunctionTable* Functions;
}
