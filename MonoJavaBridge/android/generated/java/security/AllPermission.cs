namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AllPermission : java.security.Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AllPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22891;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.AllPermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.AllPermission._equals22891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22892;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.AllPermission.staticClass, "hashCode", "()I", ref global::java.security.AllPermission._hashCode22892);
		}
		internal static global::MonoJavaBridge.MethodId _implies22893;
		public sealed override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.AllPermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.AllPermission._implies22893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions22894;
		public sealed override global::java.lang.String getActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.AllPermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.security.AllPermission._getActions22894) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection22895;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.AllPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.security.AllPermission._newPermissionCollection22895) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _AllPermission22896;
		public AllPermission() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AllPermission._AllPermission22896.native == global::System.IntPtr.Zero)
				global::java.security.AllPermission._AllPermission22896 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._AllPermission22896);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AllPermission22897;
		public AllPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AllPermission._AllPermission22897.native == global::System.IntPtr.Zero)
				global::java.security.AllPermission._AllPermission22897 = @__env.GetMethodIDNoThrow(global::java.security.AllPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AllPermission.staticClass, global::java.security.AllPermission._AllPermission22897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AllPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AllPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AllPermission"));
		}
		internal static void InitJNI()
		{
		}
	}
}