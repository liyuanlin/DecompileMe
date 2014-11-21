#include "stdafx.h"
#include "Starter.h"
#include <mscoree.h>
#include <atlbase.h>
#include <comdef.h>
#include <windows.h>
#include <iostream>
#include <fstream>
#include "Launch.h"
#ifdef AssembleEncrypt
#include "EncryptEx.h"
#endif
using namespace std;

bool InvokeAssemblyResource(const TCHAR *&gErrMsg,LPCWSTR commandLine)
{  
	CComPtr<ICorRuntimeHost> spRuntimeHost;
	CComPtr<_AppDomain> spAppDomain;
	CComPtr<IUnknown> spUnk;
	bool bSuccess = false;

	if(FAILED(CorBindToRuntimeEx(L"v2.0.50727", // Latest Version by Default
		L"wks",  // Workstation build
		STARTUP_LOADER_OPTIMIZATION_SINGLE_DOMAIN,
		CLSID_CorRuntimeHost ,
		IID_ICorRuntimeHost ,
		(void**)&spRuntimeHost)))
	{
		gErrMsg = _T("Unable to Bind CLR");
		return false;
	}
	HRESULT hr = S_OK;
	hr=spRuntimeHost->Start();
	if(FAILED(hr))
	{
		gErrMsg = _T("Unable to Start CLR");
		return false;
	}
	do
	{

		if(FAILED(spRuntimeHost->GetDefaultDomain(&spUnk)))
		{
			gErrMsg = _T("Unable to GetDefaultDomain");
			break;
		}
		if(FAILED(spUnk->QueryInterface(&spAppDomain.p)))
		{
			gErrMsg = _T("Unable to Query AppDomain Interface");
			break;
		}
		LPWSTR Base64Array=0;
		
#ifdef AssembleEncrypt		
#ifdef AssembleBase64
		int barraylen=0;
		WCHAR* Final=NULL;	
		SAFEARRAY *pSA = GetDecryptedResource(Base64Array,barraylen);
		barraylen=wcslen(Base64Array);
		int oLen=wcslen(commandLine);
		Final=new WCHAR[oLen+barraylen+36+1];		
		ZeroMemory(Final,(oLen+barraylen+36+1)*2);
		CopyMemory(Final,L"360C8977-B859-4394-8A94-2C6A8110DC25",72);
		CopyMemory(Final+36,Base64Array,barraylen*2);//36
		if(oLen>0)
		{
			CopyMemory(Final+36+barraylen,L" ",1);//减去一个结尾 
			CopyMemory(Final+37+barraylen,commandLine,(oLen+1)*2);//
		}
#else
		LPCWSTR Final=commandLine;
		SAFEARRAY *pSA = GetDecryptedResource();
#endif		
#else
		LPCWSTR Final=commandLine;
		SAFEARRAY *pSA = GetDecryptedResource();
#endif
		if(pSA)
		{
			try
			{  
				_Assembly *ass=NULL;
				_Type *typ=NULL;
				spAppDomain->Load_3(pSA,&ass);
				HRESULT hr=Execute(ass,Final);
				if(FAILED(hr)){
					gErrMsg = _T("Execute EntryPoint Error");
					bSuccess=false;
				}
			}
			catch(_com_error ex)
			{
				gErrMsg = ex.ErrorMessage();
			}

			SafeArrayDestroy(pSA);
			pSA = NULL; 
		}
	}while(false);

	if(FAILED(spRuntimeHost->Stop()))
	{
		gErrMsg = _T("Unable to Stop CLR");
		return false;
	}

	return bSuccess;

}
#ifdef AssembleBase64
SAFEARRAY *GetDecryptedResource(LPWSTR &Base64Array,int &length)
#else
SAFEARRAY *GetDecryptedResource()
#endif
{
	std::pair<LPVOID,int> DataP= Launch::LoadFromResource("{_MAINEXENAME_}");
	int size=DataP.second;	
#ifdef AssembleEncrypt
	BYTE Key[8]={234,123,212,13,4,125,86,97};
	PBYTE buffer=Encrypt::decrypt(Key,(PBYTE)DataP.first,size);
#ifdef AssembleBase64
	length=size;
	Base64Array=Encrypt::ToBase64(buffer,length);
#endif
#else
	PBYTE buffer=(PBYTE)DataP.first;
#endif
	SAFEARRAY *rev = SafeArrayCreateVector(VT_UI1, 0, size);
	LONG index = 0;
	while(index<size){
		SafeArrayPutElement(rev, &index, buffer);
		index++;
		buffer++;
	}
	return rev;
}


HRESULT Execute(mscorlib::_Assembly *pAssembly,LPCWSTR commandLine)
{
	HRESULT hr = S_OK;
	int argc;
	LPWSTR *argv = CommandLineToArgvW(commandLine, &argc);

	_MethodInfo *entry=NULL;
	hr = pAssembly->get_EntryPoint(&entry);
	if (SUCCEEDED(hr))
	{
		long idx[1];
		VARIANT obj, retVal, args;
		obj.vt = VT_NULL;
		args.vt = VT_ARRAY | VT_BSTR;
		if(commandLine!=L"")//函数有参数,调用也提供参数
		{
			SAFEARRAYBOUND argsBound[1];
			argsBound[0].lLbound = 0;
			argsBound[0].cElements = argc;
			args.parray = SafeArrayCreate(VT_BSTR, 1, argsBound);
			assert(args.parray);
			for (int i = 0; i < argc; i++)
			{
				idx[0] = i;
				SafeArrayPutElement(args.parray, idx, SysAllocString(argv[i]));
			}

		}
		else//函数有参数, 但是调用不提供参数
		{

			SAFEARRAYBOUND nargsBound[1];
			nargsBound[0].lLbound = 0;
			nargsBound[0].cElements = 0;
			args.parray=SafeArrayCreate(VT_BSTR, 1, nargsBound);
		}
		SAFEARRAY *params = NULL;
		hr=entry->GetParameters(&params);
		if(FAILED(hr))return hr;

		if(params->rgsabound->cElements!=0)//含有多个参数
		{
			params = SafeArrayCreate(VT_VARIANT, params->rgsabound->cElements, params->rgsabound);
			idx[0] = 0;
			SafeArrayPutElement(params, idx, &args);
		}
		else//函数不含有 参数
		{
			params = SafeArrayCreate(VT_VARIANT, params->rgsabound->cElements, params->rgsabound);
		}
		hr = entry->Invoke_3(obj, params, &retVal);
	}

	return hr;
}

void chr2wch(const char* buffer, wchar_t*& wBuf)
{
	size_t len = strlen(buffer);
	size_t wlen = 2*len+1;
	wBuf = new wchar_t[wlen];
	mbstowcs(wBuf,buffer,wlen);
	wBuf[wlen]='\0';
}

int main(int argc,char *argv[])
{
	HRESULT	hr = CoInitializeEx(NULL, COINIT_APARTMENTTHREADED);
	const TCHAR *gErrMsg="";
	wstring Parameters;
	for(int i=1;i<argc;i++)
	{
		Parameters.append(L" ");
		wchar_t *pwstrPValue=NULL;
		chr2wch(argv[i],pwstrPValue);
		Parameters.append(pwstrPValue);
	}
	InvokeAssemblyResource(gErrMsg,Parameters.c_str());
	return 0;

}
