
namespace FormDesign
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOpenProductForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxCategoryNameUpdate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnUpdateCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCategoryName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dqwCategory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkRed;
            this.bunifuCards1.Controls.Add(this.btnDelete);
            this.bunifuCards1.Controls.Add(this.btnOpenProductForm);
            this.bunifuCards1.Controls.Add(this.groupBox2);
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.Controls.Add(this.dqwCategory);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1302, 749);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Sil";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btnDelete.Location = new System.Drawing.Point(1074, 109);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Red;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Red;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(218, 66);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnOpenProductForm
            // 
            this.btnOpenProductForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOpenProductForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenProductForm.BackColor = System.Drawing.Color.Blue;
            this.btnOpenProductForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenProductForm.BorderRadius = 0;
            this.btnOpenProductForm.ButtonText = "Geri";
            this.btnOpenProductForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenProductForm.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenProductForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenProductForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenProductForm.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenProductForm.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOpenProductForm.Iconimage")));
            this.btnOpenProductForm.Iconimage_right = null;
            this.btnOpenProductForm.Iconimage_right_Selected = null;
            this.btnOpenProductForm.Iconimage_Selected = null;
            this.btnOpenProductForm.IconMarginLeft = 0;
            this.btnOpenProductForm.IconMarginRight = 0;
            this.btnOpenProductForm.IconRightVisible = true;
            this.btnOpenProductForm.IconRightZoom = 0D;
            this.btnOpenProductForm.IconVisible = true;
            this.btnOpenProductForm.IconZoom = 90D;
            this.btnOpenProductForm.IsTab = false;
            this.btnOpenProductForm.Location = new System.Drawing.Point(28, 24);
            this.btnOpenProductForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOpenProductForm.Name = "btnOpenProductForm";
            this.btnOpenProductForm.Normalcolor = System.Drawing.Color.Blue;
            this.btnOpenProductForm.OnHovercolor = System.Drawing.Color.Blue;
            this.btnOpenProductForm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenProductForm.selected = false;
            this.btnOpenProductForm.Size = new System.Drawing.Size(218, 66);
            this.btnOpenProductForm.TabIndex = 14;
            this.btnOpenProductForm.Text = "Geri";
            this.btnOpenProductForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpenProductForm.Textcolor = System.Drawing.Color.White;
            this.btnOpenProductForm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenProductForm.Click += new System.EventHandler(this.btnOpenProductForm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tbxCategoryNameUpdate);
            this.groupBox2.Controls.Add(this.btnUpdateCategory);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox2.Location = new System.Drawing.Point(595, 420);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(467, 272);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori Güncelle";
            // 
            // tbxCategoryNameUpdate
            // 
            this.tbxCategoryNameUpdate.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbxCategoryNameUpdate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCategoryNameUpdate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbxCategoryNameUpdate.BorderThickness = 3;
            this.tbxCategoryNameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCategoryNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxCategoryNameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCategoryNameUpdate.isPassword = false;
            this.tbxCategoryNameUpdate.Location = new System.Drawing.Point(184, 75);
            this.tbxCategoryNameUpdate.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbxCategoryNameUpdate.Name = "tbxCategoryNameUpdate";
            this.tbxCategoryNameUpdate.Size = new System.Drawing.Size(263, 38);
            this.tbxCategoryNameUpdate.TabIndex = 14;
            this.tbxCategoryNameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateCategory.BorderRadius = 0;
            this.btnUpdateCategory.ButtonText = "Güncelle";
            this.btnUpdateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnUpdateCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCategory.Iconimage")));
            this.btnUpdateCategory.Iconimage_right = null;
            this.btnUpdateCategory.Iconimage_right_Selected = null;
            this.btnUpdateCategory.Iconimage_Selected = null;
            this.btnUpdateCategory.IconMarginLeft = 0;
            this.btnUpdateCategory.IconMarginRight = 0;
            this.btnUpdateCategory.IconRightVisible = true;
            this.btnUpdateCategory.IconRightZoom = 0D;
            this.btnUpdateCategory.IconVisible = true;
            this.btnUpdateCategory.IconZoom = 90D;
            this.btnUpdateCategory.IsTab = false;
            this.btnUpdateCategory.Location = new System.Drawing.Point(184, 148);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateCategory.selected = false;
            this.btnUpdateCategory.Size = new System.Drawing.Size(264, 47);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Güncelle";
            this.btnUpdateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateCategory.Textcolor = System.Drawing.Color.White;
            this.btnUpdateCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 75);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(154, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Kategori İsmi";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tbxCategoryName);
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(28, 420);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(456, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Düzenle";
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbxCategoryName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCategoryName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbxCategoryName.BorderThickness = 3;
            this.tbxCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCategoryName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCategoryName.isPassword = false;
            this.tbxCategoryName.Location = new System.Drawing.Point(180, 75);
            this.tbxCategoryName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(263, 38);
            this.tbxCategoryName.TabIndex = 14;
            this.tbxCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCategory.BorderRadius = 0;
            this.btnAddCategory.ButtonText = "Ekle";
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnAddCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Iconimage")));
            this.btnAddCategory.Iconimage_right = null;
            this.btnAddCategory.Iconimage_right_Selected = null;
            this.btnAddCategory.Iconimage_Selected = null;
            this.btnAddCategory.IconMarginLeft = 0;
            this.btnAddCategory.IconMarginRight = 0;
            this.btnAddCategory.IconRightVisible = true;
            this.btnAddCategory.IconRightZoom = 0D;
            this.btnAddCategory.IconVisible = true;
            this.btnAddCategory.IconZoom = 90D;
            this.btnAddCategory.IsTab = false;
            this.btnAddCategory.Location = new System.Drawing.Point(180, 148);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCategory.selected = false;
            this.btnAddCategory.Size = new System.Drawing.Size(263, 47);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Ekle";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCategory.Textcolor = System.Drawing.Color.White;
            this.btnAddCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCategory.Location = new System.Drawing.Point(9, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(154, 29);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori İsmi";
            // 
            // dqwCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dqwCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dqwCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwCategory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dqwCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dqwCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dqwCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dqwCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwCategory.DoubleBuffered = true;
            this.dqwCategory.EnableHeadersVisualStyles = false;
            this.dqwCategory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dqwCategory.HeaderForeColor = System.Drawing.Color.White;
            this.dqwCategory.Location = new System.Drawing.Point(28, 109);
            this.dqwCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dqwCategory.Name = "dqwCategory";
            this.dqwCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dqwCategory.RowHeadersWidth = 51;
            this.dqwCategory.RowTemplate.Height = 24;
            this.dqwCategory.Size = new System.Drawing.Size(1034, 301);
            this.dqwCategory.TabIndex = 1;
            this.dqwCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwCategory_CellClick);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dqwCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCategory;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxCategoryNameUpdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxCategoryName;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenProductForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
    }
}