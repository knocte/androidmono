namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CodeSigner : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CodeSigner()
		{
			InitJNI();
		}
		internal CodeSigner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals14762;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.CodeSigner._equals14762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._equals14762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14763;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSigner._toString14763)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._toString14763)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14764;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.CodeSigner._hashCode14764);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._hashCode14764);
		}
		internal static global::MonoJavaBridge.MethodId _getSignerCertPath14765;
		public global::java.security.cert.CertPath getSignerCertPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSigner._getSignerCertPath14765)) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._getSignerCertPath14765)) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp14766;
		public global::java.security.Timestamp getTimestamp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.CodeSigner._getTimestamp14766)) as java.security.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._getTimestamp14766)) as java.security.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _CodeSigner14767;
		public CodeSigner(java.security.cert.CertPath arg0, java.security.Timestamp arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSigner.staticClass, global::java.security.CodeSigner._CodeSigner14767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.CodeSigner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/CodeSigner"));
			global::java.security.CodeSigner._equals14762 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.CodeSigner._toString14763 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.CodeSigner._hashCode14764 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "hashCode", "()I");
			global::java.security.CodeSigner._getSignerCertPath14765 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;");
			global::java.security.CodeSigner._getTimestamp14766 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "getTimestamp", "()Ljava/security/Timestamp;");
			global::java.security.CodeSigner._CodeSigner14767 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "<init>", "(Ljava/security/cert/CertPath;Ljava/security/Timestamp;)V");
		}
	}
}
