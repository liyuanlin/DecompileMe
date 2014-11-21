using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using Mono.Cecil.Cil;
using System.Reflection;
namespace DecompileMe.BulidCMD
{
    internal class LauncherBuilder : ABuilder
    {

        private string _ExeFileICO = string.Empty;
        private string _GUIDExeName = string.Empty;
        #region IBuilder Members
        internal LauncherBuilder(string pCPlusPlusInclude, string pCLFilePath, string pLibName, string pSavePath)
            : base(pCPlusPlusInclude, pCLFilePath, pLibName, pSavePath)
        {
            _TempFloder = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\" + Guid.NewGuid().ToString("N") + "\\";
            Directory.CreateDirectory(_TempFloder);
            _GUIDExeName = Guid.NewGuid().ToString("N") + ".exe";
        }
        /// <summary>
        /// 在本类中使用， 编译完成以后，对临时文件的处理
        /// </summary>
        internal override void DoFiles()
        {
            File.Delete(_SaveFloder + Path.GetFileName(AssInfo.ExeFileName));
            System.Threading.Thread.Sleep(10);
            File.Copy(_TempFloder + _LibName + ".exe", _SaveFloder + _LibName + ".exe", true);//将编译得到的主文件拷贝到指定的目录
            if (SoftConfig.Encriptmethods)
            {
                File.WriteAllBytes(_SaveFloder + "EncriptLib2.dll", global::DecompileMe.Properties.Resources.EncriptLib2dll);
            }
            Directory.Delete(_TempFloder, true);
            System.Threading.Thread.Sleep(10);
        }
        protected override string[] GetCmd()
        {
            string[] rev = new string[6];
            rev[0] = "%comspec% /k \"\"" + _CLFilePath + "\"\" x86";
            rev[1] = "echo off";
            rev[2] = "rc /fo launcher.res Starter.rc";

            //使用c++包裹一下
            rev[3] = "cl *.cpp /Od /D_MBCS /EHsc /RTC1 /MDd /W3 /c /TP /Yc\"stdafx.h\" /Fp\"stdafx.pch\" /INCREMENTAL /I\"" + _CPlusPlusInclude + "\"";
            if (SoftConfig.Encriptmethods)
            {//如果需要加密,则需要link EncriptLib2.lib 
                rev[4] = "link Launch.obj Starter.obj stdafx.obj launcher.res EncriptLib2.lib /SUBSYSTEM:WINDOWS /ENTRY:\"mainCRTStartup\" /MACHINE:X86 /out:" + _LibName + ".exe /INCREMENTAL:NO";
            }
            else
            {
                rev[4] = "link Launch.obj Starter.obj stdafx.obj launcher.res /SUBSYSTEM:WINDOWS /ENTRY:\"mainCRTStartup\" /MACHINE:X86 /out:" + _LibName + ".exe /INCREMENTAL:NO";
            }
            rev[5] = "mt -manifest \"" + _LibName + ".exe.manifest\" /outputresource:\"" + _LibName + ".exe;#1\"";
            return rev;
        }
        private void WriteICO()
        {
            _ExeFileICO = _TempFloder + "laucherexe.ico";
            if (SoftConfig.AssemblyExeIcon != string.Empty && File.Exists(SoftConfig.AssemblyExeIcon))
            {
                File.Copy(SoftConfig.AssemblyExeIcon, _ExeFileICO);
            }
            else
            {
                SnapIcon.SaveIconFromEXEFile(AssInfo.ExeFileName, _ExeFileICO);
            }
        }
        private string GetStarterh()
        {

            string rev = global::DecompileMe.Properties.Resources.Lau_StarterNavh;
            if (SoftConfig.Encriptmethods)
            {
                rev = rev.Replace("{_AssembleEncrypt_}", "#define AssembleEncrypt");
            }
            else
            {
                rev = rev.Replace("{_AssembleEncrypt_}", "");
            }
            if (SoftConfig.AddBase64ToAssembly)
            {
                rev = rev.Replace("{_AssembleBase64_}", "#define AssembleBase64");
            }
            else
            {
                rev = rev.Replace("{_AssembleBase64_}", "");
            }
            return rev;
        }
        private void GenLaunchCode()
        {
            string fname = Path.GetFileName(AssInfo.ExeFileName);
            File.WriteAllText(_TempFloder + "Launch.h", global::DecompileMe.Properties.Resources.Lau_Launchh, Encoding.Unicode);
            File.WriteAllText(_TempFloder + "Launch.cpp", global::DecompileMe.Properties.Resources.Lau_Launchcpp, Encoding.Unicode);
            File.WriteAllText(_TempFloder + "Starter.h", GetStarterh(), Encoding.Unicode);
            File.WriteAllText(_TempFloder + "Starter.cpp", global::DecompileMe.Properties.Resources.Lau_StarterNavcpp.Replace("{_MAINEXENAME_}", _GUIDExeName), Encoding.Unicode);

            if (SoftConfig.ObfuscateMethods)
            {
                File.WriteAllBytes(_TempFloder + "EncriptLib2.lib", global::DecompileMe.Properties.Resources.EncriptLib2lib);
                File.WriteAllText(_TempFloder + "EncryptEx.h", global::DecompileMe.Properties.Resources.EncryptExh, Encoding.Unicode);
            }
            else if (SoftConfig.Encriptmethods)
            {
                File.WriteAllBytes(_TempFloder + "EncriptLib2.lib", global::DecompileMe.Properties.Resources.EncriptLib2lib);
                File.WriteAllText(_TempFloder + "EncryptEx.h", global::DecompileMe.Properties.Resources.EncryptExh, Encoding.Unicode);
            }
            File.WriteAllText(_TempFloder + "stdafx.h", global::DecompileMe.Properties.Resources.Lau_stdafxh, Encoding.Unicode);
            File.WriteAllText(_TempFloder + "stdafx.cpp", global::DecompileMe.Properties.Resources.Lau_stdafxcpp, Encoding.Unicode);
            string nRc = global::DecompileMe.Properties.Resources.Lau_Starterrc.Replace("{MAINEXEICON}", Path.GetFileName(_ExeFileICO));
            AssInfo ainfo = new AssInfo(Assembly.LoadFrom(AssInfo.ExeFileName));
            nRc = ainfo.ReplaceCPlusPlusVersion(nRc);
            nRc = nRc.Replace("{MAINEXEFILE}", _GUIDExeName);
            File.WriteAllText(_TempFloder + "resource.h", global::DecompileMe.Properties.Resources.Lau_resourceh, Encoding.Unicode);
            File.WriteAllText(_TempFloder + "Starter.rc", nRc, Encoding.Unicode);
            if (SoftConfig.Encriptmethods)//如果需要加密，则加密后放到临时目录去
            {
                byte[] exeFile = File.ReadAllBytes(_SaveFloder.Replace("\\", "\\\\") + fname);
                int fileLen = exeFile.Length;
                byte[] Key = { 234, 123, 212, 13, 4, 125, 86, 97 };
                byte[] enFile = CPlusPlusEncrypt.Encrypt(Key, exeFile, ref fileLen);
                File.WriteAllBytes(_TempFloder + _GUIDExeName, enFile);
            }
            else
            {//不需要加密，直接拷贝到临时目录里面去。
                File.Copy(_SaveFloder.Replace("\\", "\\\\") + fname, _TempFloder + _GUIDExeName);
            }
        }
        internal override void RunBuild()
        {

            WriteICO();
            GenLaunchCode();
            string[] sbat = new string[2];
            CreateBat(_TempFloder, "bat001.bat", GetCmd(), 0, 1);
            CreateBat(_TempFloder, "bat002.bat", GetCmd(), 1, 5);
            sbat[0] = "bat001.bat";
            sbat[1] = "bat002.bat";
            string rev = ExecCmd(sbat);
        }

        #endregion
    }
}
