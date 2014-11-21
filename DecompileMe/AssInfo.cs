using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DecompileMe
{
    public class AssInfo
    {
        private static string _ExeFileName = string.Empty;
        public static string ExeFileName
        {
            get
            {
                return _ExeFileName;
            }
            set
            {
                _ExeFileName = value;
            }
        }
        private Assembly _Ass = null;
        public AssInfo(Assembly pAss)
        {
            _Ass = pAss;
        }
        public string ReplaceCPlusPlusVersion(string pOldVersionFile)
        {
            /*
BEGIN
    BLOCK "StringFileInfo"
    BEGIN
        BLOCK "080404b0"
        BEGIN
            VALUE "CompanyName", "{COMPANYNAME}"
            VALUE "FileDescription", "{FILEDESCRIPTION}"
            VALUE "FileVersion", "{FILEVERSION}"
            VALUE "InternalName", "{INTERNALNAME}"
            VALUE "LegalCopyright", "{LEGALCOPYRIGHT}"
            VALUE "OriginalFilename", "ORIGINALFILENAME"
            VALUE "ProductName", "{PRODUCTNAME}"
            VALUE "ProductVersion", "{PRODUCTVERSION}"
        END
    END
    BLOCK "VarFileInfo"
    BEGIN
        VALUE "Translation", 0x804, 1200
    END
END
             */
            string StringFileInfo = pOldVersionFile;
            StringFileInfo = StringFileInfo.Replace("{COMPANYNAME}", AssemblyCompany);
            StringFileInfo = StringFileInfo.Replace("{FILEDESCRIPTION}", AssemblyDescription);
            StringFileInfo = StringFileInfo.Replace("{FILEVERSION}", AssemblyFileVersion);

            StringFileInfo = StringFileInfo.Replace("{INTERNALNAME}", AssemblyProduct);
            StringFileInfo = StringFileInfo.Replace("{LEGALCOPYRIGHT}", AssemblyCopyright);
            StringFileInfo = StringFileInfo.Replace("{ORIGINALFILENAME}", AssemblyTitle);

            StringFileInfo = StringFileInfo.Replace("{PRODUCTNAME}", AssemblyCopyright);
            StringFileInfo = StringFileInfo.Replace("{PRODUCTVERSION}", AssemblyVersion);
            return StringFileInfo;
        }
        string AssemblyVersion
        {
            get
            {
                return _Ass.GetName().Version.ToString();
            }
        }
        string AssemblyTitle
        {
            get
            {
                object[] attributes = _Ass.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyTitleAttribute)attributes[0]).Title;
            }
        }
        string AssemblyFileVersion
        {
            get
            {
                object[] attributes = _Ass.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyFileVersionAttribute)attributes[0]).Version;
            }
        }

        string AssemblyDescription
        {
            get
            {
                object[] attributes = _Ass.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        string AssemblyProduct
        {
            get
            {
                object[] attributes = _Ass.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        string AssemblyCopyright
        {
            get
            {
                object[] attributes = _Ass.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        string AssemblyCompany
        {
            get
            {
                object[] attributes = _Ass.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    }
}
