namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotYetConnectedException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NotYetConnectedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotYetConnectedException22518;
		public NotYetConnectedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.NotYetConnectedException._NotYetConnectedException22518.native == global::System.IntPtr.Zero)
				global::java.nio.channels.NotYetConnectedException._NotYetConnectedException22518 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NotYetConnectedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NotYetConnectedException.staticClass, global::java.nio.channels.NotYetConnectedException._NotYetConnectedException22518);
			Init(@__env, handle);
		}
		static NotYetConnectedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NotYetConnectedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NotYetConnectedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}