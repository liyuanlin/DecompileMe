﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DecompileMe.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DecompileMe.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] EncriptLib2dll {
            get {
                object obj = ResourceManager.GetObject("EncriptLib2dll", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] EncriptLib2lib {
            get {
                object obj = ResourceManager.GetObject("EncriptLib2lib", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma comment(lib, &quot;EncriptLib2.lib&quot;)
        ///#include &lt;windows.h&gt;
        ///
        ///	class  Encrypt
        ///	{
        ///	public :
        ///	 static __declspec(dllexport) PBYTE  WINAPI  encrypt (BYTE key[8],const PBYTE data,int &amp;length);
        ///    
        ///	 static __declspec(dllexport) PBYTE  WINAPI  decrypt (BYTE key[8],const PBYTE data,int &amp;length);
        ///
        ///	 static __declspec(dllexport) LPWSTR  WINAPI  ToBase64(const PBYTE data,int length);
        ///
        ///	 static __declspec(dllexport) PBYTE  WINAPI  FromBase64(const char* data,int &amp;length);
        ///	};.
        /// </summary>
        internal static string EncryptExh {
            get {
                return ResourceManager.GetString("EncryptExh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &quot;stdafx.h&quot;
        ///#include &quot;Launch.h&quot;
        ///std::pair&lt;LPVOID,int&gt; Launch::LoadFromResource(const CHAR* pFileName)
        ///{
        ///	HRESULT hr = S_OK;
        ///	HRSRC ResHandle = NULL;
        ///	HGLOBAL ResDataHandle = NULL;
        ///	LPVOID pFile = NULL;
        ///	ResHandle = FindResource(
        ///		NULL,             // This component.
        ///		MAKEINTRESOURCE(IDR_EXEC1),   // Resource name.
        ///		&quot;Exec&quot;); 
        ///	hr = (ResHandle ? S_OK : E_FAIL);
        ///
        ///	ResDataHandle=LoadResource(NULL, ResHandle);
        ///
        ///	hr = (ResDataHandle ? S_OK : E_FAIL);
        ///
        ///	if (SUCCEEDED(hr)){
        ///		pFile = L [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Lau_Launchcpp {
            get {
                return ResourceManager.GetString("Lau_Launchcpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma once
        /////#pragma   comment(linker,&quot;/subsystem:\&quot;windows\&quot;   /entry:\&quot;mainCRTStartup\&quot; &quot;) 
        ///#include &quot;stdafx.h&quot;
        ///
        ///class Launch
        ///{
        ///public:
        ///	static std::pair&lt;LPVOID,int&gt; LoadFromResource(const CHAR*);
        ///	
        ///	//static STDMETHOD(QueryInterface)( REFIID riid, void **ppInterface );        
        ///};
        ///
        ///
        ///
        ///.
        /// </summary>
        internal static string Lau_Launchh {
            get {
                return ResourceManager.GetString("Lau_Launchh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //{{NO_DEPENDENCIES}}
        ///// Microsoft Visual C++ generated include file.
        ///// Used by CLauncher.rc
        /////
        ///#define IDI_ICON1                       101
        ///#define IDR_EXEC1                       103
        ///// Next default values for new objects
        ///// 
        ///#ifdef APSTUDIO_INVOKED
        ///#ifndef APSTUDIO_READONLY_SYMBOLS
        ///#define _APS_NEXT_RESOURCE_VALUE        104
        ///#define _APS_NEXT_COMMAND_VALUE         40001
        ///#define _APS_NEXT_CONTROL_VALUE         1001
        ///#define _APS_NEXT_SYMED_VALUE           101
        ///#endif
        ///#endif
        ///.
        /// </summary>
        internal static string Lau_resourceh {
            get {
                return ResourceManager.GetString("Lau_resourceh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &quot;stdafx.h&quot;
        ///#include &quot;Starter.h&quot;
        ///#include &lt;mscoree.h&gt;
        ///#include &lt;atlbase.h&gt;
        ///#include &lt;comdef.h&gt;
        ///#include &lt;windows.h&gt;
        ///#include &lt;iostream&gt;
        ///#include &lt;fstream&gt;
        ///#include &quot;Launch.h&quot;
        ///#ifdef AssembleEncrypt
        ///#include &quot;EncryptEx.h&quot;
        ///#endif
        ///using namespace std;
        ///
        ///bool InvokeAssemblyResource(const TCHAR *&amp;gErrMsg,LPCWSTR commandLine)
        ///{  
        ///	CComPtr&lt;ICorRuntimeHost&gt; spRuntimeHost;
        ///	CComPtr&lt;_AppDomain&gt; spAppDomain;
        ///	CComPtr&lt;IUnknown&gt; spUnk;
        ///	bool bSuccess = false;
        ///
        ///	if(FAILED(CorBindToRuntimeEx(L&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Lau_StarterNavcpp {
            get {
                return ResourceManager.GetString("Lau_StarterNavcpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma comment(linker,&quot;/subsystem:\&quot;windows\&quot;   /entry:\&quot;mainCRTStartup\&quot; &quot;) 
        ///#pragma once
        ///#include &lt;mscoree.h&gt;
        ///#pragma comment(lib, &quot;mscoree.lib&quot;)
        ///{_AssembleEncrypt_}
        ///{_AssembleBase64_}
        /////must define AssembleEncrypt then define AssembleBase64
        ///// Import mscorlib.tlb (Microsoft Common Language Runtime Class Library).
        ///#import &quot;mscorlib.tlb&quot; raw_interfaces_only				\
        ///	high_property_prefixes(&quot;_get&quot;,&quot;_put&quot;,&quot;_putref&quot;)		\
        ///	rename(&quot;ReportEvent&quot;, &quot;InteropServices_ReportEvent&quot;)
        ///using namespace mscorlib;
        ///b [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Lau_StarterNavh {
            get {
                return ResourceManager.GetString("Lau_StarterNavh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Microsoft Visual C++ generated resource script.
        /////
        ///#include &quot;resource.h&quot;
        ///
        ///#define APSTUDIO_READONLY_SYMBOLS
        ////////////////////////////////////////////////////////////////////////////////
        /////
        ///// Generated from the TEXTINCLUDE 2 resource.
        /////
        ///#include &quot;afxres.h&quot;
        ///
        ////////////////////////////////////////////////////////////////////////////////
        ///#undef APSTUDIO_READONLY_SYMBOLS
        ///
        ////////////////////////////////////////////////////////////////////////////////
        ///// Chinese (Simplified, PRC) resources
        ///
        ///#if [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Lau_Starterrc {
            get {
                return ResourceManager.GetString("Lau_Starterrc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // stdafx.cpp : source file that includes just the standard includes
        ///// ttest.pch will be the pre-compiled header
        ///// stdafx.obj will contain the pre-compiled type information
        ///
        ///#include &quot;stdafx.h&quot;
        ///
        ///
        ///.
        /// </summary>
        internal static string Lau_stdafxcpp {
            get {
                return ResourceManager.GetString("Lau_stdafxcpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // stdafx.h : include file for standard system include files,
        ///// or project specific include files that are used frequently, but
        ///// are changed infrequently
        ///#pragma once
        ///#include &lt;windows.h&gt;
        ///#include  &lt;io.h&gt;
        ///#include &lt;string&gt;
        ///#include &lt;assert.h&gt;
        ///#include &quot;resource.h&quot;
        ///// TODO: reference additional headers your program requires here.
        /// </summary>
        internal static string Lau_stdafxh {
            get {
                return ResourceManager.GetString("Lau_stdafxh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Obfuscate {
            get {
                object obj = ResourceManager.GetObject("Obfuscate", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}