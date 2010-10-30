namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class QwertyKeyListener : android.text.method.BaseKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected QwertyKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13365;
		public static global::android.text.method.QwertyKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.QwertyKeyListener._getInstance13365.native == global::System.IntPtr.Zero)
				global::android.text.method.QwertyKeyListener._getInstance13365 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.QwertyKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/QwertyKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._getInstance13365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.QwertyKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13366;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.QwertyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.QwertyKeyListener._onKeyDown13366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13367;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.QwertyKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.QwertyKeyListener._getInputType13367);
		}
		internal static global::MonoJavaBridge.MethodId _markAsReplaced13368;
		public static void markAsReplaced(android.text.Spannable arg0, int arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.QwertyKeyListener._markAsReplaced13368.native == global::System.IntPtr.Zero)
				global::android.text.method.QwertyKeyListener._markAsReplaced13368 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.QwertyKeyListener.staticClass, "markAsReplaced", "(Landroid/text/Spannable;IILjava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._markAsReplaced13368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _QwertyKeyListener13369;
		public QwertyKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.QwertyKeyListener._QwertyKeyListener13369.native == global::System.IntPtr.Zero)
				global::android.text.method.QwertyKeyListener._QwertyKeyListener13369 = @__env.GetMethodIDNoThrow(global::android.text.method.QwertyKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._QwertyKeyListener13369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static QwertyKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.QwertyKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/QwertyKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}