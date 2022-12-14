
namespace FormTasarım
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxRegister = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.OpenHomeForm = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbxRegister
            // 
            this.tbxRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.tbxRegister.Image = ((System.Drawing.Image)(resources.GetObject("tbxRegister.Image")));
            this.tbxRegister.ImageActive = null;
            this.tbxRegister.Location = new System.Drawing.Point(399, 253);
            this.tbxRegister.Name = "tbxRegister";
            this.tbxRegister.Size = new System.Drawing.Size(184, 41);
            this.tbxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tbxRegister.TabIndex = 11;
            this.tbxRegister.TabStop = false;
            this.tbxRegister.Zoom = 10;
            this.tbxRegister.Click += new System.EventHandler(this.tbxRegister_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(399, 180);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(184, 38);
            this.tbxPassword.TabIndex = 10;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(399, 124);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(184, 38);
            this.tbxName.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(305, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 32);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Şifre";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(217, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(173, 32);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Kullanıcı Adı";
            // 
            // OpenHomeForm
            // 
            this.OpenHomeForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OpenHomeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenHomeForm.BackColor = System.Drawing.Color.Blue;
            this.OpenHomeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenHomeForm.BorderRadius = 0;
            this.OpenHomeForm.ButtonText = "Geri";
            this.OpenHomeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenHomeForm.DisabledColor = System.Drawing.Color.Gray;
            this.OpenHomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenHomeForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenHomeForm.Iconcolor = System.Drawing.Color.Transparent;
            this.OpenHomeForm.Iconimage = ((System.Drawing.Image)(resources.GetObject("OpenHomeForm.Iconimage")));
            this.OpenHomeForm.Iconimage_right = null;
            this.OpenHomeForm.Iconimage_right_Selected = null;
            this.OpenHomeForm.Iconimage_Selected = null;
            this.OpenHomeForm.IconMarginLeft = 0;
            this.OpenHomeForm.IconMarginRight = 0;
            this.OpenHomeForm.IconRightVisible = true;
            this.OpenHomeForm.IconRightZoom = 0D;
            this.OpenHomeForm.IconVisible = true;
            this.OpenHomeForm.IconZoom = 90D;
            this.OpenHomeForm.IsTab = false;
            this.OpenHomeForm.Location = new System.Drawing.Point(0, 14);
            this.OpenHomeForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OpenHomeForm.Name = "OpenHomeForm";
            this.OpenHomeForm.Normalcolor = System.Drawing.Color.Blue;
            this.OpenHomeForm.OnHovercolor = System.Drawing.Color.Blue;
            this.OpenHomeForm.OnHoverTextColor = System.Drawing.Color.White;
            this.OpenHomeForm.selected = false;
            this.OpenHomeForm.Size = new System.Drawing.Size(218, 66);
            this.OpenHomeForm.TabIndex = 14;
            this.OpenHomeForm.Text = "Geri";
            this.OpenHomeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenHomeForm.Textcolor = System.Drawing.Color.White;
            this.OpenHomeForm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenHomeForm.Click += new System.EventHandler(this.OpenHomeForm_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 388);
            this.Controls.Add(this.OpenHomeForm);
            this.Controls.Add(this.tbxRegister);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekleme";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton tbxRegister;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuFlatButton OpenHomeForm;
    }
}