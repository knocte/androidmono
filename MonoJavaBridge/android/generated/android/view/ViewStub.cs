namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ViewStub : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ViewStub(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewStub.OnInflateListener_))]
		public partial interface OnInflateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onInflate(android.view.ViewStub arg0, android.view.View arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewStub.OnInflateListener))]
		internal sealed partial class OnInflateListener_ : java.lang.Object, OnInflateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnInflateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onInflate15206;
			void android.view.ViewStub.OnInflateListener.onInflate(android.view.ViewStub arg0, android.view.View arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.OnInflateListener_.staticClass, "onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V", ref global::android.view.ViewStub.OnInflateListener_._onInflate15206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnInflateListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewStub.OnInflateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub$OnInflateListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnInflateListenerDelegate(android.view.ViewStub arg0, android.view.View arg1);

		internal partial class OnInflateListenerDelegateWrapper : java.lang.Object, OnInflateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnInflateListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnInflateListenerDelegateWrapper15207;
			public OnInflateListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewStub.OnInflateListenerDelegateWrapper._OnInflateListenerDelegateWrapper15207.native == global::System.IntPtr.Zero)
					global::android.view.ViewStub.OnInflateListenerDelegateWrapper._OnInflateListenerDelegateWrapper15207 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.OnInflateListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.OnInflateListenerDelegateWrapper.staticClass, global::android.view.ViewStub.OnInflateListenerDelegateWrapper._OnInflateListenerDelegateWrapper15207);
				Init(@__env, handle);
			}
			static OnInflateListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewStub.OnInflateListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub_OnInflateListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnInflateListenerDelegateWrapper
		{
			private OnInflateListenerDelegate myDelegate;
			public void onInflate(android.view.ViewStub arg0, android.view.View arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnInflateListenerDelegateWrapper(OnInflateListenerDelegate d)
			{
				global::android.view.ViewStub.OnInflateListenerDelegateWrapper ret = new global::android.view.ViewStub.OnInflateListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _inflate15208;
		public global::android.view.View inflate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewStub.staticClass, "inflate", "()Landroid/view/View;", ref global::android.view.ViewStub._inflate15208) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _draw15209;
		public sealed override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.view.ViewStub._draw15209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Visibility
		{
			set
			{
				setVisibility(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility15210;
		public sealed override void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setVisibility", "(I)V", ref global::android.view.ViewStub._setVisibility15210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutResource15211;
		public void setLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setLayoutResource", "(I)V", ref global::android.view.ViewStub._setLayoutResource15211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int LayoutResource
		{
			get
			{
				return getLayoutResource();
			}
			set
			{
				setLayoutResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutResource15212;
		public int getLayoutResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewStub.staticClass, "getLayoutResource", "()I", ref global::android.view.ViewStub._getLayoutResource15212);
		}
		public new int InflatedId
		{
			get
			{
				return getInflatedId();
			}
			set
			{
				setInflatedId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInflatedId15213;
		public int getInflatedId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewStub.staticClass, "getInflatedId", "()I", ref global::android.view.ViewStub._getInflatedId15213);
		}
		internal static global::MonoJavaBridge.MethodId _setInflatedId15214;
		public void setInflatedId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setInflatedId", "(I)V", ref global::android.view.ViewStub._setInflatedId15214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnInflateListener15215;
		public void setOnInflateListener(android.view.ViewStub.OnInflateListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V", ref global::android.view.ViewStub._setOnInflateListener15215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnInflateListener(global::android.view.ViewStub.OnInflateListenerDelegate arg0)
		{
			setOnInflateListener((global::android.view.ViewStub.OnInflateListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15216;
		public ViewStub(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._ViewStub15216.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._ViewStub15216 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15217;
		public ViewStub(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._ViewStub15217.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._ViewStub15217 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15218;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._ViewStub15218.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._ViewStub15218 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15219;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._ViewStub15219.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._ViewStub15219 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ViewStub()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewStub.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub"));
		}
		internal static void InitJNI()
		{
		}
	}
}