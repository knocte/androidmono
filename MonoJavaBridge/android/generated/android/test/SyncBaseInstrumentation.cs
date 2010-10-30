namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncBaseInstrumentation : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncBaseInstrumentation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setUp12319;
		protected override void setUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.SyncBaseInstrumentation.staticClass, "setUp", "()V", ref global::android.test.SyncBaseInstrumentation._setUp12319);
		}
		internal static global::MonoJavaBridge.MethodId _syncProvider12320;
		protected virtual void syncProvider(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.SyncBaseInstrumentation.staticClass, "syncProvider", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.test.SyncBaseInstrumentation._syncProvider12320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cancelSyncsandDisableAutoSync12321;
		protected virtual void cancelSyncsandDisableAutoSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.SyncBaseInstrumentation.staticClass, "cancelSyncsandDisableAutoSync", "()V", ref global::android.test.SyncBaseInstrumentation._cancelSyncsandDisableAutoSync12321);
		}
		internal static global::MonoJavaBridge.MethodId _SyncBaseInstrumentation12322;
		public SyncBaseInstrumentation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.SyncBaseInstrumentation._SyncBaseInstrumentation12322.native == global::System.IntPtr.Zero)
				global::android.test.SyncBaseInstrumentation._SyncBaseInstrumentation12322 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._SyncBaseInstrumentation12322);
			Init(@__env, handle);
		}
		static SyncBaseInstrumentation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.SyncBaseInstrumentation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/SyncBaseInstrumentation"));
		}
		internal static void InitJNI()
		{
		}
	}
}