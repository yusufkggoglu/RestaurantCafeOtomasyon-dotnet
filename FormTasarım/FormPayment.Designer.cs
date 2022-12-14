
namespace FormTasarım
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.OpenHomeForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dqwPayment = new System.Windows.Forms.DataGridView();
            this.lblSum = new System.Windows.Forms.Label();
            this.tbxSumPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkRed;
            this.bunifuCards1.Controls.Add(this.btnDelete);
            this.bunifuCards1.Controls.Add(this.tbxSumPrice);
            this.bunifuCards1.Controls.Add(this.lblSum);
            this.bunifuCards1.Controls.Add(this.OpenHomeForm);
            this.bunifuCards1.Controls.Add(this.dqwPayment);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1304, 712);
            this.bunifuCards1.TabIndex = 0;
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
            this.OpenHomeForm.Location = new System.Drawing.Point(35, 14);
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
            // dqwPayment
            // 
            this.dqwPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwPayment.Location = new System.Drawing.Point(35, 98);
            this.dqwPayment.Name = "dqwPayment";
            this.dqwPayment.RowHeadersWidth = 51;
            this.dqwPayment.RowTemplate.Height = 24;
            this.dqwPayment.Size = new System.Drawing.Size(1230, 497);
            this.dqwPayment.TabIndex = 1;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(936, 621);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(131, 39);
            this.lblSum.TabIndex = 15;
            this.lblSum.Text = "Toplam";
            // 
            // tbxSumPrice
            // 
            this.tbxSumPrice.Enabled = false;
            this.tbxSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSumPrice.Location = new System.Drawing.Point(1073, 615);
            this.tbxSumPrice.Name = "tbxSumPrice";
            this.tbxSumPrice.Size = new System.Drawing.Size(173, 45);
            this.tbxSumPrice.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Temizle";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(1039, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Red;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Red;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(226, 66);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Temizle";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 712);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Geçmişi";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.DataGridView dqwPayment;
        private Bunifu.Framework.UI.BunifuFlatButton OpenHomeForm;
        private System.Windows.Forms.TextBox tbxSumPrice;
        private System.Windows.Forms.Label lblSum;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
    }
}