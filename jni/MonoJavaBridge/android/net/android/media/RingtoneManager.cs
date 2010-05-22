namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RingtoneManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static RingtoneManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.RingtoneManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.RingtoneManager(@__env); 
			} 
		} 
		protected RingtoneManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDefault4324; 
		public static bool isDefault(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.media.RingtoneManager.staticClass, _isDefault4324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setType4325; 
		public virtual void setType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				@__env.CallVoidMethod(this, _setType4325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.RingtoneManager.staticClass, _setType4325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inferStreamType4326; 
		public virtual int inferStreamType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				return @__env.CallIntMethod(this, _inferStreamType4326); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.RingtoneManager.staticClass, _inferStreamType4326); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStopPreviousRingtone4327; 
		public virtual void setStopPreviousRingtone(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				@__env.CallVoidMethod(this, _setStopPreviousRingtone4327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.RingtoneManager.staticClass, _setStopPreviousRingtone4327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopPreviousRingtone4328; 
		public virtual void stopPreviousRingtone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				@__env.CallVoidMethod(this, _stopPreviousRingtone4328); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.RingtoneManager.staticClass, _stopPreviousRingtone4328); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStopPreviousRingtone4329; 
		public virtual bool getStopPreviousRingtone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				return @__env.CallBooleanMethod(this, _getStopPreviousRingtone4329); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.RingtoneManager.staticClass, _getStopPreviousRingtone4329); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIncludeDrm4330; 
		public virtual bool getIncludeDrm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				return @__env.CallBooleanMethod(this, _getIncludeDrm4330); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.RingtoneManager.staticClass, _getIncludeDrm4330); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIncludeDrm4331; 
		public virtual void setIncludeDrm(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				@__env.CallVoidMethod(this, _setIncludeDrm4331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.RingtoneManager.staticClass, _setIncludeDrm4331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursor4332; 
		public virtual android.database.Cursor getCursor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _getCursor4332)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.RingtoneManager.staticClass, _getCursor4332)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingtone4333; 
		public virtual android.media.Ringtone getRingtone(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.Ringtone>(@__env, @__env.CallObjectMethodPtr(this, _getRingtone4333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.Ringtone>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.RingtoneManager.staticClass, _getRingtone4333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingtone4334; 
		public static android.media.Ringtone getRingtone(android.content.Context arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.Ringtone>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, _getRingtone4334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingtoneUri4335; 
		public virtual android.net.Uri getRingtoneUri(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _getRingtoneUri4335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.RingtoneManager.staticClass, _getRingtoneUri4335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingtonePosition4336; 
		public virtual int getRingtonePosition(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.RingtoneManager)) 
				return @__env.CallIntMethod(this, _getRingtonePosition4336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.RingtoneManager.staticClass, _getRingtonePosition4336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValidRingtoneUri4337; 
		public static android.net.Uri getValidRingtoneUri(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, _getValidRingtoneUri4337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActualDefaultRingtoneUri4338; 
		public static android.net.Uri getActualDefaultRingtoneUri(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, _getActualDefaultRingtoneUri4338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setActualDefaultRingtoneUri4339; 
		public static void setActualDefaultRingtoneUri(android.content.Context arg0, int arg1, android.net.Uri arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.media.RingtoneManager.staticClass, _setActualDefaultRingtoneUri4339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultType4340; 
		public static int getDefaultType(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.RingtoneManager.staticClass, _getDefaultType4340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultUri4341; 
		public static android.net.Uri getDefaultUri(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.media.RingtoneManager.staticClass, _getDefaultUri4341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtoneManager4342; 
		public RingtoneManager(android.app.Activity arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.RingtoneManager.staticClass, _RingtoneManager4342, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RingtoneManager4343; 
		public RingtoneManager(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.RingtoneManager.staticClass, _RingtoneManager4343, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int TYPE_RINGTONE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int TYPE_NOTIFICATION
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int TYPE_ALARM
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int TYPE_ALL
		{ 
			get 
			{ 
				return 7; 
			} 
		} 
		public static java.lang.String ACTION_RINGTONE_PICKER
		{ 
			get 
			{ 
				return "android.intent.action.RINGTONE_PICKER"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_SHOW_DEFAULT
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.SHOW_DEFAULT"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_SHOW_SILENT
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.SHOW_SILENT"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_INCLUDE_DRM
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.INCLUDE_DRM"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_EXISTING_URI
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.EXISTING_URI"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_DEFAULT_URI
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.DEFAULT_URI"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_TYPE
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.TYPE"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_TITLE
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.TITLE"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGTONE_PICKED_URI
		{ 
			get 
			{ 
				return "android.intent.extra.ringtone.PICKED_URI"; 
			} 
		} 
		public static int ID_COLUMN_INDEX
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int TITLE_COLUMN_INDEX
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int URI_COLUMN_INDEX
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.RingtoneManager.staticClass = @__class; 
			global::android.media.RingtoneManager._isDefault4324 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "isDefault", "(Landroid/net/Uri;)Z"); 
			global::android.media.RingtoneManager._setType4325 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "setType", "(I)V"); 
			global::android.media.RingtoneManager._inferStreamType4326 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "inferStreamType", "()I"); 
			global::android.media.RingtoneManager._setStopPreviousRingtone4327 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "setStopPreviousRingtone", "(Z)V"); 
			global::android.media.RingtoneManager._stopPreviousRingtone4328 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "stopPreviousRingtone", "()V"); 
			global::android.media.RingtoneManager._getStopPreviousRingtone4329 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getStopPreviousRingtone", "()Z"); 
			global::android.media.RingtoneManager._getIncludeDrm4330 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getIncludeDrm", "()Z"); 
			global::android.media.RingtoneManager._setIncludeDrm4331 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "setIncludeDrm", "(Z)V"); 
			global::android.media.RingtoneManager._getCursor4332 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getCursor", "()Landroid/database/Cursor;"); 
			global::android.media.RingtoneManager._getRingtone4333 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getRingtone", "(I)Landroid/media/Ringtone;"); 
			global::android.media.RingtoneManager._getRingtone4334 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getRingtone", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/Ringtone;"); 
			global::android.media.RingtoneManager._getRingtoneUri4335 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getRingtoneUri", "(I)Landroid/net/Uri;"); 
			global::android.media.RingtoneManager._getRingtonePosition4336 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "getRingtonePosition", "(Landroid/net/Uri;)I"); 
			global::android.media.RingtoneManager._getValidRingtoneUri4337 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;"); 
			global::android.media.RingtoneManager._getActualDefaultRingtoneUri4338 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getActualDefaultRingtoneUri", "(Landroid/content/Context;I)Landroid/net/Uri;"); 
			global::android.media.RingtoneManager._setActualDefaultRingtoneUri4339 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "setActualDefaultRingtoneUri", "(Landroid/content/Context;ILandroid/net/Uri;)V"); 
			global::android.media.RingtoneManager._getDefaultType4340 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getDefaultType", "(Landroid/net/Uri;)I"); 
			global::android.media.RingtoneManager._getDefaultUri4341 = @__env.GetStaticMethodID(global::android.media.RingtoneManager.staticClass, "getDefaultUri", "(I)Landroid/net/Uri;"); 
			global::android.media.RingtoneManager._RingtoneManager4342 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/app/Activity;)V"); 
			global::android.media.RingtoneManager._RingtoneManager4343 = @__env.GetMethodID(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 