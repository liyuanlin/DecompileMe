using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHTSkin.SkinForms;

namespace DecompileMe
{
	public partial class AssemblyPathDialog : SkinForm
	{
		public AssemblyPathDialog(string initialAssemblyPath)
		{
			InitializeComponent();

			txtAssemblyPath.Text = initialAssemblyPath;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "EXE files (*.exe)|*.exe|DLL files (*.dll)|*.dll|All files (*.*)|*.*";
			dialog.FilterIndex = 2;
			dialog.RestoreDirectory = true;
            dialog.InitialDirectory = SoftConfig.NETFrameworkPath;
			DialogResult result = dialog.ShowDialog(this);
			if (result != DialogResult.OK)
				return;

			txtAssemblyPath.Text = dialog.FileName;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (AssemblyPath == "")
			{
				MessageBox.Show("Please select an assembly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

            this.DialogResult = DialogResult.OK;
		}

		public string AssemblyPath
		{
			get
			{
				return txtAssemblyPath.Text.Trim(); ;
			}
		}
	}
}