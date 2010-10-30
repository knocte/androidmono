namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedList : java.util.AbstractSequentialList, List, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkedList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26348;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._add26348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26349;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.LinkedList._add26349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get26350;
		public override global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.LinkedList._get26350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clone26351;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.LinkedList._clone26351) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf26352;
		public override int indexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.LinkedList.staticClass, "indexOf", "(Ljava/lang/Object;)I", ref global::java.util.LinkedList._indexOf26352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear26353;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "clear", "()V", ref global::java.util.LinkedList._clear26353);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf26354;
		public override int lastIndexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.LinkedList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I", ref global::java.util.LinkedList._lastIndexOf26354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains26355;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._contains26355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26356;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.LinkedList._addAll26356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26357;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.LinkedList._addAll26357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size26358;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.LinkedList.staticClass, "size", "()I", ref global::java.util.LinkedList._size26358);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26359;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.LinkedList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.LinkedList._toArray26359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26360;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.LinkedList.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.LinkedList._toArray26360) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _push26361;
		public virtual void push(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "push", "(Ljava/lang/Object;)V", ref global::java.util.LinkedList._push26361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pop26362;
		public virtual global::java.lang.Object pop()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "pop", "()Ljava/lang/Object;", ref global::java.util.LinkedList._pop26362) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26363;
		public override global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.LinkedList._remove26363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26364;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._remove26364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26365;
		public virtual global::java.lang.Object remove()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "remove", "()Ljava/lang/Object;", ref global::java.util.LinkedList._remove26365) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set26366;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.LinkedList._set26366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator26367;
		public override global::java.util.ListIterator listIterator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.LinkedList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;", ref global::java.util.LinkedList._listIterator26367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _poll26368;
		public virtual global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.LinkedList._poll26368) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26369;
		public virtual global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.LinkedList._peek26369) as java.lang.Object;
		}
		public new global::java.lang.Object First
		{
			get
			{
				return getFirst();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFirst26370;
		public virtual global::java.lang.Object getFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "getFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._getFirst26370) as java.lang.Object;
		}
		public new global::java.lang.Object Last
		{
			get
			{
				return getLast();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLast26371;
		public virtual global::java.lang.Object getLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "getLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._getLast26371) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirst26372;
		public virtual global::java.lang.Object removeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "removeFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._removeFirst26372) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeLast26373;
		public virtual global::java.lang.Object removeLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "removeLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._removeLast26373) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _addFirst26374;
		public virtual void addFirst(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "addFirst", "(Ljava/lang/Object;)V", ref global::java.util.LinkedList._addFirst26374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addLast26375;
		public virtual void addLast(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "addLast", "(Ljava/lang/Object;)V", ref global::java.util.LinkedList._addLast26375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _element26376;
		public virtual global::java.lang.Object element()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "element", "()Ljava/lang/Object;", ref global::java.util.LinkedList._element26376) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26377;
		public virtual bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._offer26377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerFirst26378;
		public virtual bool offerFirst(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "offerFirst", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._offerFirst26378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerLast26379;
		public virtual bool offerLast(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "offerLast", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._offerLast26379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekFirst26380;
		public virtual global::java.lang.Object peekFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "peekFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._peekFirst26380) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peekLast26381;
		public virtual global::java.lang.Object peekLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "peekLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._peekLast26381) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirst26382;
		public virtual global::java.lang.Object pollFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "pollFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._pollFirst26382) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollLast26383;
		public virtual global::java.lang.Object pollLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "pollLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._pollLast26383) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirstOccurrence26384;
		public virtual bool removeFirstOccurrence(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "removeFirstOccurrence", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._removeFirstOccurrence26384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeLastOccurrence26385;
		public virtual bool removeLastOccurrence(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "removeLastOccurrence", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._removeLastOccurrence26385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _descendingIterator26386;
		public virtual global::java.util.Iterator descendingIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.LinkedList.staticClass, "descendingIterator", "()Ljava/util/Iterator;", ref global::java.util.LinkedList._descendingIterator26386) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList26387;
		public LinkedList(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedList._LinkedList26387.native == global::System.IntPtr.Zero)
				global::java.util.LinkedList._LinkedList26387 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList26387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList26388;
		public LinkedList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedList._LinkedList26388.native == global::System.IntPtr.Zero)
				global::java.util.LinkedList._LinkedList26388 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList26388);
			Init(@__env, handle);
		}
		static LinkedList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedList"));
		}
		internal static void InitJNI()
		{
		}
	}
}