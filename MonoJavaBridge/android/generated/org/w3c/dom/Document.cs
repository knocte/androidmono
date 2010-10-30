namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Document_))]
	public partial interface Document : Node
	{
		global::org.w3c.dom.DocumentType getDoctype();
		global::org.w3c.dom.DOMImplementation getImplementation();
		global::java.lang.String getInputEncoding();
		global::org.w3c.dom.Element getDocumentElement();
		global::org.w3c.dom.Element createElement(java.lang.String arg0);
		global::org.w3c.dom.DocumentFragment createDocumentFragment();
		global::org.w3c.dom.Text createTextNode(java.lang.String arg0);
		global::org.w3c.dom.Comment createComment(java.lang.String arg0);
		global::org.w3c.dom.CDATASection createCDATASection(java.lang.String arg0);
		global::org.w3c.dom.ProcessingInstruction createProcessingInstruction(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr createAttribute(java.lang.String arg0);
		global::org.w3c.dom.EntityReference createEntityReference(java.lang.String arg0);
		global::org.w3c.dom.NodeList getElementsByTagName(java.lang.String arg0);
		global::org.w3c.dom.Node importNode(org.w3c.dom.Node arg0, bool arg1);
		global::org.w3c.dom.Element createElementNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr createAttributeNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.NodeList getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Element getElementById(java.lang.String arg0);
		global::java.lang.String getXmlEncoding();
		bool getXmlStandalone();
		void setXmlStandalone(bool arg0);
		global::java.lang.String getXmlVersion();
		void setXmlVersion(java.lang.String arg0);
		bool getStrictErrorChecking();
		void setStrictErrorChecking(bool arg0);
		global::java.lang.String getDocumentURI();
		void setDocumentURI(java.lang.String arg0);
		global::org.w3c.dom.Node adoptNode(org.w3c.dom.Node arg0);
		global::org.w3c.dom.DOMConfiguration getDomConfig();
		void normalizeDocument();
		global::org.w3c.dom.Node renameNode(org.w3c.dom.Node arg0, java.lang.String arg1, java.lang.String arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Document))]
	internal sealed partial class Document_ : java.lang.Object, Document
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Document_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDoctype34386;
		global::org.w3c.dom.DocumentType org.w3c.dom.Document.getDoctype()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DocumentType>(this, global::org.w3c.dom.Document_.staticClass, "getDoctype", "()Lorg/w3c/dom/DocumentType;", ref global::org.w3c.dom.Document_._getDoctype34386) as org.w3c.dom.DocumentType;
		}
		internal static global::MonoJavaBridge.MethodId _getImplementation34387;
		global::org.w3c.dom.DOMImplementation org.w3c.dom.Document.getImplementation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMImplementation>(this, global::org.w3c.dom.Document_.staticClass, "getImplementation", "()Lorg/w3c/dom/DOMImplementation;", ref global::org.w3c.dom.Document_._getImplementation34387) as org.w3c.dom.DOMImplementation;
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding34388;
		global::java.lang.String org.w3c.dom.Document.getInputEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getInputEncoding", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getInputEncoding34388) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDocumentElement34389;
		global::org.w3c.dom.Element org.w3c.dom.Document.getDocumentElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "getDocumentElement", "()Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._getDocumentElement34389) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createElement34390;
		global::org.w3c.dom.Element org.w3c.dom.Document.createElement(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "createElement", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._createElement34390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createDocumentFragment34391;
		global::org.w3c.dom.DocumentFragment org.w3c.dom.Document.createDocumentFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DocumentFragment>(this, global::org.w3c.dom.Document_.staticClass, "createDocumentFragment", "()Lorg/w3c/dom/DocumentFragment;", ref global::org.w3c.dom.Document_._createDocumentFragment34391) as org.w3c.dom.DocumentFragment;
		}
		internal static global::MonoJavaBridge.MethodId _createTextNode34392;
		global::org.w3c.dom.Text org.w3c.dom.Document.createTextNode(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Text>(this, global::org.w3c.dom.Document_.staticClass, "createTextNode", "(Ljava/lang/String;)Lorg/w3c/dom/Text;", ref global::org.w3c.dom.Document_._createTextNode34392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _createComment34393;
		global::org.w3c.dom.Comment org.w3c.dom.Document.createComment(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Comment>(this, global::org.w3c.dom.Document_.staticClass, "createComment", "(Ljava/lang/String;)Lorg/w3c/dom/Comment;", ref global::org.w3c.dom.Document_._createComment34393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Comment;
		}
		internal static global::MonoJavaBridge.MethodId _createCDATASection34394;
		global::org.w3c.dom.CDATASection org.w3c.dom.Document.createCDATASection(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.CDATASection>(this, global::org.w3c.dom.Document_.staticClass, "createCDATASection", "(Ljava/lang/String;)Lorg/w3c/dom/CDATASection;", ref global::org.w3c.dom.Document_._createCDATASection34394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.CDATASection;
		}
		internal static global::MonoJavaBridge.MethodId _createProcessingInstruction34395;
		global::org.w3c.dom.ProcessingInstruction org.w3c.dom.Document.createProcessingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ProcessingInstruction>(this, global::org.w3c.dom.Document_.staticClass, "createProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ProcessingInstruction;", ref global::org.w3c.dom.Document_._createProcessingInstruction34395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.ProcessingInstruction;
		}
		internal static global::MonoJavaBridge.MethodId _createAttribute34396;
		global::org.w3c.dom.Attr org.w3c.dom.Document.createAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Document_.staticClass, "createAttribute", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Document_._createAttribute34396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _createEntityReference34397;
		global::org.w3c.dom.EntityReference org.w3c.dom.Document.createEntityReference(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.EntityReference>(this, global::org.w3c.dom.Document_.staticClass, "createEntityReference", "(Ljava/lang/String;)Lorg/w3c/dom/EntityReference;", ref global::org.w3c.dom.Document_._createEntityReference34397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.EntityReference;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagName34398;
		global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Document_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Document_._getElementsByTagName34398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _importNode34399;
		global::org.w3c.dom.Node org.w3c.dom.Document.importNode(org.w3c.dom.Node arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "importNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._importNode34399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _createElementNS34400;
		global::org.w3c.dom.Element org.w3c.dom.Document.createElementNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "createElementNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._createElementNS34400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createAttributeNS34401;
		global::org.w3c.dom.Attr org.w3c.dom.Document.createAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Document_.staticClass, "createAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Document_._createAttributeNS34401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagNameNS34402;
		global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Document_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Document_._getElementsByTagNameNS34402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getElementById34403;
		global::org.w3c.dom.Element org.w3c.dom.Document.getElementById(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "getElementById", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._getElementById34403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlEncoding34404;
		global::java.lang.String org.w3c.dom.Document.getXmlEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getXmlEncoding", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getXmlEncoding34404) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlStandalone34405;
		bool org.w3c.dom.Document.getXmlStandalone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "getXmlStandalone", "()Z", ref global::org.w3c.dom.Document_._getXmlStandalone34405);
		}
		internal static global::MonoJavaBridge.MethodId _setXmlStandalone34406;
		void org.w3c.dom.Document.setXmlStandalone(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setXmlStandalone", "(Z)V", ref global::org.w3c.dom.Document_._setXmlStandalone34406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getXmlVersion34407;
		global::java.lang.String org.w3c.dom.Document.getXmlVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getXmlVersion", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getXmlVersion34407) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setXmlVersion34408;
		void org.w3c.dom.Document.setXmlVersion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setXmlVersion", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._setXmlVersion34408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStrictErrorChecking34409;
		bool org.w3c.dom.Document.getStrictErrorChecking()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "getStrictErrorChecking", "()Z", ref global::org.w3c.dom.Document_._getStrictErrorChecking34409);
		}
		internal static global::MonoJavaBridge.MethodId _setStrictErrorChecking34410;
		void org.w3c.dom.Document.setStrictErrorChecking(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setStrictErrorChecking", "(Z)V", ref global::org.w3c.dom.Document_._setStrictErrorChecking34410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDocumentURI34411;
		global::java.lang.String org.w3c.dom.Document.getDocumentURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getDocumentURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getDocumentURI34411) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentURI34412;
		void org.w3c.dom.Document.setDocumentURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setDocumentURI", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._setDocumentURI34412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adoptNode34413;
		global::org.w3c.dom.Node org.w3c.dom.Document.adoptNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "adoptNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._adoptNode34413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig34414;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.Document.getDomConfig()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMConfiguration>(this, global::org.w3c.dom.Document_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", ref global::org.w3c.dom.Document_._getDomConfig34414) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _normalizeDocument34415;
		void org.w3c.dom.Document.normalizeDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "normalizeDocument", "()V", ref global::org.w3c.dom.Document_._normalizeDocument34415);
		}
		internal static global::MonoJavaBridge.MethodId _renameNode34416;
		global::org.w3c.dom.Node org.w3c.dom.Document.renameNode(org.w3c.dom.Node arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "renameNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._renameNode34416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _normalize34417;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "normalize", "()V", ref global::org.w3c.dom.Document_._normalize34417);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34418;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Document_._isSupported34418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34419;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.Document_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.Document_._getAttributes34419) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34420;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getPrefix34420) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34421;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._getFirstChild34421) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34422;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Document_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.Document_._getNodeType34422);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34423;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getNodeName34423) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34424;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getNodeValue34424) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34425;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._getNextSibling34425) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34426;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getLocalName34426) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34427;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.Document_._hasAttributes34427);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34428;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getNamespaceURI34428) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34429;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.Document_._hasChildNodes34429);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34430;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Document_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Document_._getUserData34430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34431;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Document_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.Document_._setUserData34431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34432;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Document_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Document_._getFeature34432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34433;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._setPrefix34433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34434;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._setNodeValue34434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34435;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._getParentNode34435) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34436;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Document_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Document_._getChildNodes34436) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34437;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._getLastChild34437) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34438;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._getPreviousSibling34438) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34439;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.Document_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.Document_._getOwnerDocument34439) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34440;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._insertBefore34440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34441;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._replaceChild34441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34442;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._removeChild34442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34443;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._appendChild34443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34444;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._cloneNode34444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34445;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getBaseURI34445) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34446;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Document_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.Document_._compareDocumentPosition34446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34447;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._getTextContent34447) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34448;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._setTextContent34448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34449;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Document_._isSameNode34449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34450;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Document_._lookupPrefix34450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34451;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Document_._isDefaultNamespace34451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34452;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Document_._lookupNamespaceURI34452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34453;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Document_._isEqualNode34453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Document_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Document_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Document"));
		}
		internal static void InitJNI()
		{
		}
	}
}