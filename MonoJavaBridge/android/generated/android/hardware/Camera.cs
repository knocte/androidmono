namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Camera : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Camera(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.AutoFocusCallback_))]
		public partial interface AutoFocusCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onAutoFocus(bool arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.AutoFocusCallback))]
		internal sealed partial class AutoFocusCallback_ : java.lang.Object, AutoFocusCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AutoFocusCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onAutoFocus6266;
			void android.hardware.Camera.AutoFocusCallback.onAutoFocus(bool arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.AutoFocusCallback_.staticClass, "onAutoFocus", "(ZLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.AutoFocusCallback_._onAutoFocus6266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static AutoFocusCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.AutoFocusCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$AutoFocusCallback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void AutoFocusCallbackDelegate(bool arg0, android.hardware.Camera arg1);

		internal partial class AutoFocusCallbackDelegateWrapper : java.lang.Object, AutoFocusCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AutoFocusCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _AutoFocusCallbackDelegateWrapper6267;
			public AutoFocusCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper._AutoFocusCallbackDelegateWrapper6267.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper._AutoFocusCallbackDelegateWrapper6267 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.AutoFocusCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper._AutoFocusCallbackDelegateWrapper6267);
				Init(@__env, handle);
			}
			static AutoFocusCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_AutoFocusCallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class AutoFocusCallbackDelegateWrapper
		{
			private AutoFocusCallbackDelegate myDelegate;
			public void onAutoFocus(bool arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator AutoFocusCallbackDelegateWrapper(AutoFocusCallbackDelegate d)
			{
				global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper ret = new global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.ErrorCallback_))]
		public partial interface ErrorCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onError(int arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.ErrorCallback))]
		internal sealed partial class ErrorCallback_ : java.lang.Object, ErrorCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ErrorCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onError6268;
			void android.hardware.Camera.ErrorCallback.onError(int arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.ErrorCallback_.staticClass, "onError", "(ILandroid/hardware/Camera;)V", ref global::android.hardware.Camera.ErrorCallback_._onError6268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static ErrorCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ErrorCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ErrorCallback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void ErrorCallbackDelegate(int arg0, android.hardware.Camera arg1);

		internal partial class ErrorCallbackDelegateWrapper : java.lang.Object, ErrorCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ErrorCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ErrorCallbackDelegateWrapper6269;
			public ErrorCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.ErrorCallbackDelegateWrapper._ErrorCallbackDelegateWrapper6269.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.ErrorCallbackDelegateWrapper._ErrorCallbackDelegateWrapper6269 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ErrorCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.ErrorCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.ErrorCallbackDelegateWrapper._ErrorCallbackDelegateWrapper6269);
				Init(@__env, handle);
			}
			static ErrorCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ErrorCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_ErrorCallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class ErrorCallbackDelegateWrapper
		{
			private ErrorCallbackDelegate myDelegate;
			public void onError(int arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator ErrorCallbackDelegateWrapper(ErrorCallbackDelegate d)
			{
				global::android.hardware.Camera.ErrorCallbackDelegateWrapper ret = new global::android.hardware.Camera.ErrorCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.OnZoomChangeListener_))]
		public partial interface OnZoomChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.OnZoomChangeListener))]
		internal sealed partial class OnZoomChangeListener_ : java.lang.Object, OnZoomChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnZoomChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onZoomChange6270;
			void android.hardware.Camera.OnZoomChangeListener.onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.OnZoomChangeListener_.staticClass, "onZoomChange", "(IZLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.OnZoomChangeListener_._onZoomChange6270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnZoomChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.OnZoomChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$OnZoomChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnZoomChangeListenerDelegate(int arg0, bool arg1, android.hardware.Camera arg2);

		internal partial class OnZoomChangeListenerDelegateWrapper : java.lang.Object, OnZoomChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnZoomChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnZoomChangeListenerDelegateWrapper6271;
			public OnZoomChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper._OnZoomChangeListenerDelegateWrapper6271.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper._OnZoomChangeListenerDelegateWrapper6271 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.OnZoomChangeListenerDelegateWrapper.staticClass, global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper._OnZoomChangeListenerDelegateWrapper6271);
				Init(@__env, handle);
			}
			static OnZoomChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_OnZoomChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnZoomChangeListenerDelegateWrapper
		{
			private OnZoomChangeListenerDelegate myDelegate;
			public void onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnZoomChangeListenerDelegateWrapper(OnZoomChangeListenerDelegate d)
			{
				global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper ret = new global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Parameters : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Parameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get6272;
			public virtual global::java.lang.String get(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._get6272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getInt6273;
			public virtual int getInt(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getInt", "(Ljava/lang/String;)I", ref global::android.hardware.Camera.Parameters._getInt6273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _remove6274;
			public virtual void remove(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "remove", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._remove6274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _set6275;
			public virtual void set(java.lang.String arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._set6275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _set6276;
			public virtual void set(java.lang.String arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;I)V", ref global::android.hardware.Camera.Parameters._set6276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _flatten6277;
			public virtual global::java.lang.String flatten()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "flatten", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._flatten6277) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unflatten6278;
			public virtual void unflatten(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "unflatten", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._unflatten6278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewSize6279;
			public virtual void setPreviewSize(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPreviewSize", "(II)V", ref global::android.hardware.Camera.Parameters._setPreviewSize6279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PreviewSize
			{
				get
				{
					return getPreviewSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPreviewSize6280;
			public virtual global::android.hardware.Camera.Size getPreviewSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPreviewSize", "()Landroid/hardware/Camera$Size;", ref global::android.hardware.Camera.Parameters._getPreviewSize6280) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPreviewSizes
			{
				get
				{
					return getSupportedPreviewSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewSizes6281;
			public virtual global::java.util.List getSupportedPreviewSizes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewSizes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedPreviewSizes6281) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setJpegThumbnailSize6282;
			public virtual void setJpegThumbnailSize(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailSize", "(II)V", ref global::android.hardware.Camera.Parameters._setJpegThumbnailSize6282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size JpegThumbnailSize
			{
				get
				{
					return getJpegThumbnailSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getJpegThumbnailSize6283;
			public virtual global::android.hardware.Camera.Size getJpegThumbnailSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;", ref global::android.hardware.Camera.Parameters._getJpegThumbnailSize6283) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedJpegThumbnailSizes
			{
				get
				{
					return getSupportedJpegThumbnailSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedJpegThumbnailSizes6284;
			public virtual global::java.util.List getSupportedJpegThumbnailSizes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedJpegThumbnailSizes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes6284) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setJpegThumbnailQuality6285;
			public virtual void setJpegThumbnailQuality(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailQuality", "(I)V", ref global::android.hardware.Camera.Parameters._setJpegThumbnailQuality6285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int JpegThumbnailQuality
			{
				get
				{
					return getJpegThumbnailQuality();
				}
				set
				{
					setJpegThumbnailQuality(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getJpegThumbnailQuality6286;
			public virtual int getJpegThumbnailQuality()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailQuality", "()I", ref global::android.hardware.Camera.Parameters._getJpegThumbnailQuality6286);
			}
			internal static global::MonoJavaBridge.MethodId _setJpegQuality6287;
			public virtual void setJpegQuality(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setJpegQuality", "(I)V", ref global::android.hardware.Camera.Parameters._setJpegQuality6287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int JpegQuality
			{
				get
				{
					return getJpegQuality();
				}
				set
				{
					setJpegQuality(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getJpegQuality6288;
			public virtual int getJpegQuality()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getJpegQuality", "()I", ref global::android.hardware.Camera.Parameters._getJpegQuality6288);
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewFrameRate6289;
			public virtual void setPreviewFrameRate(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPreviewFrameRate", "(I)V", ref global::android.hardware.Camera.Parameters._setPreviewFrameRate6289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int PreviewFrameRate
			{
				get
				{
					return getPreviewFrameRate();
				}
				set
				{
					setPreviewFrameRate(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPreviewFrameRate6290;
			public virtual int getPreviewFrameRate()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPreviewFrameRate", "()I", ref global::android.hardware.Camera.Parameters._getPreviewFrameRate6290);
			}
			public new global::java.util.List SupportedPreviewFrameRates
			{
				get
				{
					return getSupportedPreviewFrameRates();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewFrameRates6291;
			public virtual global::java.util.List getSupportedPreviewFrameRates()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFrameRates", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates6291) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewFormat6292;
			public virtual void setPreviewFormat(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPreviewFormat", "(I)V", ref global::android.hardware.Camera.Parameters._setPreviewFormat6292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int PreviewFormat
			{
				get
				{
					return getPreviewFormat();
				}
				set
				{
					setPreviewFormat(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPreviewFormat6293;
			public virtual int getPreviewFormat()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPreviewFormat", "()I", ref global::android.hardware.Camera.Parameters._getPreviewFormat6293);
			}
			public new global::java.util.List SupportedPreviewFormats
			{
				get
				{
					return getSupportedPreviewFormats();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewFormats6294;
			public virtual global::java.util.List getSupportedPreviewFormats()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFormats", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedPreviewFormats6294) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPictureSize6295;
			public virtual void setPictureSize(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPictureSize", "(II)V", ref global::android.hardware.Camera.Parameters._setPictureSize6295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PictureSize
			{
				get
				{
					return getPictureSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPictureSize6296;
			public virtual global::android.hardware.Camera.Size getPictureSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPictureSize", "()Landroid/hardware/Camera$Size;", ref global::android.hardware.Camera.Parameters._getPictureSize6296) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPictureSizes
			{
				get
				{
					return getSupportedPictureSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPictureSizes6297;
			public virtual global::java.util.List getSupportedPictureSizes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureSizes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedPictureSizes6297) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPictureFormat6298;
			public virtual void setPictureFormat(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPictureFormat", "(I)V", ref global::android.hardware.Camera.Parameters._setPictureFormat6298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int PictureFormat
			{
				get
				{
					return getPictureFormat();
				}
				set
				{
					setPictureFormat(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPictureFormat6299;
			public virtual int getPictureFormat()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPictureFormat", "()I", ref global::android.hardware.Camera.Parameters._getPictureFormat6299);
			}
			public new global::java.util.List SupportedPictureFormats
			{
				get
				{
					return getSupportedPictureFormats();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPictureFormats6300;
			public virtual global::java.util.List getSupportedPictureFormats()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureFormats", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedPictureFormats6300) as java.util.List;
			}
			public new int Rotation
			{
				set
				{
					setRotation(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setRotation6301;
			public virtual void setRotation(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setRotation", "(I)V", ref global::android.hardware.Camera.Parameters._setRotation6301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new double GpsLatitude
			{
				set
				{
					setGpsLatitude(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setGpsLatitude6302;
			public virtual void setGpsLatitude(double arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsLatitude", "(D)V", ref global::android.hardware.Camera.Parameters._setGpsLatitude6302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new double GpsLongitude
			{
				set
				{
					setGpsLongitude(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setGpsLongitude6303;
			public virtual void setGpsLongitude(double arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsLongitude", "(D)V", ref global::android.hardware.Camera.Parameters._setGpsLongitude6303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new double GpsAltitude
			{
				set
				{
					setGpsAltitude(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setGpsAltitude6304;
			public virtual void setGpsAltitude(double arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsAltitude", "(D)V", ref global::android.hardware.Camera.Parameters._setGpsAltitude6304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new long GpsTimestamp
			{
				set
				{
					setGpsTimestamp(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setGpsTimestamp6305;
			public virtual void setGpsTimestamp(long arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsTimestamp", "(J)V", ref global::android.hardware.Camera.Parameters._setGpsTimestamp6305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.lang.String GpsProcessingMethod
			{
				set
				{
					setGpsProcessingMethod(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setGpsProcessingMethod6306;
			public virtual void setGpsProcessingMethod(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsProcessingMethod", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._setGpsProcessingMethod6306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _removeGpsData6307;
			public virtual void removeGpsData()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "removeGpsData", "()V", ref global::android.hardware.Camera.Parameters._removeGpsData6307);
			}
			public new global::java.lang.String WhiteBalance
			{
				get
				{
					return getWhiteBalance();
				}
				set
				{
					setWhiteBalance(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWhiteBalance6308;
			public virtual global::java.lang.String getWhiteBalance()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getWhiteBalance", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._getWhiteBalance6308) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setWhiteBalance6309;
			public virtual void setWhiteBalance(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setWhiteBalance", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._setWhiteBalance6309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedWhiteBalance
			{
				get
				{
					return getSupportedWhiteBalance();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedWhiteBalance6310;
			public virtual global::java.util.List getSupportedWhiteBalance()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedWhiteBalance", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedWhiteBalance6310) as java.util.List;
			}
			public new global::java.lang.String ColorEffect
			{
				get
				{
					return getColorEffect();
				}
				set
				{
					setColorEffect(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getColorEffect6311;
			public virtual global::java.lang.String getColorEffect()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getColorEffect", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._getColorEffect6311) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setColorEffect6312;
			public virtual void setColorEffect(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setColorEffect", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._setColorEffect6312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedColorEffects
			{
				get
				{
					return getSupportedColorEffects();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedColorEffects6313;
			public virtual global::java.util.List getSupportedColorEffects()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedColorEffects", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedColorEffects6313) as java.util.List;
			}
			public new global::java.lang.String Antibanding
			{
				get
				{
					return getAntibanding();
				}
				set
				{
					setAntibanding(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getAntibanding6314;
			public virtual global::java.lang.String getAntibanding()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getAntibanding", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._getAntibanding6314) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setAntibanding6315;
			public virtual void setAntibanding(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setAntibanding", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._setAntibanding6315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedAntibanding
			{
				get
				{
					return getSupportedAntibanding();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedAntibanding6316;
			public virtual global::java.util.List getSupportedAntibanding()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedAntibanding", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedAntibanding6316) as java.util.List;
			}
			public new global::java.lang.String SceneMode
			{
				get
				{
					return getSceneMode();
				}
				set
				{
					setSceneMode(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSceneMode6317;
			public virtual global::java.lang.String getSceneMode()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getSceneMode", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._getSceneMode6317) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setSceneMode6318;
			public virtual void setSceneMode(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setSceneMode", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._setSceneMode6318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedSceneModes
			{
				get
				{
					return getSupportedSceneModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedSceneModes6319;
			public virtual global::java.util.List getSupportedSceneModes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedSceneModes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedSceneModes6319) as java.util.List;
			}
			public new global::java.lang.String FlashMode
			{
				get
				{
					return getFlashMode();
				}
				set
				{
					setFlashMode(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFlashMode6320;
			public virtual global::java.lang.String getFlashMode()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getFlashMode", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._getFlashMode6320) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setFlashMode6321;
			public virtual void setFlashMode(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setFlashMode", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._setFlashMode6321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFlashModes
			{
				get
				{
					return getSupportedFlashModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedFlashModes6322;
			public virtual global::java.util.List getSupportedFlashModes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedFlashModes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedFlashModes6322) as java.util.List;
			}
			public new global::java.lang.String FocusMode
			{
				get
				{
					return getFocusMode();
				}
				set
				{
					setFocusMode(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFocusMode6323;
			public virtual global::java.lang.String getFocusMode()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getFocusMode", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._getFocusMode6323) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setFocusMode6324;
			public virtual void setFocusMode(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setFocusMode", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._setFocusMode6324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFocusModes
			{
				get
				{
					return getSupportedFocusModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedFocusModes6325;
			public virtual global::java.util.List getSupportedFocusModes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedFocusModes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getSupportedFocusModes6325) as java.util.List;
			}
			public new float FocalLength
			{
				get
				{
					return getFocalLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFocalLength6326;
			public virtual float getFocalLength()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getFocalLength", "()F", ref global::android.hardware.Camera.Parameters._getFocalLength6326);
			}
			public new float HorizontalViewAngle
			{
				get
				{
					return getHorizontalViewAngle();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHorizontalViewAngle6327;
			public virtual float getHorizontalViewAngle()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getHorizontalViewAngle", "()F", ref global::android.hardware.Camera.Parameters._getHorizontalViewAngle6327);
			}
			public new float VerticalViewAngle
			{
				get
				{
					return getVerticalViewAngle();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getVerticalViewAngle6328;
			public virtual float getVerticalViewAngle()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getVerticalViewAngle", "()F", ref global::android.hardware.Camera.Parameters._getVerticalViewAngle6328);
			}
			public new int ExposureCompensation
			{
				get
				{
					return getExposureCompensation();
				}
				set
				{
					setExposureCompensation(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExposureCompensation6329;
			public virtual int getExposureCompensation()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensation", "()I", ref global::android.hardware.Camera.Parameters._getExposureCompensation6329);
			}
			internal static global::MonoJavaBridge.MethodId _setExposureCompensation6330;
			public virtual void setExposureCompensation(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setExposureCompensation", "(I)V", ref global::android.hardware.Camera.Parameters._setExposureCompensation6330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int MaxExposureCompensation
			{
				get
				{
					return getMaxExposureCompensation();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMaxExposureCompensation6331;
			public virtual int getMaxExposureCompensation()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getMaxExposureCompensation", "()I", ref global::android.hardware.Camera.Parameters._getMaxExposureCompensation6331);
			}
			public new int MinExposureCompensation
			{
				get
				{
					return getMinExposureCompensation();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMinExposureCompensation6332;
			public virtual int getMinExposureCompensation()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getMinExposureCompensation", "()I", ref global::android.hardware.Camera.Parameters._getMinExposureCompensation6332);
			}
			public new float ExposureCompensationStep
			{
				get
				{
					return getExposureCompensationStep();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExposureCompensationStep6333;
			public virtual float getExposureCompensationStep()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensationStep", "()F", ref global::android.hardware.Camera.Parameters._getExposureCompensationStep6333);
			}
			public new int Zoom
			{
				get
				{
					return getZoom();
				}
				set
				{
					setZoom(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getZoom6334;
			public virtual int getZoom()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getZoom", "()I", ref global::android.hardware.Camera.Parameters._getZoom6334);
			}
			internal static global::MonoJavaBridge.MethodId _setZoom6335;
			public virtual void setZoom(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setZoom", "(I)V", ref global::android.hardware.Camera.Parameters._setZoom6335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isZoomSupported6336;
			public virtual bool isZoomSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.Camera.Parameters.staticClass, "isZoomSupported", "()Z", ref global::android.hardware.Camera.Parameters._isZoomSupported6336);
			}
			public new int MaxZoom
			{
				get
				{
					return getMaxZoom();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMaxZoom6337;
			public virtual int getMaxZoom()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getMaxZoom", "()I", ref global::android.hardware.Camera.Parameters._getMaxZoom6337);
			}
			public new global::java.util.List ZoomRatios
			{
				get
				{
					return getZoomRatios();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getZoomRatios6338;
			public virtual global::java.util.List getZoomRatios()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getZoomRatios", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._getZoomRatios6338) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _isSmoothZoomSupported6339;
			public virtual bool isSmoothZoomSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.Camera.Parameters.staticClass, "isSmoothZoomSupported", "()Z", ref global::android.hardware.Camera.Parameters._isSmoothZoomSupported6339);
			}
			public static global::java.lang.String WHITE_BALANCE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_INCANDESCENT
			{
				get
				{
					return "incandescent";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_FLUORESCENT
			{
				get
				{
					return "fluorescent";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_WARM_FLUORESCENT
			{
				get
				{
					return "warm-fluorescent";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_DAYLIGHT
			{
				get
				{
					return "daylight";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_CLOUDY_DAYLIGHT
			{
				get
				{
					return "cloudy-daylight";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_TWILIGHT
			{
				get
				{
					return "twilight";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_SHADE
			{
				get
				{
					return "shade";
				}
			}
			public static global::java.lang.String EFFECT_NONE
			{
				get
				{
					return "none";
				}
			}
			public static global::java.lang.String EFFECT_MONO
			{
				get
				{
					return "mono";
				}
			}
			public static global::java.lang.String EFFECT_NEGATIVE
			{
				get
				{
					return "negative";
				}
			}
			public static global::java.lang.String EFFECT_SOLARIZE
			{
				get
				{
					return "solarize";
				}
			}
			public static global::java.lang.String EFFECT_SEPIA
			{
				get
				{
					return "sepia";
				}
			}
			public static global::java.lang.String EFFECT_POSTERIZE
			{
				get
				{
					return "posterize";
				}
			}
			public static global::java.lang.String EFFECT_WHITEBOARD
			{
				get
				{
					return "whiteboard";
				}
			}
			public static global::java.lang.String EFFECT_BLACKBOARD
			{
				get
				{
					return "blackboard";
				}
			}
			public static global::java.lang.String EFFECT_AQUA
			{
				get
				{
					return "aqua";
				}
			}
			public static global::java.lang.String ANTIBANDING_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String ANTIBANDING_50HZ
			{
				get
				{
					return "50hz";
				}
			}
			public static global::java.lang.String ANTIBANDING_60HZ
			{
				get
				{
					return "60hz";
				}
			}
			public static global::java.lang.String ANTIBANDING_OFF
			{
				get
				{
					return "off";
				}
			}
			public static global::java.lang.String FLASH_MODE_OFF
			{
				get
				{
					return "off";
				}
			}
			public static global::java.lang.String FLASH_MODE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String FLASH_MODE_ON
			{
				get
				{
					return "on";
				}
			}
			public static global::java.lang.String FLASH_MODE_RED_EYE
			{
				get
				{
					return "red-eye";
				}
			}
			public static global::java.lang.String FLASH_MODE_TORCH
			{
				get
				{
					return "torch";
				}
			}
			public static global::java.lang.String SCENE_MODE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String SCENE_MODE_ACTION
			{
				get
				{
					return "action";
				}
			}
			public static global::java.lang.String SCENE_MODE_PORTRAIT
			{
				get
				{
					return "portrait";
				}
			}
			public static global::java.lang.String SCENE_MODE_LANDSCAPE
			{
				get
				{
					return "landscape";
				}
			}
			public static global::java.lang.String SCENE_MODE_NIGHT
			{
				get
				{
					return "night";
				}
			}
			public static global::java.lang.String SCENE_MODE_NIGHT_PORTRAIT
			{
				get
				{
					return "night-portrait";
				}
			}
			public static global::java.lang.String SCENE_MODE_THEATRE
			{
				get
				{
					return "theatre";
				}
			}
			public static global::java.lang.String SCENE_MODE_BEACH
			{
				get
				{
					return "beach";
				}
			}
			public static global::java.lang.String SCENE_MODE_SNOW
			{
				get
				{
					return "snow";
				}
			}
			public static global::java.lang.String SCENE_MODE_SUNSET
			{
				get
				{
					return "sunset";
				}
			}
			public static global::java.lang.String SCENE_MODE_STEADYPHOTO
			{
				get
				{
					return "steadyphoto";
				}
			}
			public static global::java.lang.String SCENE_MODE_FIREWORKS
			{
				get
				{
					return "fireworks";
				}
			}
			public static global::java.lang.String SCENE_MODE_SPORTS
			{
				get
				{
					return "sports";
				}
			}
			public static global::java.lang.String SCENE_MODE_PARTY
			{
				get
				{
					return "party";
				}
			}
			public static global::java.lang.String SCENE_MODE_CANDLELIGHT
			{
				get
				{
					return "candlelight";
				}
			}
			public static global::java.lang.String SCENE_MODE_BARCODE
			{
				get
				{
					return "barcode";
				}
			}
			public static global::java.lang.String FOCUS_MODE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String FOCUS_MODE_INFINITY
			{
				get
				{
					return "infinity";
				}
			}
			public static global::java.lang.String FOCUS_MODE_MACRO
			{
				get
				{
					return "macro";
				}
			}
			public static global::java.lang.String FOCUS_MODE_FIXED
			{
				get
				{
					return "fixed";
				}
			}
			public static global::java.lang.String FOCUS_MODE_EDOF
			{
				get
				{
					return "edof";
				}
			}
			static Parameters()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.Parameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$Parameters"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.PictureCallback_))]
		public partial interface PictureCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onPictureTaken(byte[] arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.PictureCallback))]
		internal sealed partial class PictureCallback_ : java.lang.Object, PictureCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PictureCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPictureTaken6387;
			void android.hardware.Camera.PictureCallback.onPictureTaken(byte[] arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.PictureCallback_.staticClass, "onPictureTaken", "([BLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.PictureCallback_._onPictureTaken6387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static PictureCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PictureCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PictureCallback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void PictureCallbackDelegate(byte[] arg0, android.hardware.Camera arg1);

		internal partial class PictureCallbackDelegateWrapper : java.lang.Object, PictureCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PictureCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _PictureCallbackDelegateWrapper6388;
			public PictureCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.PictureCallbackDelegateWrapper._PictureCallbackDelegateWrapper6388.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.PictureCallbackDelegateWrapper._PictureCallbackDelegateWrapper6388 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PictureCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.PictureCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.PictureCallbackDelegateWrapper._PictureCallbackDelegateWrapper6388);
				Init(@__env, handle);
			}
			static PictureCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PictureCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_PictureCallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class PictureCallbackDelegateWrapper
		{
			private PictureCallbackDelegate myDelegate;
			public void onPictureTaken(byte[] arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator PictureCallbackDelegateWrapper(PictureCallbackDelegate d)
			{
				global::android.hardware.Camera.PictureCallbackDelegateWrapper ret = new global::android.hardware.Camera.PictureCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.PreviewCallback_))]
		public partial interface PreviewCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onPreviewFrame(byte[] arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.PreviewCallback))]
		internal sealed partial class PreviewCallback_ : java.lang.Object, PreviewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PreviewCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPreviewFrame6389;
			void android.hardware.Camera.PreviewCallback.onPreviewFrame(byte[] arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.PreviewCallback_.staticClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.PreviewCallback_._onPreviewFrame6389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static PreviewCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PreviewCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PreviewCallback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void PreviewCallbackDelegate(byte[] arg0, android.hardware.Camera arg1);

		internal partial class PreviewCallbackDelegateWrapper : java.lang.Object, PreviewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PreviewCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _PreviewCallbackDelegateWrapper6390;
			public PreviewCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.PreviewCallbackDelegateWrapper._PreviewCallbackDelegateWrapper6390.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.PreviewCallbackDelegateWrapper._PreviewCallbackDelegateWrapper6390 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PreviewCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.PreviewCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.PreviewCallbackDelegateWrapper._PreviewCallbackDelegateWrapper6390);
				Init(@__env, handle);
			}
			static PreviewCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PreviewCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_PreviewCallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class PreviewCallbackDelegateWrapper
		{
			private PreviewCallbackDelegate myDelegate;
			public void onPreviewFrame(byte[] arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator PreviewCallbackDelegateWrapper(PreviewCallbackDelegate d)
			{
				global::android.hardware.Camera.PreviewCallbackDelegateWrapper ret = new global::android.hardware.Camera.PreviewCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.ShutterCallback_))]
		public partial interface ShutterCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onShutter();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.ShutterCallback))]
		internal sealed partial class ShutterCallback_ : java.lang.Object, ShutterCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ShutterCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onShutter6391;
			void android.hardware.Camera.ShutterCallback.onShutter()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.ShutterCallback_.staticClass, "onShutter", "()V", ref global::android.hardware.Camera.ShutterCallback_._onShutter6391);
			}
			static ShutterCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ShutterCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ShutterCallback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void ShutterCallbackDelegate();

		internal partial class ShutterCallbackDelegateWrapper : java.lang.Object, ShutterCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ShutterCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ShutterCallbackDelegateWrapper6392;
			public ShutterCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.ShutterCallbackDelegateWrapper._ShutterCallbackDelegateWrapper6392.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.ShutterCallbackDelegateWrapper._ShutterCallbackDelegateWrapper6392 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ShutterCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.ShutterCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.ShutterCallbackDelegateWrapper._ShutterCallbackDelegateWrapper6392);
				Init(@__env, handle);
			}
			static ShutterCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ShutterCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_ShutterCallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class ShutterCallbackDelegateWrapper
		{
			private ShutterCallbackDelegate myDelegate;
			public void onShutter()
			{
				myDelegate();
			}
			public static implicit operator ShutterCallbackDelegateWrapper(ShutterCallbackDelegate d)
			{
				global::android.hardware.Camera.ShutterCallbackDelegateWrapper ret = new global::android.hardware.Camera.ShutterCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Size : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Size(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals6393;
			public override bool equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.Camera.Size.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.hardware.Camera.Size._equals6393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _hashCode6394;
			public override int hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Size.staticClass, "hashCode", "()I", ref global::android.hardware.Camera.Size._hashCode6394);
			}
			internal static global::MonoJavaBridge.MethodId _Size6395;
			public Size(android.hardware.Camera arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.Size._Size6395.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.Size._Size6395 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "<init>", "(Landroid/hardware/Camera;II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._Size6395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _width6396;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width6396);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height6397;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height6397);
				}
				set
				{
				}
			}
			static Size()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.Size.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$Size"));
				global::android.hardware.Camera.Size._width6396 = @__env.GetFieldIDNoThrow(global::android.hardware.Camera.Size.staticClass, "width", "I");
				global::android.hardware.Camera.Size._height6397 = @__env.GetFieldIDNoThrow(global::android.hardware.Camera.Size.staticClass, "height", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize6398;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "finalize", "()V", ref global::android.hardware.Camera._finalize6398);
		}
		internal static global::MonoJavaBridge.MethodId _lock6399;
		public virtual void @lock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "@lock", "()V", ref global::android.hardware.Camera._lock6399);
		}
		internal static global::MonoJavaBridge.MethodId _release6400;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "release", "()V", ref global::android.hardware.Camera._release6400);
		}
		internal static global::MonoJavaBridge.MethodId _open6401;
		public static global::android.hardware.Camera open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Camera._open6401.native == global::System.IntPtr.Zero)
				global::android.hardware.Camera._open6401 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.Camera.staticClass, "open", "()Landroid/hardware/Camera;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.hardware.Camera.staticClass, global::android.hardware.Camera._open6401)) as android.hardware.Camera;
		}
		internal static global::MonoJavaBridge.MethodId _unlock6402;
		public virtual void unlock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "unlock", "()V", ref global::android.hardware.Camera._unlock6402);
		}
		internal static global::MonoJavaBridge.MethodId _getParameters6403;
		public virtual global::android.hardware.Camera.Parameters getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.staticClass, "getParameters", "()Landroid/hardware/Camera$Parameters;", ref global::android.hardware.Camera._getParameters6403) as android.hardware.Camera.Parameters;
		}
		internal static global::MonoJavaBridge.MethodId _reconnect6404;
		public virtual void reconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "reconnect", "()V", ref global::android.hardware.Camera._reconnect6404);
		}
		public new global::android.view.SurfaceHolder PreviewDisplay
		{
			set
			{
				setPreviewDisplay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewDisplay6405;
		public virtual void setPreviewDisplay(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V", ref global::android.hardware.Camera._setPreviewDisplay6405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startPreview6406;
		public virtual void startPreview()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "startPreview", "()V", ref global::android.hardware.Camera._startPreview6406);
		}
		internal static global::MonoJavaBridge.MethodId _stopPreview6407;
		public virtual void stopPreview()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "stopPreview", "()V", ref global::android.hardware.Camera._stopPreview6407);
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewCallback6408;
		public virtual void setPreviewCallback(android.hardware.Camera.PreviewCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", ref global::android.hardware.Camera._setPreviewCallback6408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPreviewCallback(global::android.hardware.Camera.PreviewCallbackDelegate arg0)
		{
			setPreviewCallback((global::android.hardware.Camera.PreviewCallbackDelegateWrapper)arg0);
		}
		public new global::android.hardware.Camera.PreviewCallback OneShotPreviewCallback
		{
			set
			{
				setOneShotPreviewCallback(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOneShotPreviewCallback6409;
		public virtual void setOneShotPreviewCallback(android.hardware.Camera.PreviewCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", ref global::android.hardware.Camera._setOneShotPreviewCallback6409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOneShotPreviewCallback(global::android.hardware.Camera.PreviewCallbackDelegate arg0)
		{
			setOneShotPreviewCallback((global::android.hardware.Camera.PreviewCallbackDelegateWrapper)arg0);
		}
		public new global::android.hardware.Camera.PreviewCallback PreviewCallbackWithBuffer
		{
			set
			{
				setPreviewCallbackWithBuffer(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewCallbackWithBuffer6410;
		public virtual void setPreviewCallbackWithBuffer(android.hardware.Camera.PreviewCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setPreviewCallbackWithBuffer", "(Landroid/hardware/Camera$PreviewCallback;)V", ref global::android.hardware.Camera._setPreviewCallbackWithBuffer6410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPreviewCallbackWithBuffer(global::android.hardware.Camera.PreviewCallbackDelegate arg0)
		{
			setPreviewCallbackWithBuffer((global::android.hardware.Camera.PreviewCallbackDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addCallbackBuffer6411;
		public virtual void addCallbackBuffer(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "addCallbackBuffer", "([B)V", ref global::android.hardware.Camera._addCallbackBuffer6411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _autoFocus6412;
		public virtual void autoFocus(android.hardware.Camera.AutoFocusCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V", ref global::android.hardware.Camera._autoFocus6412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void autoFocus(global::android.hardware.Camera.AutoFocusCallbackDelegate arg0)
		{
			autoFocus((global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _cancelAutoFocus6413;
		public virtual void cancelAutoFocus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "cancelAutoFocus", "()V", ref global::android.hardware.Camera._cancelAutoFocus6413);
		}
		internal static global::MonoJavaBridge.MethodId _takePicture6414;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2, android.hardware.Camera.PictureCallback arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V", ref global::android.hardware.Camera._takePicture6414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void takePicture(global::android.hardware.Camera.ShutterCallbackDelegate arg0, global::android.hardware.Camera.PictureCallbackDelegate arg1, global::android.hardware.Camera.PictureCallbackDelegate arg2, global::android.hardware.Camera.PictureCallbackDelegate arg3)
		{
			takePicture((global::android.hardware.Camera.ShutterCallbackDelegateWrapper)arg0, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg1, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg2, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg3);
		}
		internal static global::MonoJavaBridge.MethodId _takePicture6415;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V", ref global::android.hardware.Camera._takePicture6415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void takePicture(global::android.hardware.Camera.ShutterCallbackDelegate arg0, global::android.hardware.Camera.PictureCallbackDelegate arg1, global::android.hardware.Camera.PictureCallbackDelegate arg2)
		{
			takePicture((global::android.hardware.Camera.ShutterCallbackDelegateWrapper)arg0, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg1, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _startSmoothZoom6416;
		public virtual void startSmoothZoom(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "startSmoothZoom", "(I)V", ref global::android.hardware.Camera._startSmoothZoom6416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSmoothZoom6417;
		public virtual void stopSmoothZoom()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "stopSmoothZoom", "()V", ref global::android.hardware.Camera._stopSmoothZoom6417);
		}
		public new int DisplayOrientation
		{
			set
			{
				setDisplayOrientation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDisplayOrientation6418;
		public virtual void setDisplayOrientation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setDisplayOrientation", "(I)V", ref global::android.hardware.Camera._setDisplayOrientation6418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.hardware.Camera.OnZoomChangeListener ZoomChangeListener
		{
			set
			{
				setZoomChangeListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setZoomChangeListener6419;
		public virtual void setZoomChangeListener(android.hardware.Camera.OnZoomChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setZoomChangeListener", "(Landroid/hardware/Camera$OnZoomChangeListener;)V", ref global::android.hardware.Camera._setZoomChangeListener6419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setZoomChangeListener(global::android.hardware.Camera.OnZoomChangeListenerDelegate arg0)
		{
			setZoomChangeListener((global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setErrorCallback6420;
		public virtual void setErrorCallback(android.hardware.Camera.ErrorCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V", ref global::android.hardware.Camera._setErrorCallback6420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setErrorCallback(global::android.hardware.Camera.ErrorCallbackDelegate arg0)
		{
			setErrorCallback((global::android.hardware.Camera.ErrorCallbackDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setParameters6421;
		public virtual void setParameters(android.hardware.Camera.Parameters arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setParameters", "(Landroid/hardware/Camera$Parameters;)V", ref global::android.hardware.Camera._setParameters6421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int CAMERA_ERROR_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int CAMERA_ERROR_SERVER_DIED
		{
			get
			{
				return 100;
			}
		}
		static Camera()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.Camera.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera"));
		}
		internal static void InitJNI()
		{
		}
	}
}