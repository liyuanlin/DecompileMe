#pragma comment(lib, "EncriptLib2.lib")
#include <windows.h>

	class  Encrypt
	{
	public :
	 static __declspec(dllexport) PBYTE  WINAPI  encrypt (BYTE key[8],const PBYTE data,int &length);
    
	 static __declspec(dllexport) PBYTE  WINAPI  decrypt (BYTE key[8],const PBYTE data,int &length);

	 static __declspec(dllexport) LPWSTR  WINAPI  ToBase64(const PBYTE data,int length);

	 static __declspec(dllexport) PBYTE  WINAPI  FromBase64(const char* data,int &length);
	};