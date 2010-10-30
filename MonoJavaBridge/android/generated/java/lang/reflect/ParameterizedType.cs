namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.ParameterizedType_))]
	public partial interface ParameterizedType : Type
	{
		global::java.lang.reflect.Type[] getActualTypeArguments();
		global::java.lang.reflect.Type getRawType();
		global::java.lang.reflect.Type getOwnerType();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.ParameterizedType))]
	internal sealed partial class ParameterizedType_ : java.lang.Object, ParameterizedType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParameterizedType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActualTypeArguments21145;
		global::java.lang.reflect.Type[] java.lang.reflect.ParameterizedType.getActualTypeArguments()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.ParameterizedType_.staticClass, "getActualTypeArguments", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.ParameterizedType_._getActualTypeArguments21145) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getRawType21146;
		global::java.lang.reflect.Type java.lang.reflect.ParameterizedType.getRawType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.ParameterizedType_.staticClass, "getRawType", "()Ljava/lang/reflect/Type;", ref global::java.lang.reflect.ParameterizedType_._getRawType21146) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerType21147;
		global::java.lang.reflect.Type java.lang.reflect.ParameterizedType.getOwnerType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.ParameterizedType_.staticClass, "getOwnerType", "()Ljava/lang/reflect/Type;", ref global::java.lang.reflect.ParameterizedType_._getOwnerType21147) as java.lang.reflect.Type;
		}
		static ParameterizedType_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.ParameterizedType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/ParameterizedType"));
		}
		internal static void InitJNI()
		{
		}
	}
}