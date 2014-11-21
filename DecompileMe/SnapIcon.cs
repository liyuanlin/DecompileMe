using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DecompileMe
{
    public class SnapIcon
    {
        [DllImport("IconSnapLib.dll", EntryPoint = "?SaveIconFromEXEFile@@YA_NPBD0@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SaveIconFromEXEFile(string pExePath, string pIcoSavePath);
    }
}
