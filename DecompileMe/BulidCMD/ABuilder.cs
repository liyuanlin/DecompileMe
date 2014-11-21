using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DecompileMe.BulidCMD
{
    internal abstract class ABuilder
    {
        protected string _CPlusPlusInclude = string.Empty;
        protected string _CLFilePath = string.Empty;
        protected string _SaveFloder = string.Empty;
        protected string _TempFloder = string.Empty;
        protected string _LibName = string.Empty;
        public ABuilder(string pCPlusPlusInclude, string pCLFilePath,string pLibName,string pSavePath)
        {
            if (!(pSavePath.EndsWith("\\") || pSavePath.EndsWith("/")))
            {
                pSavePath +="\\";
            }
            if (!Directory.Exists(pSavePath))
            {
                Directory.CreateDirectory(pSavePath);
            }
            _CLFilePath = pCLFilePath;
            _CPlusPlusInclude = pCPlusPlusInclude;
            _LibName = pLibName;
            _SaveFloder = pSavePath;
        }
        protected abstract string[] GetCmd();
        internal abstract void RunBuild();
        internal abstract void DoFiles();
        protected void CreateBat(string pFloder,string pName, string[] pContent, int offset, int length)
        {
            string sFullName = pFloder + pName;
            string content = string.Empty;
            for (int i = offset; i < offset + length && i < pContent.Length; i++)
            {
                content += pContent[i] + "\r\n";
            }
            File.WriteAllText(sFullName, content);
        }
        protected string ExecCmd(string[] pCmds)
        {
            // 实例一个Process类,启动一个独立进程
            Process p = new Process();
            // 设定程序名
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = _TempFloder;
            // 关闭Shell的使用
            p.StartInfo.UseShellExecute = false;
            // 重定向标准输入
            p.StartInfo.RedirectStandardInput = true;
            // 重定向标准输出
            p.StartInfo.RedirectStandardOutput = true;
            ////重定向错误输出
            p.StartInfo.RedirectStandardError = true;
            //// 设置不显示窗口
            p.StartInfo.CreateNoWindow = true;
            //// 启动进程

            p.Start();
            for (int i = 0; i < pCmds.Length; i++)
            {
                p.StandardInput.WriteLine(pCmds[i]);
            }
            p.StandardInput.WriteLine("exit");
            p.StandardInput.WriteLine("exit");
            // 从输出流获取命令执行结果
            string srev;
            string strRst = p.StandardOutput.ReadToEnd();
            srev = strRst;
            // if end
            p.WaitForExit();
            return srev;
        }
    }
}
