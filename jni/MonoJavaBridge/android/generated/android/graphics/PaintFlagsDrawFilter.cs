namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PaintFlagsDrawFilter : android.graphics.DrawFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PaintFlagsDrawFilter()
		{
			InitJNI();
		}
		protected PaintFlagsDrawFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PaintFlagsDrawFilter3534;
		public PaintFlagsDrawFilter(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PaintFlagsDrawFilter.staticClass, global::android.graphics.PaintFlagsDrawFilter._PaintFlagsDrawFilter3534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PaintFlagsDrawFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PaintFlagsDrawFilter"));
			global::android.graphics.PaintFlagsDrawFilter._PaintFlagsDrawFilter3534 = @__env.GetMethodIDNoThrow(global::android.graphics.PaintFlagsDrawFilter.staticClass, "<init>", "(II)V");
		}
	}
}
