using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DecompileMe
{
    public class CPlusPlusEncrypt
    {
        [DllImport("EncriptLib2.dll", EntryPoint = "?encrypt@Encrypt@@SGPAEQAEQAEAAH@Z", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr encrypt([MarshalAs(UnmanagedType.LPArray)] byte[] key, [MarshalAs(UnmanagedType.LPArray)] byte[] data, ref int length);
        public static byte[] Encrypt(byte[] key, byte[] data, ref int length)
        {
            IntPtr ptr = encrypt(key, data, ref length);
            byte[] rev=new byte[length]; 
            Marshal.Copy( ptr,rev, 0, length);
            return rev;
        }

        //[DllImport("EncriptLib2.dll", EntryPoint = "?decrypt@Encrypt@@SGPAEQAEQAEAAH@Z", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //private static extern byte[] decrypt([MarshalAs(UnmanagedType.LPArray)] byte[] key, [MarshalAs(UnmanagedType.LPArray)] byte[] data, ref int length);
        //[DllImport("EncriptLib2.dll", EntryPoint = "?ToBase64@Encrypt@@SGPADQAEH@Z", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //private static extern string ToBase64([MarshalAs(UnmanagedType.LPArray)] byte[] data, int length);
        [DllImport("EncriptLib2.dll", EntryPoint = "?FromBase64@Encrypt@@SGPAEPBDAAH@Z", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr FromBase64(string data,ref int length);
        public static byte[] DllFromBase64(string pBase64, ref int length)
        {
            IntPtr ptr = FromBase64(pBase64, ref length);
            byte[] rev = new byte[length];
            Marshal.Copy(ptr, rev, 0, length);
            return rev;
        }
    }
}
