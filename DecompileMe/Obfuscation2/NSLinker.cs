using System;
using System.Collections.Generic;
using System.Text;

namespace DecompileMe.Obfuscation2
{
    /// <summary>
    /// 记录名称空间变化的轨迹
    /// </summary>
    public class NSLinker
    {
        private NSLinker(string pName)
        {
            CurrentName = pName;
        }
        private static List<NSLinker> _AllNS = new List<NSLinker>();
        
        /// <summary>
        /// 当前的名称
        /// </summary>
        private string CurrentName;
        /// <summary>
        /// 上一次的名称
        /// </summary>
        private NSLinker ParentLinker = null;
        /// <summary>
        /// 获取最初的名称空间的名字
        /// </summary>
        /// <param name="pLinker"></param>
        /// <returns></returns>
        public static string GetOriginalName(string pCurrentName)
        {
            NSLinker tLinker = null;
            for (int i = 0; i < _AllNS.Count; i++)
            {
                if (_AllNS[i].CurrentName == pCurrentName)
                {
                    tLinker = _AllNS[i];
                }
            }
            if (tLinker == null) return pCurrentName;
            while (tLinker.ParentLinker != null)
            {
                tLinker = tLinker.ParentLinker;
            }
            return tLinker.CurrentName;
        }
        public static void InitNSLinker()
        {
            _AllNS.Clear();
        }
        public static void AddNewNameSpace(string pOldName,string pNName)
        {
            NSLinker pChild = new NSLinker(pNName);
            for (int i = 0; i < _AllNS.Count; i++)
            {
                if (_AllNS[i].CurrentName == pOldName)
                {
                    pChild.ParentLinker = _AllNS[i];
                    break;
                }
            }
            if (pChild.ParentLinker == null)
            {
                NSLinker nparent = new NSLinker(pOldName);
                _AllNS.Add(nparent);//添加一个 np将是一个原始节点
                pChild.ParentLinker = nparent;
            }
            _AllNS.Add(pChild);
        }
    }
}
