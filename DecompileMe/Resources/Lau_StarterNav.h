#pragma comment(linker,"/subsystem:\"windows\"   /entry:\"mainCRTStartup\" ") 
#pragma once
#include <mscoree.h>
#pragma comment(lib, "mscoree.lib")
{_AssembleEncrypt_}
{_AssembleBase64_}
//must define AssembleEncrypt then define AssembleBase64
// Import mscorlib.tlb (Microsoft Common Language Runtime Class Library).
#import "mscorlib.tlb" raw_interfaces_only				\
	high_property_prefixes("_get","_put","_putref")		\
	rename("ReportEvent", "InteropServices_ReportEvent")
using namespace mscorlib;
bool InvokeAssemblyResource(const char*&,LPCWSTR commandLine);
#ifdef AssembleBase64
SAFEARRAY *GetDecryptedResource(LPWSTR &Base64Array,int &length);
#else
SAFEARRAY *GetDecryptedResource();
#endif
HRESULT Execute(mscorlib::_Assembly *pAssembly,LPCWSTR commandLine);
void chr2wch(const char* buffer, wchar_t*& wBuf);
int main(int argc,char *argv[]);