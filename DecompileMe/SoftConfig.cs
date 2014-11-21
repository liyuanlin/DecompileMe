using System;

namespace DecompileMe
{
    public static class SoftConfig
    {
       
        #region private
        private static string _ConfigPath = AppDomain.CurrentDomain.BaseDirectory + "\\Config.xml";
        public static string ConfigPath
        {
            get { return _ConfigPath; }
            set
            {
                _ConfigPath = value;
                _CurrentDataSet = null;
            }
        }
        private static System.Data.DataSet _CurrentDataSet = null;
        private static System.Data.DataSet GetSettingDataSet()
        {
            if (_CurrentDataSet == null)
            {
                string cPath = ConfigPath;
                System.Data.DataSet ds = new System.Data.DataSet();
                if (System.IO.File.Exists(cPath))
                {
                    ds.ReadXml(cPath);
                }
                else
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.TableName = "SoftSetting";
                    dt.Columns.Add("DataKeys");
                    dt.Columns.Add("DataValues");
                    ds.Tables.Add(dt);
                    ds.DataSetName = "SystemSetting";
                    string dir = System.IO.Path.GetDirectoryName(cPath);
                    if (!System.IO.Directory.Exists(dir))
                    {
                        System.IO.Directory.CreateDirectory(dir);
                    }
                    ds.WriteXml(cPath);
                }
                _CurrentDataSet = ds;
            }
            return _CurrentDataSet;

        }
        public static string GetSoftConfig(string pKey)
        {
            System.Data.DataSet ds = GetSettingDataSet();
            System.Data.DataRow[] drs = ds.Tables[0].Select("DataKeys='" + pKey + "'");
            if (drs.Length > 0)
            {
                return drs[0]["DataValues"].ToString();
            }
            else
            {
                SetSoftConfig(pKey, "");
            }
            return "";
        }
        public static void SetSoftConfig(string pKey, string pNValue)
        {
            System.Data.DataSet ds = GetSettingDataSet();
            System.Data.DataRow[] drs = ds.Tables[0].Select("DataKeys='" + pKey + "'");
            if (drs.Length > 0)
            {
                if (drs[0]["DataValues"].ToString() == pNValue) return;//值没有发生改变
                else drs[0]["DataValues"] = pNValue;
            }
            else
            {
                System.Data.DataRow dr = ds.Tables[0].NewRow();
                dr["DataKeys"] = pKey;
                dr["DataValues"] = pNValue;
                ds.Tables[0].Rows.Add(dr);
            }
            string cPath = (ConfigPath);
            ds.WriteXml(cPath);
            _CurrentDataSet = null;
        }
        #endregion

        private const string Key_BuildPath = "BuildPath";
        /// <summary>
        /// 生成以后文件保存的位置
        /// </summary>
        public static string BuildPath
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_BuildPath, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_BuildPath);
            }
        }



        private const string Key_CplusplusIncludePath = "CplusplusIncludePath";
        /// <summary>
        ///  c++ include file的位置
        /// </summary>
        public static string CplusplusIncludePath
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_CplusplusIncludePath, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_CplusplusIncludePath);
            }
        }

        private const string Key_CplusplusCLPath = "CplusplusCLPath";
        /// <summary>
        ///  c++ cl.exe file的位置
        /// </summary>
        public static string CplusplusCLPath
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_CplusplusCLPath, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_CplusplusCLPath);
            }
        }

        private const string Key_NETFrameworkPath = "NETFrameworkPath";
        /// <summary>
        /// .net框架的位置
        /// </summary>
        public static string NETFrameworkPath
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_NETFrameworkPath, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_NETFrameworkPath);
            }
        }

        private const string Key_NETSDKPath = "NETSDKPath";
        /// <summary>
        /// .net SDK的位置
        /// </summary>
        public static string NETSDKPath
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_NETSDKPath, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_NETSDKPath);
            }
        }
        
        private const string Key_ObfuscateTypes = "ObfuscateTypes";
        /// <summary>
        /// ObfuscateTypes
        /// </summary>
        public static bool ObfuscateTypes
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_ObfuscateTypes, value?"1":"0");
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_ObfuscateTypes)=="1";
            }
        }


        private const string Key_ObfuscateMethods = "ObfuscateMethods";
        /// <summary>
        /// ObfuscateMethods
        /// </summary>
        public static bool ObfuscateMethods
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_ObfuscateMethods, value ? "1" : "0");
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_ObfuscateMethods)=="1";
            }
        }


        private const string Key_Encriptmethods = "Encriptmethods";
        /// <summary>
        /// Encript methods
        /// </summary>
        public static bool Encriptmethods
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_Encriptmethods, value ? "1" : "0");
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_Encriptmethods) == "1";
            }
        }
        private const string Key_AddBase64ToAssembly = "AddBase64ToAssembly";

        public static bool AddBase64ToAssembly
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_AddBase64ToAssembly, value ? "1" : "0");
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_AddBase64ToAssembly) == "1";
            }
        }
        private const string Key_ObfuscateNamespaces = "ObfuscateNamespaces";
        /// <summary>
        /// ObfuscateNamespaces
        /// </summary>
        public static bool ObfuscateNamespaces
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_ObfuscateNamespaces, value ? "1" : "0");
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_ObfuscateNamespaces)=="1";
            }
        }
        private const string Key_ObfuscateProperties = "ObfuscateProperties";
        /// <summary>
        /// ObfuscateProperties
        /// </summary>
        public static bool ObfuscateProperties
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_ObfuscateProperties, value ? "1" : "0");
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_ObfuscateProperties) == "1";
            }
        }


        private const string Key_ObfuscateFields = "ObfuscateFields";
        /// <summary>
        /// ObfuscateFields
        /// </summary>
        public static bool ObfuscateFields
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_ObfuscateFields, value ? "1" : "0");
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_ObfuscateFields) == "1";
            }
        }
        private const string Key_ExcludeTypes = "ExcludeTypes";
        /// <summary>
        /// 不进行混淆的类 以 *号分隔
        /// </summary>
        public static string ExcludeTypes
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_ExcludeTypes, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_ExcludeTypes);
            }
        }

        private const string Key_AssemblyNames = "AssemblyNames";
        /// <summary>
        /// 要混淆的Assemblys 以 *号分隔
        /// </summary>
        public static string AssemblyNames
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_AssemblyNames, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_AssemblyNames);
            }
        }

        private const string Key_ExeIcon = "ExeIcon";
        public static string AssemblyExeIcon
        {
            set
            {
                try
                {
                    SetSoftConfig(Key_ExeIcon, value);
                }
                catch { }
            }
            get
            {
                return GetSoftConfig(Key_ExeIcon);
            }
        }
    }
}
