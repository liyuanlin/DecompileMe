#pragma once
//#pragma   comment(linker,"/subsystem:\"windows\"   /entry:\"mainCRTStartup\" ") 
#include "stdafx.h"

class Launch
{
public:
	static std::pair<LPVOID,int> LoadFromResource(const CHAR*);
	
	//static STDMETHOD(QueryInterface)( REFIID riid, void **ppInterface );        
};



