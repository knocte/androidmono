namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteFullException : android.database.sqlite.SQLiteException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteFullException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteFullException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteFullException(@__env); 
			} 
		} 
		protected SQLiteFullException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteFullException2328; 
		public SQLiteFullException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteFullException.staticClass, _SQLiteFullException2328, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteFullException2329; 
		public SQLiteFullException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteFullException.staticClass, _SQLiteFullException2329, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteFullException.staticClass = @__class; 
			global::android.database.sqlite.SQLiteFullException._SQLiteFullException2328 = @__env.GetMethodID(global::android.database.sqlite.SQLiteFullException.staticClass, "<init>", "()V"); 
			global::android.database.sqlite.SQLiteFullException._SQLiteFullException2329 = @__env.GetMethodID(global::android.database.sqlite.SQLiteFullException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 