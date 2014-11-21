using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using DecompileMe.Obfuscation2;
using DecompileMe.BulidCMD;
using Mono.Cecil;
using CHTSkin.SkinForms;

namespace DecompileMe
{
    public partial class MainForm : SkinForm
    {

        #region Constructor
        private bool IsCanCloseNow = false;//是否可以现在关闭
        /// <summary>
        /// 当前正在修改的方案文件
        /// </summary>
        private string CurrentModifyFile = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            string[] sRecent = RecentFile.GetRecentFile();
            if (sRecent.Length > 0)
            {
                if (File.Exists(sRecent[0]))
                {
                    SoftConfig.ConfigPath = sRecent[0];
                    CurrentModifyFile = sRecent[0];
                    LoadData();
                }
                InitRecent(sRecent);
            }
            tmrClose.Enabled = false;
            this.BackColor = Color.FromArgb(128, 208, 255);
        }
        private void InitRecent(string[] sRecent)
        {
            RecentFiletoolStripMenuItem.DropDownItems.Clear();
            RecentFiletoolStripMenuItem.DropDownItems.Add(clearToolStripMenuItem);
            if (sRecent.Length > 0)
            {
                ToolStripSeparator ts = new ToolStripSeparator();
                RecentFiletoolStripMenuItem.DropDownItems.Insert(0, ts);

                ToolStripMenuItem tfMenu = new ToolStripMenuItem("*" + sRecent[0]);
                tfMenu.Tag = sRecent[0];
                tfMenu.Click += new EventHandler(RecentMenu_Click);
                RecentFiletoolStripMenuItem.DropDownItems.Insert(0, tfMenu);
                for (int i = sRecent.Length - 1; i > 0; i--)
                {
                    ToolStripMenuItem tMenu = new ToolStripMenuItem(sRecent[i]);
                    tMenu.Tag = sRecent[i];
                    tMenu.Click += new EventHandler(RecentMenu_Click);
                    RecentFiletoolStripMenuItem.DropDownItems.Insert(1, tMenu);
                }
            }
        }

        void RecentMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem sen = sender as ToolStripMenuItem;
            CurrentModifyFile = sen.Tag.ToString();
            LoadFileData();
        }
        public MainForm(string pConfigPath)
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            tmrClose.Enabled = true;
            SoftConfig.ConfigPath = pConfigPath;
            CurrentModifyFile = pConfigPath;
            LoadData();
            btnGenerate_Click(null, null);
        }
        #endregion

        #region Browse build path

        private void btnBrowseBuildPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            txtBuildPath.Text = dialog.SelectedPath;
        }

        #endregion

        #region Browse NET Framework folders

        private void btnNETFrameworkPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = txtNETFrameworkPath.Text;
            DialogResult result = dialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            btnNETFrameworkPath.Text = dialog.SelectedPath;
        }

        private void btnNETSDKPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = txtNETSDKPath.Text;
            DialogResult result = dialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            btnNETSDKPath.Text = dialog.SelectedPath;
        }

        #endregion

        #region Add Assembly

        private void tsbAddAssembly_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            foreach (string file in dialog.FileNames)
                if (CheckNeedToAdd(file))
                {
                    AddAssembly(file);
                }

            //--- Epand
            tvAssemblies.Nodes[0].Expand();
        }
        private bool CheckNeedToAdd(string pFileName)
        {
            for (int i = 0; i < tvAssemblies.Nodes[0].Nodes.Count; i++)
            {
                if (tvAssemblies.Nodes[0].Nodes[i].Text == pFileName)
                {
                    return false;
                }
            }
            return true;
        }
        private void AddAssembly(string file)
        {
            // Assembly
            AssemblyDefinition assembly = null;
            try
            {
                assembly = AssemblyFactory.GetAssembly(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            TreeNode assemblyNode = null;
            if (file.EndsWith(".exe") && SoftConfig.AssemblyExeIcon != string.Empty)
            {
                assemblyNode = tvAssemblies.Nodes[0].Nodes.Add(withicon_mark + file);
            }
            else
            {
                assemblyNode = tvAssemblies.Nodes[0].Nodes.Add(file);
            }
            assemblyNode.Tag = assembly;
            assemblyNode.Checked = true;
            assemblyNode.ImageIndex = assemblyNode.SelectedImageIndex = 1;
            DataTable dtName = new DataTable("TypeNames");
            dtName.Columns.Add("TypeFullName");
            dtName.Columns.Add("TypeNameSpace");
            dtName.Columns.Add("TypeName");
            try
            {
                foreach (TypeDefinition type in assembly.MainModule.Types)
                {
                    if (type.FullName.StartsWith("<PrivateImplementationDetails>"))
                        continue;
                    if (!DecompileMeCheck.CheckName(type.FullName))
                        continue;
                    if (dtName.Select("TypeNameSpace='" + type.Namespace + "'").Length > 0) continue;
                    DataRow dr = dtName.NewRow();
                    dr["TypeNameSpace"] = type.Namespace;
                    dr["TypeName"] = type.Name;
                    dr["TypeFullName"] = type.FullName;
                    dtName.Rows.Add(dr);
                }
                DataView dv = dtName.DefaultView;
                dv.Sort = "TypeFullName asc";
                for (int i = 0; i < dv.Count; i++)
                {
                    TreeNode tn = FindParentNode(assemblyNode, dv[i]["TypeNameSpace"].ToString());
                    if (tn == null)
                    {
                        tn = assemblyNode.Nodes.Add(dv[i]["TypeNameSpace"].ToString());
                        tn.Tag = dv[i]["TypeNameSpace"].ToString();
                        tn.Checked = true;
                    }
                    else
                    {
                        TreeNode tnNameSpace = tn.Nodes.Add(dv[i]["TypeNameSpace"].ToString());
                        tnNameSpace.Tag = dv[i]["TypeNameSpace"].ToString();
                        tnNameSpace.Checked = true;
                    }
                }

                foreach (TypeDefinition type in assembly.MainModule.Types)
                {

                    if (type.FullName.StartsWith("<PrivateImplementationDetails>"))
                        continue;

                    if (!DecompileMeCheck.CheckName(type.FullName))
                        continue;
                    TreeNode nodParent = FindParentNode(assemblyNode, type.FullName);
                    if (nodParent == null)
                    {
                        nodParent = assemblyNode;
                    }
                    TreeNode typeNode = nodParent.Nodes.Add(type.FullName);
                    typeNode.Tag = type;
                    typeNode.Checked = true;
                    if (type.IsEnum)
                        typeNode.ImageIndex = typeNode.SelectedImageIndex = 4;
                    else
                        typeNode.ImageIndex = typeNode.SelectedImageIndex = 3;
                }
            }
            catch (ReflectionTypeLoadException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private TreeNode FindParentNode(TreeNode Root, string pNameSpace)
        {
            if (pNameSpace.IndexOf(".") == -1) return Root;
            string ParentNameSpace = pNameSpace.Substring(0, pNameSpace.LastIndexOf("."));
            foreach (TreeNode tn in Root.Nodes)
            {
                if (tn.Tag is string && tn.Tag.ToString() == ParentNameSpace)
                {
                    return tn;
                }
                TreeNode rev = FindParentNode(tn, pNameSpace);
                if (rev != null) return rev;
            }
            return null;
        }

        #endregion

        #region Remove Assembly

        private void tsbRemoveAssembly_Click(object sender, EventArgs e)
        {
            if (tvAssemblies.SelectedNode == null) return;
            if (tvAssemblies.SelectedNode.Parent == null) return;
            tvAssemblies.SelectedNode.Parent.Nodes.Remove(tvAssemblies.SelectedNode);
        }

        #endregion

        #region Generate

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ObData.Clear();
            saveToolStripMenuItem_Click(sender, e);
            int ExeCount = CheckHaveMoreExe();
            if (ExeCount > 1)
            {
                MessageBox.Show("more than one exe file exists,please select only one exe file.");
                return;
            }
            if (ExeCount == 0 && chkObEncriptAssembly.Checked)
            {
                MessageBox.Show("you have choice the encript methods,so please select a exe file.");
                return;
            }

            DecompileMeManager DecompileMe = new DecompileMeManager(txtBuildPath.Text,
                                                    chkObfuscateTypes.Checked,
                                                    chkObfuscateMethods.Checked,
                                                    chkObEncriptAssembly.Checked,
                                                    chkObfuscateNamespaces.Checked,
                                                    chkObfuscateProperties.Checked,
                                                    chkObfuscateFields.Checked);

            string exefile = GetExeFile();
            AssInfo.ExeFileName = exefile;

            // Add assemblies
            foreach (TreeNode node in tvAssemblies.Nodes[0].Nodes)
            {
                string sExcludes = string.Empty;
                ScanNotInclude(node, ref sExcludes);
                DecompileMe.AddAssembly(GeNodetAsemblyName(node.Text), node.Checked);

                // Exclusions

                if (sExcludes != string.Empty)
                {
                    string[] sExTypes = sExcludes.Split('*');
                    foreach (string str in sExTypes)
                    {
                        DecompileMe.ExcludeType(str);
                    }
                }

            }

            DecompileMe.OutputEvent += new DecompileMeOutputEvent(DecompileMe_OutputEvent);
            DecompileMe.RequestReferencedAssemblyPath += new DecompileMeRequestReferencedAssemblyPath(DecompileMe_RequestReferencedAssemblyPath);
            DecompileMe.NameObfuscated += new DecompileMeNameObfuscated(DecompileMe_NameObfuscated);
            DecompileMe.Progress += new DecompileMeProgress(DecompileMe_Progress);
            if (chkObEncriptAssembly.Checked)
            {
                DecompileMe.AllComplated += new EventHandler(DecompileMe_AllComplated1);
            }
            else
            {
                DecompileMe.AllComplated += new EventHandler(DecompileMe_AllComplated2);
            }
            DecompileMe.StartObfuscation();

            tabControl1.SelectedIndex = 3;
        }
        void DecompileMe_AllComplated1(object sender, EventArgs e)
        {
            string launcherName = Path.GetFileName(AssInfo.ExeFileName);
            launcherName = launcherName.Substring(0, launcherName.LastIndexOf("."));
            LauncherBuilder lbl = new LauncherBuilder(SoftConfig.CplusplusIncludePath, SoftConfig.CplusplusCLPath, launcherName, txtBuildPath.Text);
            lbl.RunBuild(); //because some problem,so we don't add pro to c++ header
            lbl.DoFiles();
            DecompileMe_Progress("All Complete", 100);
            IsCanCloseNow = true;
        }
        void DecompileMe_AllComplated2(object sender, EventArgs e)
        {
            DecompileMe_Progress("All Complete", 100);
            IsCanCloseNow = true;
        }

        #endregion

        #region Generation events

        void DecompileMe_OutputEvent(StreamReader standardOutput, StreamReader standardError)
        {
            string output;

            while ((output = standardOutput.ReadLine()) != null)
                txtOutput.Text += output + System.Environment.NewLine;

            while ((output = standardError.ReadLine()) != null)
                txtOutput.Text += output + System.Environment.NewLine;
        }

        string DecompileMe_RequestReferencedAssemblyPath(string initialAssemblyPath)
        {
            AssemblyPathDialog dialog = new AssemblyPathDialog(initialAssemblyPath);
            DialogResult dr = dialog.ShowDialog(this);
            if (dr == DialogResult.OK)
                return dialog.AssemblyPath;
            return "";
        }

        void DecompileMe_NameObfuscated(DecompileMe.Obfuscation2.ObfuscationItem item, string initialName, string obfuscatedName, string notes)
        {
            ObData oda = new ObData();
            oda.Kind = item.ToString();
            oda.InitialName = initialName;
            oda.ObfuscatedName = obfuscatedName;
            oda.Notes = notes;
            ObData.Add(oda);
            ListViewItem lvItem = gridOutputMapping.Items.Add(item.ToString());
            lvItem.SubItems.Add(initialName);
            lvItem.SubItems.Add(obfuscatedName);
            lvItem.SubItems.Add(notes);
        }

        void DecompileMe_Progress(string phaseName, int percents)
        {
            txtOutput.Text += phaseName + "\t" + DateTime.Now.ToString() + "\r\n";
            lblPhaseValue.Text = phaseName;
            pbBuild.Value = percents;
        }

        #endregion

        #region Load

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        #endregion

        #region Tree view events

        private void tvAssemblies_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag is AssemblyDefinition)
                tsbRemoveAssembly.Enabled = true;
            else
                tsbRemoveAssembly.Enabled = false;
        }

        private void tvAssemblies_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                e.Cancel = true;
                return;
            }
        }

        private void tvAssemblies_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
                UpdateChildNodes(e.Node);
        }

        private void UpdateChildNodes(TreeNode node)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = node.Checked;
                UpdateChildNodes(child);
            }
        }

        #endregion


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SoftConfig.ConfigPath
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "select a run file";
            ofd.Filter = "xml file|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentModifyFile = ofd.FileName;
                LoadFileData();
            }
        }
        private void LoadFileData()
        {
            SoftConfig.ConfigPath = CurrentModifyFile;
            LoadData();
            RecentFile.UpdateMostRecent(CurrentModifyFile);
            InitRecent(RecentFile.GetRecentFile());
        }
        private void LoadData()
        {
            txtBuildPath.Text = SoftConfig.BuildPath;
            txtNETFrameworkPath.Text = SoftConfig.NETFrameworkPath;
            txtNETSDKPath.Text = SoftConfig.NETSDKPath;
            chkObfuscateFields.Checked = SoftConfig.ObfuscateFields;
            chkObfuscateMethods.Checked = SoftConfig.ObfuscateMethods;
            chkObEncriptAssembly.Checked = SoftConfig.Encriptmethods;
            chkAssBase64.Checked = chkObEncriptAssembly.Checked && SoftConfig.AddBase64ToAssembly;
            chkObfuscateNamespaces.Checked = SoftConfig.ObfuscateNamespaces;
            chkObfuscateProperties.Checked = SoftConfig.ObfuscateProperties;
            chkObfuscateTypes.Checked = SoftConfig.ObfuscateTypes;

            txtCLCommandPath.Text = SoftConfig.CplusplusCLPath;
            txtCPlusPlusInclude.Text = SoftConfig.CplusplusIncludePath;

            tvAssemblies.Nodes[0].Nodes.Clear();
            string[] sAssemblies = SoftConfig.AssemblyNames.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sAssemblies.Length; i++)
            {
                if (File.Exists(sAssemblies[i]))
                {
                    AddAssembly(sAssemblies[i]);
                }
                else
                {
                    string nPath = DecompileMe_RequestReferencedAssemblyPath(Environment.CurrentDirectory);
                    if (nPath == "") continue;
                    AddAssembly(nPath);
                }
            }
            // Add assemblies


            string[] sExcludes = SoftConfig.ExcludeTypes.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (TreeNode node in tvAssemblies.Nodes[0].Nodes)
            {
                CheckTypeNode(sExcludes, node);
            }

        }
        private void CheckTypeNode(string[] pExcludes, TreeNode typeNodeRoot)
        {
            foreach (TreeNode typeNode in typeNodeRoot.Nodes)
            {
                if (typeNode.Tag is TypeDefinition)
                {
                    if (CheckIsExclude(pExcludes, ((TypeDefinition)typeNode.Tag).FullName))
                    {
                        typeNode.Checked = false;
                    }
                }
                else
                {
                    CheckTypeNode(pExcludes, typeNode);
                }
            }
        }
        private bool CheckIsExclude(string[] pExclude, string pFullName)
        {
            foreach (string s in pExclude)
            {
                if (s == pFullName) return true;
            }
            return false;
        }
        /// <summary>
        /// 检查是否含有多个exe文件
        /// </summary>
        /// <returns></returns>
        private int CheckHaveMoreExe()
        {
            int exeCount = 0;
            foreach (TreeNode node in tvAssemblies.Nodes[0].Nodes)
            {
                if (node.Text.ToLower().EndsWith(".exe"))
                {
                    exeCount++;
                }
            }
            return exeCount;
        }
        const string withicon_mark = "[*with icon]";
        /// <summary>
        /// 返回那个exe文件
        /// </summary>
        /// <returns></returns>
        private string GetExeFile()
        {
            foreach (TreeNode node in tvAssemblies.Nodes[0].Nodes)
            {
                if (node.Text.ToLower().EndsWith(".exe"))
                {
                    if (node.Text.ToLower().StartsWith(withicon_mark))
                    {
                        return node.Text.Substring(withicon_mark.Length);
                    }
                    return node.Text;
                }
            }
            return null;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ExeCount = CheckHaveMoreExe();
            if (ExeCount > 1)
            {
                MessageBox.Show("more than one exe file exists,please select only one exe file.");
                return;
            }
            if (ExeCount == 0 && chkObEncriptAssembly.Checked)
            {
                MessageBox.Show("you have choice the encript methods,so please select a exe file.");
                return;
            }
            if (CurrentModifyFile == string.Empty)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "xml files *.xml|*.xml";
                sfd.Title = "save a solution file";
                sfd.DefaultExt = "xml";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                CurrentModifyFile = sfd.FileName;
            }
            SoftConfig.ConfigPath = CurrentModifyFile;
            SoftConfig.BuildPath = txtBuildPath.Text;
            SoftConfig.NETFrameworkPath = txtNETFrameworkPath.Text;
            SoftConfig.NETSDKPath = txtNETSDKPath.Text;
            SoftConfig.ObfuscateFields = chkObfuscateFields.Checked;
            SoftConfig.ObfuscateMethods = chkObfuscateMethods.Checked;
            SoftConfig.Encriptmethods = chkObEncriptAssembly.Checked;
            SoftConfig.AddBase64ToAssembly = chkObEncriptAssembly.Checked && chkAssBase64.Checked;
            SoftConfig.ObfuscateNamespaces = chkObfuscateNamespaces.Checked;
            SoftConfig.ObfuscateProperties = chkObfuscateProperties.Checked;
            SoftConfig.ObfuscateTypes = chkObfuscateTypes.Checked;

            SoftConfig.CplusplusCLPath = txtCLCommandPath.Text;
            SoftConfig.CplusplusIncludePath = txtCPlusPlusInclude.Text;

            string pAssemblies = string.Empty;
            string pExcludes = string.Empty;
            // Add assemblies
            foreach (TreeNode node in tvAssemblies.Nodes[0].Nodes)
            {
                pAssemblies += GeNodetAsemblyName(node.Text) + "*";
                // Exclusions
                ScanNotInclude(node, ref pExcludes);
            }
            pAssemblies = pAssemblies == string.Empty ? string.Empty : pAssemblies.TrimEnd('*');
            pExcludes = pExcludes == string.Empty ? string.Empty : pExcludes.TrimEnd('*');
            SoftConfig.AssemblyNames = pAssemblies;
            SoftConfig.ExcludeTypes = pExcludes;

            RecentFile.UpdateMostRecent(CurrentModifyFile);
            InitRecent(RecentFile.GetRecentFile());
        }
        private string GeNodetAsemblyName(string pNodeText)
        {
            if (pNodeText.ToLower().EndsWith(".exe"))
            {
                if (pNodeText.ToLower().StartsWith(withicon_mark))
                {
                    return pNodeText.Substring(withicon_mark.Length);
                }
            }
            return pNodeText;
        }
        private void ScanNotInclude(TreeNode pRoot, ref string pExclude)
        {
            foreach (TreeNode typeNode in pRoot.Nodes)
            {
                if (typeNode.Tag is TypeDefinition)
                {
                    if (!typeNode.Checked)
                        pExclude += ((TypeDefinition)typeNode.Tag).FullName + "*";
                }
                else
                {
                    ScanNotInclude(typeNode, ref pExclude);
                }
            }
        }
        private void tmrClose_Tick(object sender, EventArgs e)
        {

            if (IsCanCloseNow)
            {
                tmrClose.Stop();
                Application.Exit();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecentFile.ClearRecentFile();
            RecentFiletoolStripMenuItem.DropDownItems.Clear();
            RecentFiletoolStripMenuItem.DropDownItems.Add(clearToolStripMenuItem);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftConfig.ConfigPath = RecentFile.DEFAULTCONFIG;
            CurrentModifyFile = string.Empty;
            LoadData();
        }


        private void btnBrowIncludeFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = txtCPlusPlusInclude.Text;
            DialogResult result = dialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            txtCPlusPlusInclude.Text = dialog.SelectedPath;
        }

        private void btnBrowCLCommand_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = txtCLCommandPath.Text;
            ofd.Title = "Select vcvarsall.bat File";
            ofd.Filter = "bat file|vcvarsall.bat";
            DialogResult result = ofd.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            txtCLCommandPath.Text = ofd.FileName;
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".xml";
            sfd.Filter = "xml文件|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ObData.Save(sfd.FileName);
            }
        }

        private void chkObEncriptAssembly_CheckedChanged(object sender, EventArgs e)
        {
            chkAssBase64.Enabled = chkObEncriptAssembly.Checked;
            if (!chkObEncriptAssembly.Checked) chkAssBase64.Checked = false;
        }

        private void viewICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExeICON frm = new frmExeICON();
            frm.ShowDr();
        }

        private void cMenuSelect_Opening(object sender, CancelEventArgs e)
        {
            if (tvAssemblies.SelectedNode == null)
            {
                e.Cancel = true;
            }
            else
            {
                viewICOToolStripMenuItem.Enabled = tvAssemblies.SelectedNode.Text.ToLower().EndsWith(".exe");
            }
        }

    }
}