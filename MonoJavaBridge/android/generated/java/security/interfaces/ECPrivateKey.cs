namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.ECPrivateKey_))]
	public partial interface ECPrivateKey : PrivateKey, ECKey
	{
		global::java.math.BigInteger getS();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.ECPrivateKey))]
	internal sealed partial class ECPrivateKey_ : java.lang.Object, ECPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ECPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getS23914;
		global::java.math.BigInteger java.security.interfaces.ECPrivateKey.getS()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getS", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.ECPrivateKey_._getS23914) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23915;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.ECPrivateKey_._getEncoded23915) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23916;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.ECPrivateKey_._getAlgorithm23916) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23917;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.ECPrivateKey_._getFormat23917) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23918;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;", ref global::java.security.interfaces.ECPrivateKey_._getParams23918) as java.security.spec.ECParameterSpec;
		}
		static ECPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPrivateKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}