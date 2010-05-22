namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ProviderInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ProviderInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ProviderInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.ProviderInfo(@__env); 
			} 
		} 
		internal ProviderInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1764; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ProviderInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1764)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ProviderInfo.staticClass, _toString1764)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1765; 
		public sealed override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ProviderInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ProviderInfo.staticClass, _writeToParcel1765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1766; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ProviderInfo)) 
				return @__env.CallIntMethod(this, _describeContents1766); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.ProviderInfo.staticClass, _describeContents1766); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProviderInfo1767; 
		public ProviderInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ProviderInfo.staticClass, _ProviderInfo1767, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProviderInfo1768; 
		public ProviderInfo(android.content.pm.ProviderInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ProviderInfo.staticClass, _ProviderInfo1768, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _authority1769; 
		public java.lang.String authority
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _readPermission1770; 
		public java.lang.String readPermission
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _writePermission1771; 
		public java.lang.String writePermission
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _grantUriPermissions1772; 
		public bool grantUriPermissions
		{ 
			get 
			{ 
				return default(bool); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _uriPermissionPatterns1773; 
		public android.os.PatternMatcher[] uriPermissionPatterns
		{ 
			get 
			{ 
				return default(android.os.PatternMatcher[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _pathPermissions1774; 
		public android.content.pm.PathPermission[] pathPermissions
		{ 
			get 
			{ 
				return default(android.content.pm.PathPermission[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _multiprocess1775; 
		public bool multiprocess
		{ 
			get 
			{ 
				return default(bool); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _initOrder1776; 
		public int initOrder
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _isSyncable1777; 
		public bool isSyncable
		{ 
			get 
			{ 
				return default(bool); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1778; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.ProviderInfo.staticClass = @__class; 
			global::android.content.pm.ProviderInfo._toString1764 = @__env.GetMethodID(global::android.content.pm.ProviderInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.ProviderInfo._writeToParcel1765 = @__env.GetMethodID(global::android.content.pm.ProviderInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.ProviderInfo._describeContents1766 = @__env.GetMethodID(global::android.content.pm.ProviderInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.ProviderInfo._ProviderInfo1767 = @__env.GetMethodID(global::android.content.pm.ProviderInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.ProviderInfo._ProviderInfo1768 = @__env.GetMethodID(global::android.content.pm.ProviderInfo.staticClass, "<init>", "(Landroid/content/pm/ProviderInfo;)V"); 
		} 
	} 
} 