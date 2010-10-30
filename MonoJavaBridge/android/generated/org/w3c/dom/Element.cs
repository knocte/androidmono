namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Element_))]
	public partial interface Element : Node
	{
		global::java.lang.String getAttribute(java.lang.String arg0);
		global::java.lang.String getTagName();
		void removeAttribute(java.lang.String arg0);
		void setAttribute(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.NodeList getElementsByTagName(java.lang.String arg0);
		global::org.w3c.dom.NodeList getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.TypeInfo getSchemaTypeInfo();
		global::org.w3c.dom.Attr getAttributeNode(java.lang.String arg0);
		global::org.w3c.dom.Attr setAttributeNode(org.w3c.dom.Attr arg0);
		global::org.w3c.dom.Attr removeAttributeNode(org.w3c.dom.Attr arg0);
		global::java.lang.String getAttributeNS(java.lang.String arg0, java.lang.String arg1);
		void setAttributeNS(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		void removeAttributeNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr getAttributeNodeNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr setAttributeNodeNS(org.w3c.dom.Attr arg0);
		bool hasAttribute(java.lang.String arg0);
		bool hasAttributeNS(java.lang.String arg0, java.lang.String arg1);
		void setIdAttribute(java.lang.String arg0, bool arg1);
		void setIdAttributeNS(java.lang.String arg0, java.lang.String arg1, bool arg2);
		void setIdAttributeNode(org.w3c.dom.Attr arg0, bool arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Element))]
	internal sealed partial class Element_ : java.lang.Object, Element
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Element_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute34534;
		global::java.lang.String org.w3c.dom.Element.getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._getAttribute34534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTagName34535;
		global::java.lang.String org.w3c.dom.Element.getTagName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getTagName", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getTagName34535) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute34536;
		void org.w3c.dom.Element.removeAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "removeAttribute", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._removeAttribute34536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute34537;
		void org.w3c.dom.Element.setAttribute(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._setAttribute34537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagName34538;
		global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Element_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Element_._getElementsByTagName34538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagNameNS34539;
		global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Element_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Element_._getElementsByTagNameNS34539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTypeInfo34540;
		global::org.w3c.dom.TypeInfo org.w3c.dom.Element.getSchemaTypeInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.TypeInfo>(this, global::org.w3c.dom.Element_.staticClass, "getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;", ref global::org.w3c.dom.Element_._getSchemaTypeInfo34540) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNode34541;
		global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNode(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "getAttributeNode", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._getAttributeNode34541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNode34542;
		global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNode(org.w3c.dom.Attr arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "setAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._setAttributeNode34542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttributeNode34543;
		global::org.w3c.dom.Attr org.w3c.dom.Element.removeAttributeNode(org.w3c.dom.Attr arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "removeAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._removeAttributeNode34543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNS34544;
		global::java.lang.String org.w3c.dom.Element.getAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._getAttributeNS34544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNS34545;
		void org.w3c.dom.Element.setAttributeNS(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._setAttributeNS34545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttributeNS34546;
		void org.w3c.dom.Element.removeAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "removeAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._removeAttributeNS34546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNodeNS34547;
		global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNodeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "getAttributeNodeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._getAttributeNodeNS34547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNodeNS34548;
		global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNodeNS(org.w3c.dom.Attr arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "setAttributeNodeNS", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._setAttributeNodeNS34548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttribute34549;
		bool org.w3c.dom.Element.hasAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasAttribute", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._hasAttribute34549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributeNS34550;
		bool org.w3c.dom.Element.hasAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._hasAttributeNS34550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttribute34551;
		void org.w3c.dom.Element.setIdAttribute(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setIdAttribute", "(Ljava/lang/String;Z)V", ref global::org.w3c.dom.Element_._setIdAttribute34551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttributeNS34552;
		void org.w3c.dom.Element.setIdAttributeNS(java.lang.String arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setIdAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Z)V", ref global::org.w3c.dom.Element_._setIdAttributeNS34552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttributeNode34553;
		void org.w3c.dom.Element.setIdAttributeNode(org.w3c.dom.Attr arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setIdAttributeNode", "(Lorg/w3c/dom/Attr;Z)V", ref global::org.w3c.dom.Element_._setIdAttributeNode34553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _normalize34554;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "normalize", "()V", ref global::org.w3c.dom.Element_._normalize34554);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34555;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._isSupported34555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34556;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.Element_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.Element_._getAttributes34556) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34557;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getPrefix34557) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34558;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._getFirstChild34558) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34559;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Element_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.Element_._getNodeType34559);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34560;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getNodeName34560) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34561;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getNodeValue34561) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34562;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._getNextSibling34562) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34563;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getLocalName34563) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34564;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.Element_._hasAttributes34564);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34565;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getNamespaceURI34565) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34566;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.Element_._hasChildNodes34566);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34567;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Element_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Element_._getUserData34567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34568;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Element_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.Element_._setUserData34568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34569;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Element_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Element_._getFeature34569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34570;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._setPrefix34570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34571;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._setNodeValue34571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34572;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._getParentNode34572) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34573;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Element_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Element_._getChildNodes34573) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34574;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._getLastChild34574) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34575;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._getPreviousSibling34575) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34576;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.Element_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.Element_._getOwnerDocument34576) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34577;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._insertBefore34577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34578;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._replaceChild34578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34579;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._removeChild34579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34580;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._appendChild34580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34581;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._cloneNode34581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34582;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getBaseURI34582) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34583;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Element_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.Element_._compareDocumentPosition34583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34584;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._getTextContent34584) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34585;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._setTextContent34585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34586;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Element_._isSameNode34586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34587;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._lookupPrefix34587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34588;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._isDefaultNamespace34588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34589;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._lookupNamespaceURI34589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34590;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Element_._isEqualNode34590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Element_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Element_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Element"));
		}
		internal static void InitJNI()
		{
		}
	}
}