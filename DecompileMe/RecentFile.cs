using System;
using System.Collections.Generic;
using System.Text;

namespace DecompileMe
{
   public class RecentFile
    {

       public static readonly string DEFAULTCONFIG = AppDomain.CurrentDomain.BaseDirectory + "base.dat";
        #region private
        private static string _ConfigPath = AppDomain.CurrentDomain.BaseDirectory + "\\Setting.xml";
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

        private const string Key_RecentFile = "RecentFile";
        private const int MaxRecentFile = 10;
        /// <summary>
        /// 最近使用过的方案文件的位置
        /// </summary>
        public static string[] GetRecentFile()
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < MaxRecentFile; i++)
            {
                string v = GetSoftConfig(Key_RecentFile + i);
                if (v != string.Empty)
                {
                    lst.Add(v);
                }
            }
            return lst.ToArray();
        }

        /// <summary>
        /// 设置最近使用过的方案文件的位置
        /// </summary>
        public static void SetRecentFile(string[] pValue)
        {
            for (int j = 0; j < pValue.Length; j++)
            {
                if (IsRepeated(pValue, pValue[j],j))
                {
                    pValue[j] = "";
                }
            }
            int i = 0;
            for (; i < pValue.Length&&i<MaxRecentFile; i++)
            {
                SetSoftConfig(Key_RecentFile + i, pValue[i]);
            }
            for (; i < MaxRecentFile; i++)
            {
                SetSoftConfig(Key_RecentFile + i, "");
            }
           
        }
       /// <summary>
       /// 是否有两个以上
       /// </summary>
       /// <param name="pSrc"></param>
       /// <param name="pValue"></param>
       /// <param name="pCurrentIndex">当前id</param>
       /// <returns></returns>
        private static bool IsRepeated(string[] pSrc, string pValue,int pCurrentIndex)
        {
            for (int i = pCurrentIndex-1; i >= 0; i--)
            {
                if (pSrc[i] == pValue) return true;
            }
            return false;
        }

        public static void UpdateMostRecent(string pValue)
        {
            string[] sall = GetRecentFile();
            string[] smore = new string[sall.Length + 1];
            smore[0] = pValue;
            for (int i = 0; i < sall.Length; i++)
            {
                smore[i + 1] = sall[i];
            }
            SetRecentFile(smore);
        }
        /// <summary>
        /// 设置最近使用过的方案文件的位置
        /// </summary>
        public static void ClearRecentFile()
        {
            for (int i = 0; i < MaxRecentFile; i++)
            {
                SetSoftConfig(Key_RecentFile + i, "");
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
    }
}
