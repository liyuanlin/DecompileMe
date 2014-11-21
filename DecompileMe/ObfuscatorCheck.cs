using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecompileMe
{
    public class DecompileMeCheck
    {
        public static bool CheckName(string pName)
        {
            if (pName.Length < 1)
                return false;
            if (pName == "<Module>")
                return false;
            if (pName.Contains("/"))
                return false;
            if (pName.Contains("<")) // Like "<PrivateImplementationDetails>"
                return false;
            if (pName.Contains("+"))
                return false;
            if (pName.Contains("__"))
                return false;
            if (pName.Contains("`"))
                return false;
            return true;
        }
    }
}
