using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CHT.SDK;

namespace DecompileMe
{
    public class ObData
    {
        private readonly static string _ConfigPath = AppDomain.CurrentDomain.BaseDirectory + "ObData.xml";
        private static DataSet _CurrentData;
        private static DataSet CurrentData
        {
            get
            {
                if (_CurrentData == null)
                {
                    try
                    {
                        _CurrentData = DSOperator.LoadDataSet1(GetDataScheam(), _ConfigPath);
                    }
                    catch
                    {
                        _CurrentData = GetDataScheam();
                    }
                }
                return _CurrentData;
            }
        }
        private const string Col_Kind = "Kind";
        private const string Col_InitialName = "InitialName";
        private const string Col_ObfuscatedName = "ObfuscatedName";
        private const string Col_Notes = "Notes";
        private string _Kind;//关键字
        private string _InitialName;//初始名称
        private string _ObfuscatedName;//混淆以后的字符串
        private string _Notes;//备注
        /// <summary>
        /// 关键字
        ///</summary>
        public string Kind
        {
	        get{ return _Kind; }
	        set{ _Kind=value; }
        }
        /// <summary>
        /// 表达式
        ///</summary>
        public string InitialName
        {
	        get{ return _InitialName; }
	        set{ _InitialName=value; }
        }
        /// <summary>
        /// 匹配示例
        ///</summary>
        public string ObfuscatedName
        {
	        get{ return _ObfuscatedName; }
	        set{ _ObfuscatedName=value; }
        }

        public string Notes
        {
            get { return _Notes; }
            set { _Notes = value; }
        }

        public ObData()
        {
        }       
        private static DataSet GetDataScheam()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Regex");
            dt.Columns.Add(Col_Kind);
            dt.Columns.Add(Col_InitialName);
            dt.Columns.Add(Col_ObfuscatedName);
            dt.Columns.Add(Col_Notes);
            ds.Tables.Clear();
            ds.Tables.Add(dt);
            return ds;
        }
        public static void Add(ObData p)
        {
            DataRow dr = CurrentData.Tables[0].NewRow();
            dr[Col_Kind] = p.Kind;
            dr[Col_InitialName] = p.InitialName;
            dr[Col_ObfuscatedName] = p._ObfuscatedName;
            dr[Col_Notes] = p.Notes;
            CurrentData.Tables[0].Rows.Add(dr);
        }
        public static bool CheckKeyExists(string pKey)
        {
            return CurrentData.Tables[0].Select(string.Format("{0}='{1}'",Col_Kind,pKey)).Length>0;
        }
        public static void RemoveByKey(string pKey)
        {
            DataRow[] drs = CurrentData.Tables[0].Select(string.Format("{0}='{1}'", Col_Kind, pKey));
            for (int i = 0; i < drs.Length; i++)
            {
                CurrentData.Tables[0].Rows.Remove(drs[i]);
            }
        }
        public static void Clear()
        {
            CurrentData.Tables[0].Rows.Clear();
        }
        public static void Save()
        {
            DSOperator.SaveDataSet1(CurrentData, _ConfigPath);
        }
        public static void Save(string pCopyPath)
        {
            DSOperator.SaveDataSet1(CurrentData, _ConfigPath);
            DSOperator.SaveDataSet1(CurrentData, pCopyPath);
        }
    }
}
