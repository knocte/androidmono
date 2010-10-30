namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedHashSet : java.util.HashSet, Set, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkedHashSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26344;
		public LinkedHashSet(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._LinkedHashSet26344.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._LinkedHashSet26344 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(IF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26345;
		public LinkedHashSet(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._LinkedHashSet26345.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._LinkedHashSet26345 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26346;
		public LinkedHashSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._LinkedHashSet26346.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._LinkedHashSet26346 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26346);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26347;
		public LinkedHashSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedHashSet._LinkedHashSet26347.native == global::System.IntPtr.Zero)
				global::java.util.LinkedHashSet._LinkedHashSet26347 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LinkedHashSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedHashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedHashSet"));
		}
		internal static void InitJNI()
		{
		}
	}
}