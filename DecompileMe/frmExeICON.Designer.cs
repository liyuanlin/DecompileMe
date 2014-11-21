namespace DecompileMe
{
    partial class frmExeICON
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
            this.btnBrowse = new CHTSkin.ButtonExs.ButtonEx();
            this.btnOk = new CHTSkin.ButtonExs.ButtonEx();
            this.txtICONPath = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picICONView = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picICONView)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(352, 147);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(304, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtICONPath
            // 
            this.txtICONPath.Location = new System.Drawing.Point(76, 149);
            this.txtICONPath.Name = "txtICONPath";
            this.txtICONPath.Size = new System.Drawing.Size(270, 20);
            this.txtICONPath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "icon path :";
            // 
            // picICONView
            // 
            this.picICONView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picICONView.Location = new System.Drawing.Point(109, 4);
            this.picICONView.Name = "picICONView";
            this.picICONView.Size = new System.Drawing.Size(166, 139);
            this.picICONView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picICONView.TabIndex = 12;
            this.picICONView.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.txtICONPath);
            this.pnlMain.Controls.Add(this.picICONView);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.btnBrowse);
            this.pnlMain.Controls.Add(this.btnOk);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(418, 215);
            this.pnlMain.TabIndex = 13;
            // 
            // frmExeICON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 242);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExeICON";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "exe图标ICON设置";
            ((System.ComponentModel.ISupportInitialize)(this.picICONView)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CHTSkin.ButtonExs.ButtonEx btnBrowse;
        private CHTSkin.ButtonExs.ButtonEx btnOk;
        private System.Windows.Forms.MaskedTextBox txtICONPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picICONView;
        private System.Windows.Forms.Panel pnlMain;
    }
}