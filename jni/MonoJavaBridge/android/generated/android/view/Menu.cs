namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.Menu_))]
	public interface Menu  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.view.MenuItem add(int arg0);
		global::android.view.MenuItem add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3);
		global::android.view.MenuItem add(int arg0, int arg1, int arg2, int arg3);
		global::android.view.MenuItem add(java.lang.CharSequence arg0);
		void clear();
		int size();
		void close();
		bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		global::android.view.SubMenu addSubMenu(java.lang.CharSequence arg0);
		global::android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3);
		global::android.view.SubMenu addSubMenu(int arg0);
		global::android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, int arg3);
		int addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7);
		void removeItem(int arg0);
		void removeGroup(int arg0);
		void setGroupCheckable(int arg0, bool arg1, bool arg2);
		void setGroupVisible(int arg0, bool arg1);
		void setGroupEnabled(int arg0, bool arg1);
		bool hasVisibleItems();
		global::android.view.MenuItem findItem(int arg0);
		global::android.view.MenuItem getItem(int arg0);
		bool performShortcut(int arg0, android.view.KeyEvent arg1, int arg2);
		bool performIdentifierAction(int arg0, int arg1);
		void setQwertyMode(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Menu))]
	public sealed partial class Menu_ : java.lang.Object, Menu
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Menu_()
		{
			InitJNI();
		}
		internal Menu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add8860;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add8860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add8860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add8861;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add8861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add8861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add8862;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add8862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add8862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add8863;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add8863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add8863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear8864;
		 void android.view.Menu.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._clear8864);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._clear8864);
		}
		internal static global::MonoJavaBridge.MethodId _size8865;
		 int android.view.Menu.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Menu_._size8865);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._size8865);
		}
		internal static global::MonoJavaBridge.MethodId _close8866;
		 void android.view.Menu.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._close8866);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._close8866);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey8867;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._isShortcutKey8867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._isShortcutKey8867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8868;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu8868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu8868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8869;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu8869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu8869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8870;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu8870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu8870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8871;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu8871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu8871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions8872;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Menu_._addIntentOptions8872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addIntentOptions8872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem8873;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._removeItem8873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._removeItem8873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup8874;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._removeGroup8874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._removeGroup8874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable8875;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setGroupCheckable8875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setGroupCheckable8875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible8876;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setGroupVisible8876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setGroupVisible8876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled8877;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setGroupEnabled8877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setGroupEnabled8877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems8878;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._hasVisibleItems8878);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._hasVisibleItems8878);
		}
		internal static global::MonoJavaBridge.MethodId _findItem8879;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._findItem8879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._findItem8879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem8880;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._getItem8880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._getItem8880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut8881;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._performShortcut8881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._performShortcut8881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction8882;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._performIdentifierAction8882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._performIdentifierAction8882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode8883;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setQwertyMode8883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setQwertyMode8883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Menu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Menu"));
			global::android.view.Menu_._add8860 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.Menu_._add8861 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.Menu_._add8862 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.Menu_._add8863 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.Menu_._clear8864 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "clear", "()V");
			global::android.view.Menu_._size8865 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "size", "()I");
			global::android.view.Menu_._close8866 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "close", "()V");
			global::android.view.Menu_._isShortcutKey8867 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.Menu_._addSubMenu8868 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.Menu_._addSubMenu8869 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.Menu_._addSubMenu8870 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.Menu_._addSubMenu8871 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.Menu_._addIntentOptions8872 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.Menu_._removeItem8873 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "removeItem", "(I)V");
			global::android.view.Menu_._removeGroup8874 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "removeGroup", "(I)V");
			global::android.view.Menu_._setGroupCheckable8875 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.Menu_._setGroupVisible8876 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.Menu_._setGroupEnabled8877 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.Menu_._hasVisibleItems8878 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.Menu_._findItem8879 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.Menu_._getItem8880 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.Menu_._performShortcut8881 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.Menu_._performIdentifierAction8882 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.Menu_._setQwertyMode8883 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
