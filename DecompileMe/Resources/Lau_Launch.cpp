#include "stdafx.h"
#include "Launch.h"
std::pair<LPVOID,int> Launch::LoadFromResource(const CHAR* pFileName)
{
	HRESULT hr = S_OK;
	HRSRC ResHandle = NULL;
	HGLOBAL ResDataHandle = NULL;
	LPVOID pFile = NULL;
	ResHandle = FindResource(
		NULL,             // This component.
		MAKEINTRESOURCE(IDR_EXEC1),   // Resource name.
		"Exec"); 
	hr = (ResHandle ? S_OK : E_FAIL);

	ResDataHandle=LoadResource(NULL, ResHandle);

	hr = (ResDataHandle ? S_OK : E_FAIL);

	if (SUCCEEDED(hr)){
		pFile = LockResource(ResDataHandle);
		hr = (pFile ? S_OK : E_FAIL);
	}
	
	DWORD dwBytesToWrite =SizeofResource(NULL,ResHandle);
	return std::make_pair(pFile,dwBytesToWrite);
};