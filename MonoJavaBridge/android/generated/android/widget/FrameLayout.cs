namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FrameLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FrameLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17091;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._LayoutParams17091.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._LayoutParams17091 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams17091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17092;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._LayoutParams17092.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._LayoutParams17092 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams17092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17093;
			public LayoutParams(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._LayoutParams17093.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._LayoutParams17093 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(III)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams17093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17094;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._LayoutParams17094.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._LayoutParams17094 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams17094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17095;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._LayoutParams17095.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._LayoutParams17095 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams17095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _gravity17096;
			public int gravity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gravity17096);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.FrameLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout$LayoutParams"));
				global::android.widget.FrameLayout.LayoutParams._gravity17096 = @__env.GetFieldIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "gravity", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _setForeground17097;
		public virtual void setForeground(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "setForeground", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.FrameLayout._setForeground17097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw17098;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.FrameLayout._draw17098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17099;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.FrameLayout._onSizeChanged17099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17100;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.FrameLayout._onLayout17100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable17101;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.FrameLayout._verifyDrawable17101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged17102;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "drawableStateChanged", "()V", ref global::android.widget.FrameLayout._drawableStateChanged17102);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17103;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "onMeasure", "(II)V", ref global::android.widget.FrameLayout._onMeasure17103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17104;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.FrameLayout._checkLayoutParams17104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17105;
		public virtual global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", ref global::android.widget.FrameLayout._generateLayoutParams17105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17106;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.FrameLayout._generateLayoutParams17106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17107;
		protected virtual global::android.widget.FrameLayout.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;", ref global::android.widget.FrameLayout._generateDefaultLayoutParams17107) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion17108;
		public override bool gatherTransparentRegion(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z", ref global::android.widget.FrameLayout._gatherTransparentRegion17108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ForegroundGravity
		{
			set
			{
				setForegroundGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setForegroundGravity17109;
		public virtual void setForegroundGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "setForegroundGravity", "(I)V", ref global::android.widget.FrameLayout._setForegroundGravity17109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Foreground
		{
			get
			{
				return getForeground();
			}
			set
			{
				setForeground(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getForeground17110;
		public virtual global::android.graphics.drawable.Drawable getForeground()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "getForeground", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.FrameLayout._getForeground17110) as android.graphics.drawable.Drawable;
		}
		public new bool MeasureAllChildren
		{
			set
			{
				setMeasureAllChildren(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMeasureAllChildren17111;
		public virtual void setMeasureAllChildren(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "setMeasureAllChildren", "(Z)V", ref global::android.widget.FrameLayout._setMeasureAllChildren17111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ConsiderGoneChildrenWhenMeasuring
		{
			get
			{
				return getConsiderGoneChildrenWhenMeasuring();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConsiderGoneChildrenWhenMeasuring17112;
		public virtual bool getConsiderGoneChildrenWhenMeasuring()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "getConsiderGoneChildrenWhenMeasuring", "()Z", ref global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring17112);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout17113;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.FrameLayout._FrameLayout17113.native == global::System.IntPtr.Zero)
				global::android.widget.FrameLayout._FrameLayout17113 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout17113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout17114;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.FrameLayout._FrameLayout17114.native == global::System.IntPtr.Zero)
				global::android.widget.FrameLayout._FrameLayout17114 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout17114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout17115;
		public FrameLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.FrameLayout._FrameLayout17115.native == global::System.IntPtr.Zero)
				global::android.widget.FrameLayout._FrameLayout17115 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout17115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FrameLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FrameLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout"));
		}
		internal static void InitJNI()
		{
		}
	}
}