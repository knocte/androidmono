namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Enum_))]
	public abstract partial class Enum : java.lang.Object, Comparable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Enum()
		{
			InitJNI();
		}
		protected Enum(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name12942;
		public virtual global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._name12942)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._name12942)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _finalize12943;
		protected sealed override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Enum._finalize12943);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._finalize12943);
		}
		internal static global::MonoJavaBridge.MethodId _equals12944;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Enum._equals12944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._equals12944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12945;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._toString12945)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._toString12945)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12946;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._hashCode12946);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._hashCode12946);
		}
		internal static global::MonoJavaBridge.MethodId _clone12947;
		protected sealed override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._clone12947)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._clone12947)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12948;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._compareTo12948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo12948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12949;
		public virtual int compareTo(java.lang.Enum arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._compareTo12949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo12949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12950;
		public static global::java.lang.Enum valueOf(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Enum.staticClass, global::java.lang.Enum._valueOf12950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Enum;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass12951;
		public virtual global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._getDeclaringClass12951)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._getDeclaringClass12951)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _ordinal12952;
		public virtual int ordinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._ordinal12952);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._ordinal12952);
		}
		internal static global::MonoJavaBridge.MethodId _Enum12953;
		protected Enum(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Enum.staticClass, global::java.lang.Enum._Enum12953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
			global::java.lang.Enum._name12942 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "name", "()Ljava/lang/String;");
			global::java.lang.Enum._finalize12943 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "finalize", "()V");
			global::java.lang.Enum._equals12944 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Enum._toString12945 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Enum._hashCode12946 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "hashCode", "()I");
			global::java.lang.Enum._clone12947 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.lang.Enum._compareTo12948 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Enum._compareTo12949 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Enum;)I");
			global::java.lang.Enum._valueOf12950 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Enum.staticClass, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
			global::java.lang.Enum._getDeclaringClass12951 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.Enum._ordinal12952 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "ordinal", "()I");
			global::java.lang.Enum._Enum12953 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Enum))]
	public sealed partial class Enum_ : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Enum_()
		{
			InitJNI();
		}
		internal Enum_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
		}
	}
}
