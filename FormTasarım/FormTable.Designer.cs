
namespace FormTasarım
{
    partial class FormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenHomeForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(17, 99);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1273, 601);
            this.flpTable.TabIndex = 13;
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
            this.OpenHomeForm.Location = new System.Drawing.Point(17, 14);
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
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 10;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkRed;
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1304, 712);
            this.bunifuCards1.TabIndex = 15;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 712);
            this.Controls.Add(this.OpenHomeForm);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masalarım";
            this.Load += new System.EventHandler(this.FormTable_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Bunifu.Framework.UI.BunifuFlatButton OpenHomeForm;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
    }
}