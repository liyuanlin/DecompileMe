using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHTSkin.SkinForms;
using System.IO;

namespace DecompileMe
{
    public partial class frmExeICON : SkinForm
    {
        public frmExeICON()
        {
            InitializeComponent();
        }
        public Bitmap GetBitmap(Icon icon)
        {

            Bitmap bmp = new Bitmap(icon.Width, icon.Height);

            //Create temporary graphics

            Graphics gxMem = Graphics.FromImage(bmp);

            //Draw the icon

            gxMem.DrawIcon(icon, 0, 0);

            //Clean up

            gxMem.Dispose();

            return bmp;

        }


        public DialogResult ShowDr()
        {
            string pOldIconPath = SoftConfig.AssemblyExeIcon;
            if (File.Exists(pOldIconPath))
            {
                txtICONPath.Text = pOldIconPath;
                picICONView.Image = GetBitmap(new Icon(pOldIconPath));
            }
            return ShowDialog();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtICONPath.Text) && picICONView.Image != null)
            {
                this.Tag = txtICONPath.Text;
                SoftConfig.AssemblyExeIcon = txtICONPath.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "icon files (*.ico)|*.ico";
            dialog.RestoreDirectory = true;
            if (SoftConfig.AssemblyExeIcon != string.Empty)
            {
                dialog.InitialDirectory =Path.GetDirectoryName( SoftConfig.AssemblyExeIcon);
            }
            DialogResult result = dialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            txtICONPath.Text = dialog.FileName;
            picICONView.Image = GetBitmap(new Icon(dialog.FileName));
        }
    }
}
