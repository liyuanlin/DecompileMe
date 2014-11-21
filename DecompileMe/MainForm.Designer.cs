namespace DecompileMe
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Assemblies");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.chkObEncriptAssembly = new System.Windows.Forms.CheckBox();
            this.chkAssBase64 = new System.Windows.Forms.CheckBox();
            this.chkObfuscateFields = new System.Windows.Forms.CheckBox();
            this.chkObfuscateProperties = new System.Windows.Forms.CheckBox();
            this.chkObfuscateNamespaces = new System.Windows.Forms.CheckBox();
            this.chkObfuscateMethods = new System.Windows.Forms.CheckBox();
            this.chkObfuscateTypes = new System.Windows.Forms.CheckBox();
            this.btnNETSDKPath = new CHTSkin.ButtonExs.ButtonEx();
            this.btnNETFrameworkPath = new CHTSkin.ButtonExs.ButtonEx();
            this.txtNETSDKPath = new System.Windows.Forms.MaskedTextBox();
            this.txtNETFrameworkPath = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCPlusPlusSetting = new System.Windows.Forms.TabPage();
            this.btnBrowCLCommand = new CHTSkin.ButtonExs.ButtonEx();
            this.btnBrowIncludeFile = new CHTSkin.ButtonExs.ButtonEx();
            this.txtCLCommandPath = new System.Windows.Forms.MaskedTextBox();
            this.txtCPlusPlusInclude = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageAssemblies = new System.Windows.Forms.TabPage();
            this.tvAssemblies = new System.Windows.Forms.TreeView();
            this.cMenuSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMenuCheckSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenuUnCheckSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenuReverse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilAssemblies = new System.Windows.Forms.ImageList(this.components);
            this.tsAssemblies = new System.Windows.Forms.ToolStrip();
            this.tsbAddAssembly = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveAssembly = new System.Windows.Forms.ToolStripButton();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPhaseValue = new System.Windows.Forms.Label();
            this.pbBuild = new System.Windows.Forms.ProgressBar();
            this.lblPhase = new System.Windows.Forms.Label();
            this.tabOutPutMapping = new System.Windows.Forms.TabPage();
            this.gridOutputMapping = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMenuRecord = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowseBuildPath = new CHTSkin.ButtonExs.ButtonEx();
            this.txtBuildPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.solutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RecentFiletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            this.tabCPlusPlusSetting.SuspendLayout();
            this.tabPageAssemblies.SuspendLayout();
            this.cMenuSelect.SuspendLayout();
            this.tsAssemblies.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabOutPutMapping.SuspendLayout();
            this.cMenuRecord.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabCPlusPlusSetting);
            this.tabControl1.Controls.Add(this.tabPageAssemblies);
            this.tabControl1.Controls.Add(this.tabPageOutput);
            this.tabControl1.Controls.Add(this.tabOutPutMapping);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 358);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.gbxOptions);
            this.tabPageSettings.Controls.Add(this.btnNETSDKPath);
            this.tabPageSettings.Controls.Add(this.btnNETFrameworkPath);
            this.tabPageSettings.Controls.Add(this.txtNETSDKPath);
            this.tabPageSettings.Controls.Add(this.txtNETFrameworkPath);
            this.tabPageSettings.Controls.Add(this.label3);
            this.tabPageSettings.Controls.Add(this.label2);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(722, 332);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.chkObEncriptAssembly);
            this.gbxOptions.Controls.Add(this.chkAssBase64);
            this.gbxOptions.Controls.Add(this.chkObfuscateFields);
            this.gbxOptions.Controls.Add(this.chkObfuscateProperties);
            this.gbxOptions.Controls.Add(this.chkObfuscateNamespaces);
            this.gbxOptions.Controls.Add(this.chkObfuscateMethods);
            this.gbxOptions.Controls.Add(this.chkObfuscateTypes);
            this.gbxOptions.Location = new System.Drawing.Point(9, 68);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(679, 152);
            this.gbxOptions.TabIndex = 6;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Generation";
            // 
            // chkObEncriptAssembly
            // 
            this.chkObEncriptAssembly.AutoSize = true;
            this.chkObEncriptAssembly.Location = new System.Drawing.Point(8, 57);
            this.chkObEncriptAssembly.Name = "chkObEncriptAssembly";
            this.chkObEncriptAssembly.Size = new System.Drawing.Size(120, 16);
            this.chkObEncriptAssembly.TabIndex = 10;
            this.chkObEncriptAssembly.Text = "加密启动Assembly";
            this.chkObEncriptAssembly.UseVisualStyleBackColor = true;
            this.chkObEncriptAssembly.CheckedChanged += new System.EventHandler(this.chkObEncriptAssembly_CheckedChanged);
            // 
            // chkAssBase64
            // 
            this.chkAssBase64.AutoSize = true;
            this.chkAssBase64.Enabled = false;
            this.chkAssBase64.Location = new System.Drawing.Point(166, 57);
            this.chkAssBase64.Name = "chkAssBase64";
            this.chkAssBase64.Size = new System.Drawing.Size(216, 16);
            this.chkAssBase64.TabIndex = 9;
            this.chkAssBase64.Text = "将启动程序本身作作为参数传给程序";
            this.chkAssBase64.UseVisualStyleBackColor = true;
            // 
            // chkObfuscateFields
            // 
            this.chkObfuscateFields.AutoSize = true;
            this.chkObfuscateFields.Checked = true;
            this.chkObfuscateFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateFields.Location = new System.Drawing.Point(8, 119);
            this.chkObfuscateFields.Name = "chkObfuscateFields";
            this.chkObfuscateFields.Size = new System.Drawing.Size(120, 16);
            this.chkObfuscateFields.TabIndex = 7;
            this.chkObfuscateFields.Text = "Obfuscate fields";
            this.chkObfuscateFields.UseVisualStyleBackColor = true;
            // 
            // chkObfuscateProperties
            // 
            this.chkObfuscateProperties.AutoSize = true;
            this.chkObfuscateProperties.Checked = true;
            this.chkObfuscateProperties.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateProperties.Location = new System.Drawing.Point(8, 98);
            this.chkObfuscateProperties.Name = "chkObfuscateProperties";
            this.chkObfuscateProperties.Size = new System.Drawing.Size(144, 16);
            this.chkObfuscateProperties.TabIndex = 3;
            this.chkObfuscateProperties.Text = "Obfuscate properties";
            this.chkObfuscateProperties.UseVisualStyleBackColor = true;
            // 
            // chkObfuscateNamespaces
            // 
            this.chkObfuscateNamespaces.AutoSize = true;
            this.chkObfuscateNamespaces.Checked = true;
            this.chkObfuscateNamespaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateNamespaces.Location = new System.Drawing.Point(8, 77);
            this.chkObfuscateNamespaces.Name = "chkObfuscateNamespaces";
            this.chkObfuscateNamespaces.Size = new System.Drawing.Size(144, 16);
            this.chkObfuscateNamespaces.TabIndex = 2;
            this.chkObfuscateNamespaces.Text = "Obfuscate namespaces";
            this.chkObfuscateNamespaces.UseVisualStyleBackColor = true;
            // 
            // chkObfuscateMethods
            // 
            this.chkObfuscateMethods.AutoSize = true;
            this.chkObfuscateMethods.Checked = true;
            this.chkObfuscateMethods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateMethods.Location = new System.Drawing.Point(8, 39);
            this.chkObfuscateMethods.Name = "chkObfuscateMethods";
            this.chkObfuscateMethods.Size = new System.Drawing.Size(126, 16);
            this.chkObfuscateMethods.TabIndex = 1;
            this.chkObfuscateMethods.Text = "Obfuscate methods";
            this.chkObfuscateMethods.UseVisualStyleBackColor = true;
            // 
            // chkObfuscateTypes
            // 
            this.chkObfuscateTypes.AutoSize = true;
            this.chkObfuscateTypes.Checked = true;
            this.chkObfuscateTypes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateTypes.Location = new System.Drawing.Point(8, 18);
            this.chkObfuscateTypes.Name = "chkObfuscateTypes";
            this.chkObfuscateTypes.Size = new System.Drawing.Size(324, 16);
            this.chkObfuscateTypes.TabIndex = 0;
            this.chkObfuscateTypes.Text = "Obfuscate types (classes/interfaces/enums/structs)";
            this.chkObfuscateTypes.UseVisualStyleBackColor = true;
            // 
            // btnNETSDKPath
            // 
            this.btnNETSDKPath.Location = new System.Drawing.Point(656, 42);
            this.btnNETSDKPath.Name = "btnNETSDKPath";
            this.btnNETSDKPath.Size = new System.Drawing.Size(27, 21);
            this.btnNETSDKPath.TabIndex = 5;
            this.btnNETSDKPath.Text = "...";
            this.btnNETSDKPath.UseVisualStyleBackColor = true;
            this.btnNETSDKPath.Click += new System.EventHandler(this.btnNETSDKPath_Click);
            // 
            // btnNETFrameworkPath
            // 
            this.btnNETFrameworkPath.Location = new System.Drawing.Point(656, 12);
            this.btnNETFrameworkPath.Name = "btnNETFrameworkPath";
            this.btnNETFrameworkPath.Size = new System.Drawing.Size(27, 21);
            this.btnNETFrameworkPath.TabIndex = 4;
            this.btnNETFrameworkPath.Text = "...";
            this.btnNETFrameworkPath.UseVisualStyleBackColor = true;
            this.btnNETFrameworkPath.Click += new System.EventHandler(this.btnNETFrameworkPath_Click);
            // 
            // txtNETSDKPath
            // 
            this.txtNETSDKPath.Location = new System.Drawing.Point(133, 43);
            this.txtNETSDKPath.Name = "txtNETSDKPath";
            this.txtNETSDKPath.Size = new System.Drawing.Size(517, 21);
            this.txtNETSDKPath.TabIndex = 3;
            // 
            // txtNETFrameworkPath
            // 
            this.txtNETFrameworkPath.Location = new System.Drawing.Point(133, 14);
            this.txtNETFrameworkPath.Name = "txtNETFrameworkPath";
            this.txtNETFrameworkPath.Size = new System.Drawing.Size(517, 21);
            this.txtNETFrameworkPath.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "NET SDK path :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "NET Framework path :";
            // 
            // tabCPlusPlusSetting
            // 
            this.tabCPlusPlusSetting.Controls.Add(this.btnBrowCLCommand);
            this.tabCPlusPlusSetting.Controls.Add(this.btnBrowIncludeFile);
            this.tabCPlusPlusSetting.Controls.Add(this.txtCLCommandPath);
            this.tabCPlusPlusSetting.Controls.Add(this.txtCPlusPlusInclude);
            this.tabCPlusPlusSetting.Controls.Add(this.label4);
            this.tabCPlusPlusSetting.Controls.Add(this.label5);
            this.tabCPlusPlusSetting.Location = new System.Drawing.Point(4, 22);
            this.tabCPlusPlusSetting.Name = "tabCPlusPlusSetting";
            this.tabCPlusPlusSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabCPlusPlusSetting.Size = new System.Drawing.Size(722, 332);
            this.tabCPlusPlusSetting.TabIndex = 5;
            this.tabCPlusPlusSetting.Text = "C++ Setting";
            this.tabCPlusPlusSetting.UseVisualStyleBackColor = true;
            // 
            // btnBrowCLCommand
            // 
            this.btnBrowCLCommand.Location = new System.Drawing.Point(655, 59);
            this.btnBrowCLCommand.Name = "btnBrowCLCommand";
            this.btnBrowCLCommand.Size = new System.Drawing.Size(27, 21);
            this.btnBrowCLCommand.TabIndex = 11;
            this.btnBrowCLCommand.Text = "...";
            this.btnBrowCLCommand.UseVisualStyleBackColor = true;
            this.btnBrowCLCommand.Click += new System.EventHandler(this.btnBrowCLCommand_Click);
            // 
            // btnBrowIncludeFile
            // 
            this.btnBrowIncludeFile.Location = new System.Drawing.Point(655, 29);
            this.btnBrowIncludeFile.Name = "btnBrowIncludeFile";
            this.btnBrowIncludeFile.Size = new System.Drawing.Size(27, 21);
            this.btnBrowIncludeFile.TabIndex = 10;
            this.btnBrowIncludeFile.Text = "...";
            this.btnBrowIncludeFile.UseVisualStyleBackColor = true;
            this.btnBrowIncludeFile.Click += new System.EventHandler(this.btnBrowIncludeFile_Click);
            // 
            // txtCLCommandPath
            // 
            this.txtCLCommandPath.Location = new System.Drawing.Point(132, 60);
            this.txtCLCommandPath.Name = "txtCLCommandPath";
            this.txtCLCommandPath.Size = new System.Drawing.Size(517, 21);
            this.txtCLCommandPath.TabIndex = 9;
            // 
            // txtCPlusPlusInclude
            // 
            this.txtCPlusPlusInclude.Location = new System.Drawing.Point(132, 31);
            this.txtCPlusPlusInclude.Name = "txtCPlusPlusInclude";
            this.txtCPlusPlusInclude.Size = new System.Drawing.Size(517, 21);
            this.txtCPlusPlusInclude.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "C++ VS Command Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "C++ Include Path:";
            // 
            // tabPageAssemblies
            // 
            this.tabPageAssemblies.Controls.Add(this.tvAssemblies);
            this.tabPageAssemblies.Controls.Add(this.tsAssemblies);
            this.tabPageAssemblies.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssemblies.Name = "tabPageAssemblies";
            this.tabPageAssemblies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssemblies.Size = new System.Drawing.Size(722, 332);
            this.tabPageAssemblies.TabIndex = 0;
            this.tabPageAssemblies.Text = "Assemblies";
            this.tabPageAssemblies.UseVisualStyleBackColor = true;
            // 
            // tvAssemblies
            // 
            this.tvAssemblies.CheckBoxes = true;
            this.tvAssemblies.ContextMenuStrip = this.cMenuSelect;
            this.tvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAssemblies.FullRowSelect = true;
            this.tvAssemblies.HotTracking = true;
            this.tvAssemblies.ImageIndex = 0;
            this.tvAssemblies.ImageList = this.ilAssemblies;
            this.tvAssemblies.Location = new System.Drawing.Point(3, 28);
            this.tvAssemblies.Name = "tvAssemblies";
            treeNode1.Checked = true;
            treeNode1.Name = "Node0";
            treeNode1.Text = "Assemblies";
            this.tvAssemblies.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvAssemblies.SelectedImageIndex = 0;
            this.tvAssemblies.Size = new System.Drawing.Size(716, 301);
            this.tvAssemblies.TabIndex = 1;
            this.tvAssemblies.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvAssemblies_BeforeCheck);
            this.tvAssemblies.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvAssemblies_AfterCheck);
            this.tvAssemblies.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAssemblies_AfterSelect);
            // 
            // cMenuSelect
            // 
            this.cMenuSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMenuCheckSelected,
            this.tSMenuUnCheckSelected,
            this.tSMenuReverse,
            this.toolStripSeparator3,
            this.viewICOToolStripMenuItem});
            this.cMenuSelect.Name = "cMenuSelect";
            this.cMenuSelect.Size = new System.Drawing.Size(137, 98);
            this.cMenuSelect.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuSelect_Opening);
            // 
            // tSMenuCheckSelected
            // 
            this.tSMenuCheckSelected.Name = "tSMenuCheckSelected";
            this.tSMenuCheckSelected.Size = new System.Drawing.Size(136, 22);
            this.tSMenuCheckSelected.Text = "勾选已选择";
            // 
            // tSMenuUnCheckSelected
            // 
            this.tSMenuUnCheckSelected.Name = "tSMenuUnCheckSelected";
            this.tSMenuUnCheckSelected.Size = new System.Drawing.Size(136, 22);
            this.tSMenuUnCheckSelected.Text = "取消选择";
            // 
            // tSMenuReverse
            // 
            this.tSMenuReverse.Name = "tSMenuReverse";
            this.tSMenuReverse.Size = new System.Drawing.Size(136, 22);
            this.tSMenuReverse.Text = "反选";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // viewICOToolStripMenuItem
            // 
            this.viewICOToolStripMenuItem.Name = "viewICOToolStripMenuItem";
            this.viewICOToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.viewICOToolStripMenuItem.Text = "ICO";
            this.viewICOToolStripMenuItem.Click += new System.EventHandler(this.viewICOToolStripMenuItem_Click);
            // 
            // ilAssemblies
            // 
            this.ilAssemblies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAssemblies.ImageStream")));
            this.ilAssemblies.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAssemblies.Images.SetKeyName(0, "DecompileMe.png");
            this.ilAssemblies.Images.SetKeyName(1, "assembly.png");
            this.ilAssemblies.Images.SetKeyName(2, "namespace.png");
            this.ilAssemblies.Images.SetKeyName(3, "type.png");
            this.ilAssemblies.Images.SetKeyName(4, "enum.png");
            // 
            // tsAssemblies
            // 
            this.tsAssemblies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAssembly,
            this.tsbRemoveAssembly});
            this.tsAssemblies.Location = new System.Drawing.Point(3, 3);
            this.tsAssemblies.Name = "tsAssemblies";
            this.tsAssemblies.Size = new System.Drawing.Size(716, 25);
            this.tsAssemblies.TabIndex = 0;
            this.tsAssemblies.Text = "toolStrip1";
            // 
            // tsbAddAssembly
            // 
            this.tsbAddAssembly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAssembly.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddAssembly.Image")));
            this.tsbAddAssembly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAssembly.Name = "tsbAddAssembly";
            this.tsbAddAssembly.Size = new System.Drawing.Size(23, 22);
            this.tsbAddAssembly.Text = "+";
            this.tsbAddAssembly.Click += new System.EventHandler(this.tsbAddAssembly_Click);
            // 
            // tsbRemoveAssembly
            // 
            this.tsbRemoveAssembly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveAssembly.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveAssembly.Image")));
            this.tsbRemoveAssembly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveAssembly.Name = "tsbRemoveAssembly";
            this.tsbRemoveAssembly.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveAssembly.Text = "-";
            this.tsbRemoveAssembly.Click += new System.EventHandler(this.tsbRemoveAssembly_Click);
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.txtOutput);
            this.tabPageOutput.Controls.Add(this.panel2);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(722, 332);
            this.tabPageOutput.TabIndex = 2;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(716, 298);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPhaseValue);
            this.panel2.Controls.Add(this.pbBuild);
            this.panel2.Controls.Add(this.lblPhase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 28);
            this.panel2.TabIndex = 1;
            // 
            // lblPhaseValue
            // 
            this.lblPhaseValue.AutoSize = true;
            this.lblPhaseValue.Location = new System.Drawing.Point(60, 8);
            this.lblPhaseValue.Name = "lblPhaseValue";
            this.lblPhaseValue.Size = new System.Drawing.Size(0, 12);
            this.lblPhaseValue.TabIndex = 2;
            // 
            // pbBuild
            // 
            this.pbBuild.Location = new System.Drawing.Point(304, 4);
            this.pbBuild.Name = "pbBuild";
            this.pbBuild.Size = new System.Drawing.Size(322, 21);
            this.pbBuild.TabIndex = 1;
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhase.Location = new System.Drawing.Point(5, 8);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(64, 13);
            this.lblPhase.TabIndex = 0;
            this.lblPhase.Text = "Progress :";
            // 
            // tabOutPutMapping
            // 
            this.tabOutPutMapping.Controls.Add(this.gridOutputMapping);
            this.tabOutPutMapping.Location = new System.Drawing.Point(4, 22);
            this.tabOutPutMapping.Name = "tabOutPutMapping";
            this.tabOutPutMapping.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutPutMapping.Size = new System.Drawing.Size(722, 332);
            this.tabOutPutMapping.TabIndex = 4;
            this.tabOutPutMapping.Text = "Output mapping";
            this.tabOutPutMapping.UseVisualStyleBackColor = true;
            // 
            // gridOutputMapping
            // 
            this.gridOutputMapping.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.gridOutputMapping.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.gridOutputMapping.ContextMenuStrip = this.cMenuRecord;
            this.gridOutputMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOutputMapping.FullRowSelect = true;
            this.gridOutputMapping.GridLines = true;
            this.gridOutputMapping.HoverSelection = true;
            this.gridOutputMapping.Location = new System.Drawing.Point(3, 3);
            this.gridOutputMapping.MultiSelect = false;
            this.gridOutputMapping.Name = "gridOutputMapping";
            this.gridOutputMapping.Size = new System.Drawing.Size(716, 326);
            this.gridOutputMapping.TabIndex = 0;
            this.gridOutputMapping.UseCompatibleStateImageBehavior = false;
            this.gridOutputMapping.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kind";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Initial name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Obfuscated name";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Notes";
            this.columnHeader4.Width = 300;
            // 
            // cMenuRecord
            // 
            this.cMenuRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave});
            this.cMenuRecord.Name = "cMenuRecord";
            this.cMenuRecord.Size = new System.Drawing.Size(116, 26);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemSave.Text = "保存(&S)";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.MainmenuStrip);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 418);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 25);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(730, 393);
            this.pnlContent.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBrowseBuildPath);
            this.panel1.Controls.Add(this.txtBuildPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 35);
            this.panel1.TabIndex = 4;
            // 
            // btnBrowseBuildPath
            // 
            this.btnBrowseBuildPath.Location = new System.Drawing.Point(659, 6);
            this.btnBrowseBuildPath.Name = "btnBrowseBuildPath";
            this.btnBrowseBuildPath.Size = new System.Drawing.Size(28, 21);
            this.btnBrowseBuildPath.TabIndex = 2;
            this.btnBrowseBuildPath.Text = "...";
            this.btnBrowseBuildPath.UseVisualStyleBackColor = true;
            this.btnBrowseBuildPath.Click += new System.EventHandler(this.btnBrowseBuildPath_Click);
            // 
            // txtBuildPath
            // 
            this.txtBuildPath.Location = new System.Drawing.Point(83, 8);
            this.txtBuildPath.Name = "txtBuildPath";
            this.txtBuildPath.Size = new System.Drawing.Size(570, 21);
            this.txtBuildPath.TabIndex = 1;
            this.txtBuildPath.Text = "D:\\temp\\_DecompileMe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Build path :";
            // 
            // MainmenuStrip
            // 
            this.MainmenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solutionsToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.MainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainmenuStrip.Name = "MainmenuStrip";
            this.MainmenuStrip.Size = new System.Drawing.Size(730, 25);
            this.MainmenuStrip.TabIndex = 5;
            this.MainmenuStrip.Text = "menuStrip1";
            // 
            // solutionsToolStripMenuItem
            // 
            this.solutionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewtoolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.RecentFiletoolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.solutionsToolStripMenuItem.Name = "solutionsToolStripMenuItem";
            this.solutionsToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.solutionsToolStripMenuItem.Text = "S&olutions";
            // 
            // NewtoolStripMenuItem
            // 
            this.NewtoolStripMenuItem.Name = "NewtoolStripMenuItem";
            this.NewtoolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.NewtoolStripMenuItem.Text = "&New";
            this.NewtoolStripMenuItem.Click += new System.EventHandler(this.NewtoolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.loadToolStripMenuItem.Text = "&Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // RecentFiletoolStripMenuItem
            // 
            this.RecentFiletoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.RecentFiletoolStripMenuItem.Name = "RecentFiletoolStripMenuItem";
            this.RecentFiletoolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.RecentFiletoolStripMenuItem.Text = "&Recent";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(112, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toGenerateToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.generateToolStripMenuItem.Text = "&Generate";
            // 
            // toGenerateToolStripMenuItem
            // 
            this.toGenerateToolStripMenuItem.Name = "toGenerateToolStripMenuItem";
            this.toGenerateToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toGenerateToolStripMenuItem.Text = "&Do Generate";
            this.toGenerateToolStripMenuItem.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tmrClose
            // 
            this.tmrClose.Enabled = true;
            this.tmrClose.Tick += new System.EventHandler(this.tmrClose_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainmenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "DecompileMe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.tabCPlusPlusSetting.ResumeLayout(false);
            this.tabCPlusPlusSetting.PerformLayout();
            this.tabPageAssemblies.ResumeLayout(false);
            this.tabPageAssemblies.PerformLayout();
            this.cMenuSelect.ResumeLayout(false);
            this.tsAssemblies.ResumeLayout(false);
            this.tsAssemblies.PerformLayout();
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabOutPutMapping.ResumeLayout(false);
            this.cMenuRecord.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainmenuStrip.ResumeLayout(false);
            this.MainmenuStrip.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageAssemblies;
        private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel panel1;
		private CHTSkin.ButtonExs.ButtonEx btnBrowseBuildPath;
		private System.Windows.Forms.TextBox txtBuildPath;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView tvAssemblies;
		private System.Windows.Forms.ToolStrip tsAssemblies;
		private System.Windows.Forms.ToolStripButton tsbAddAssembly;
		private System.Windows.Forms.ToolStripButton tsbRemoveAssembly;
		private System.Windows.Forms.TabPage tabPageOutput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.TabPage tabPageSettings;
		private System.Windows.Forms.GroupBox gbxOptions;
		private CHTSkin.ButtonExs.ButtonEx btnNETSDKPath;
		private CHTSkin.ButtonExs.ButtonEx btnNETFrameworkPath;
		private System.Windows.Forms.MaskedTextBox txtNETSDKPath;
		private System.Windows.Forms.MaskedTextBox txtNETFrameworkPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkObfuscateMethods;
		private System.Windows.Forms.CheckBox chkObfuscateTypes;
		private System.Windows.Forms.TabPage tabOutPutMapping;
		private System.Windows.Forms.ListView gridOutputMapping;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ProgressBar pbBuild;
		private System.Windows.Forms.Label lblPhase;
		private System.Windows.Forms.Label lblPhaseValue;
		private System.Windows.Forms.ImageList ilAssemblies;
		private System.Windows.Forms.CheckBox chkObfuscateProperties;
        private System.Windows.Forms.CheckBox chkObfuscateNamespaces;
        private System.Windows.Forms.CheckBox chkObfuscateFields;
        private System.Windows.Forms.MenuStrip MainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem solutionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGenerateToolStripMenuItem;
        private System.Windows.Forms.Timer tmrClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RecentFiletoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewtoolStripMenuItem;
        private System.Windows.Forms.TabPage tabCPlusPlusSetting;
        private CHTSkin.ButtonExs.ButtonEx btnBrowCLCommand;
        private CHTSkin.ButtonExs.ButtonEx btnBrowIncludeFile;
        private System.Windows.Forms.MaskedTextBox txtCLCommandPath;
        private System.Windows.Forms.MaskedTextBox txtCPlusPlusInclude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cMenuSelect;
        private System.Windows.Forms.ToolStripMenuItem tSMenuCheckSelected;
        private System.Windows.Forms.ToolStripMenuItem tSMenuUnCheckSelected;
        private System.Windows.Forms.ToolStripMenuItem tSMenuReverse;
        private System.Windows.Forms.ContextMenuStrip cMenuRecord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.CheckBox chkAssBase64;
        private System.Windows.Forms.CheckBox chkObEncriptAssembly;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem viewICOToolStripMenuItem;
	}
}

