namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExemptionMechanism : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExemptionMechanism(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28592;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "finalize", "()V", ref global::javax.crypto.ExemptionMechanism._finalize28592);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName28593;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.ExemptionMechanism.staticClass, "getName", "()Ljava/lang/String;", ref global::javax.crypto.ExemptionMechanism._getName28593) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28594;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanism._getInstance28594.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanism._getInstance28594 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance28594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28595;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanism._getInstance28595.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanism._getInstance28595 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/ExemptionMechanism;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance28595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28596;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanism._getInstance28596.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanism._getInstance28596 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance28596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _init28597;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.ExemptionMechanism._init28597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28598;
		public virtual void init(java.security.Key arg0, java.security.AlgorithmParameters arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V", ref global::javax.crypto.ExemptionMechanism._init28598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28599;
		public virtual void init(java.security.Key arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;)V", ref global::javax.crypto.ExemptionMechanism._init28599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28600;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.crypto.ExemptionMechanism._getProvider28600) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputSize28601;
		public virtual int getOutputSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "getOutputSize", "(I)I", ref global::javax.crypto.ExemptionMechanism._getOutputSize28601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCryptoAllowed28602;
		public virtual bool isCryptoAllowed(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "isCryptoAllowed", "(Ljava/security/Key;)Z", ref global::javax.crypto.ExemptionMechanism._isCryptoAllowed28602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob28603;
		public virtual byte[] genExemptionBlob()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "()[B", ref global::javax.crypto.ExemptionMechanism._genExemptionBlob28603) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob28604;
		public virtual int genExemptionBlob(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "([B)I", ref global::javax.crypto.ExemptionMechanism._genExemptionBlob28604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob28605;
		public virtual int genExemptionBlob(byte[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "([BI)I", ref global::javax.crypto.ExemptionMechanism._genExemptionBlob28605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ExemptionMechanism28606;
		protected ExemptionMechanism(javax.crypto.ExemptionMechanismSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanism._ExemptionMechanism28606.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanism._ExemptionMechanism28606 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "<init>", "(Ljavax/crypto/ExemptionMechanismSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._ExemptionMechanism28606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ExemptionMechanism()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanism.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanism"));
		}
		internal static void InitJNI()
		{
		}
	}
}