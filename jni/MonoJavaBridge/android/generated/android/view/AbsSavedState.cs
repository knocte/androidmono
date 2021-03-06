namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.AbsSavedState_))]
	public abstract partial class AbsSavedState : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSavedState()
		{
			InitJNI();
		}
		protected AbsSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8672;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.AbsSavedState._writeToParcel8672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._writeToParcel8672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8673;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.AbsSavedState._describeContents8673);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._describeContents8673);
		}
		internal static global::MonoJavaBridge.MethodId _getSuperState8674;
		public virtual global::android.os.Parcelable getSuperState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.AbsSavedState._getSuperState8674)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._getSuperState8674)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _AbsSavedState8675;
		protected AbsSavedState(android.os.Parcelable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._AbsSavedState8675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSavedState8676;
		protected AbsSavedState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._AbsSavedState8676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_STATE8677;
		public static global::android.view.AbsSavedState EMPTY_STATE
		{
			get
			{
				return default(global::android.view.AbsSavedState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR8678;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.AbsSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/AbsSavedState"));
			global::android.view.AbsSavedState._writeToParcel8672 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.AbsSavedState._describeContents8673 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "describeContents", "()I");
			global::android.view.AbsSavedState._getSuperState8674 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "getSuperState", "()Landroid/os/Parcelable;");
			global::android.view.AbsSavedState._AbsSavedState8675 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
			global::android.view.AbsSavedState._AbsSavedState8676 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.AbsSavedState))]
	public sealed partial class AbsSavedState_ : android.view.AbsSavedState
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSavedState_()
		{
			InitJNI();
		}
		internal AbsSavedState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.AbsSavedState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/AbsSavedState"));
		}
	}
}
