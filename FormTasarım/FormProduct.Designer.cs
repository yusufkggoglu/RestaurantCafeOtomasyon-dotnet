
namespace FormProduct
{
    partial class ProductForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxProductPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbxProductName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblProductName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblProductPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dqwProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.OpenHomeForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOpenFormCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxPriceUpdate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbxProductNameUpdate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblProductName2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCategory2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrice2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwProduct)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.tbxProductPrice);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblProductPrice);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 358);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(433, 312);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(167, 135);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(229, 37);
            this.cbxCategory.TabIndex = 14;
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbxProductPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductPrice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbxProductPrice.BorderThickness = 3;
            this.tbxProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProductPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductPrice.isPassword = false;
            this.tbxProductPrice.Location = new System.Drawing.Point(166, 190);
            this.tbxProductPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.Size = new System.Drawing.Size(230, 36);
            this.tbxProductPrice.TabIndex = 13;
            this.tbxProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxProductName
            // 
            this.tbxProductName.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbxProductName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbxProductName.BorderThickness = 3;
            this.tbxProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductName.isPassword = false;
            this.tbxProductName.Location = new System.Drawing.Point(167, 74);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(230, 36);
            this.tbxProductName.TabIndex = 9;
            this.tbxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(20, 74);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(114, 29);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Ürün İsmi";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(20, 135);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(104, 29);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Kategori";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.Location = new System.Drawing.Point(20, 197);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(64, 29);
            this.lblProductPrice.TabIndex = 8;
            this.lblProductPrice.Text = "Fiyat";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddProduct.BorderRadius = 0;
            this.btnAddProduct.ButtonText = "Ekle";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Iconimage")));
            this.btnAddProduct.Iconimage_right = null;
            this.btnAddProduct.Iconimage_right_Selected = null;
            this.btnAddProduct.Iconimage_Selected = null;
            this.btnAddProduct.IconMarginLeft = 0;
            this.btnAddProduct.IconMarginRight = 0;
            this.btnAddProduct.IconRightVisible = true;
            this.btnAddProduct.IconRightZoom = 0D;
            this.btnAddProduct.IconVisible = true;
            this.btnAddProduct.IconZoom = 90D;
            this.btnAddProduct.IsTab = false;
            this.btnAddProduct.Location = new System.Drawing.Point(167, 250);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(229, 44);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Ekle";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Textcolor = System.Drawing.Color.White;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dqwProduct
            // 
            this.dqwProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dqwProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dqwProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dqwProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dqwProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dqwProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dqwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwProduct.DoubleBuffered = true;
            this.dqwProduct.EnableHeadersVisualStyles = false;
            this.dqwProduct.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dqwProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dqwProduct.Location = new System.Drawing.Point(12, 81);
            this.dqwProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dqwProduct.Name = "dqwProduct";
            this.dqwProduct.ReadOnly = true;
            this.dqwProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dqwProduct.RowHeadersWidth = 51;
            this.dqwProduct.RowTemplate.Height = 24;
            this.dqwProduct.Size = new System.Drawing.Size(1036, 263);
            this.dqwProduct.TabIndex = 13;
            this.dqwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwProduct_CellClick);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkGreen;
            this.bunifuCards1.Controls.Add(this.OpenHomeForm);
            this.bunifuCards1.Controls.Add(this.btnOpenFormCategory);
            this.bunifuCards1.Controls.Add(this.btnDelete);
            this.bunifuCards1.Controls.Add(this.groupBox2);
            this.bunifuCards1.Controls.Add(this.dqwProduct);
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1304, 712);
            this.bunifuCards1.TabIndex = 1;
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
            this.OpenHomeForm.Location = new System.Drawing.Point(14, 9);
            this.OpenHomeForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OpenHomeForm.Name = "OpenHomeForm";
            this.OpenHomeForm.Normalcolor = System.Drawing.Color.Blue;
            this.OpenHomeForm.OnHovercolor = System.Drawing.Color.Blue;
            this.OpenHomeForm.OnHoverTextColor = System.Drawing.Color.White;
            this.OpenHomeForm.selected = false;
            this.OpenHomeForm.Size = new System.Drawing.Size(218, 66);
            this.OpenHomeForm.TabIndex = 19;
            this.OpenHomeForm.Text = "Geri";
            this.OpenHomeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenHomeForm.Textcolor = System.Drawing.Color.White;
            this.OpenHomeForm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenHomeForm.Click += new System.EventHandler(this.OpenHomeForm_Click);
            // 
            // btnOpenFormCategory
            // 
            this.btnOpenFormCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOpenFormCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFormCategory.BackColor = System.Drawing.Color.Blue;
            this.btnOpenFormCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFormCategory.BorderRadius = 0;
            this.btnOpenFormCategory.ButtonText = "Kategorileri Düzenle";
            this.btnOpenFormCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFormCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenFormCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenFormCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenFormCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOpenFormCategory.Iconimage")));
            this.btnOpenFormCategory.Iconimage_right = null;
            this.btnOpenFormCategory.Iconimage_right_Selected = null;
            this.btnOpenFormCategory.Iconimage_Selected = null;
            this.btnOpenFormCategory.IconMarginLeft = 0;
            this.btnOpenFormCategory.IconMarginRight = 0;
            this.btnOpenFormCategory.IconRightVisible = true;
            this.btnOpenFormCategory.IconRightZoom = 0D;
            this.btnOpenFormCategory.IconVisible = true;
            this.btnOpenFormCategory.IconZoom = 90D;
            this.btnOpenFormCategory.IsTab = false;
            this.btnOpenFormCategory.Location = new System.Drawing.Point(1059, 177);
            this.btnOpenFormCategory.Margin = new System.Windows.Forms.Padding(8);
            this.btnOpenFormCategory.Name = "btnOpenFormCategory";
            this.btnOpenFormCategory.Normalcolor = System.Drawing.Color.Blue;
            this.btnOpenFormCategory.OnHovercolor = System.Drawing.Color.Blue;
            this.btnOpenFormCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenFormCategory.selected = false;
            this.btnOpenFormCategory.Size = new System.Drawing.Size(218, 66);
            this.btnOpenFormCategory.TabIndex = 18;
            this.btnOpenFormCategory.Text = "Kategorileri Düzenle";
            this.btnOpenFormCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFormCategory.Textcolor = System.Drawing.Color.White;
            this.btnOpenFormCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenFormCategory.Click += new System.EventHandler(this.btnOpenFormCategory_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(1059, 81);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Red;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Red;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(218, 66);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cbxCategoryUpdate);
            this.groupBox2.Controls.Add(this.tbxPriceUpdate);
            this.groupBox2.Controls.Add(this.tbxProductNameUpdate);
            this.groupBox2.Controls.Add(this.lblProductName2);
            this.groupBox2.Controls.Add(this.lblCategory2);
            this.groupBox2.Controls.Add(this.lblPrice2);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(588, 358);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(450, 312);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(167, 135);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(229, 37);
            this.cbxCategoryUpdate.TabIndex = 14;
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbxPriceUpdate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPriceUpdate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbxPriceUpdate.BorderThickness = 3;
            this.tbxPriceUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPriceUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxPriceUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPriceUpdate.isPassword = false;
            this.tbxPriceUpdate.Location = new System.Drawing.Point(166, 190);
            this.tbxPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(230, 36);
            this.tbxPriceUpdate.TabIndex = 13;
            this.tbxPriceUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbxProductNameUpdate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductNameUpdate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbxProductNameUpdate.BorderThickness = 3;
            this.tbxProductNameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProductNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxProductNameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductNameUpdate.isPassword = false;
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(167, 74);
            this.tbxProductNameUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(230, 36);
            this.tbxProductNameUpdate.TabIndex = 9;
            this.tbxProductNameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName2.Location = new System.Drawing.Point(20, 74);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(114, 29);
            this.lblProductName2.TabIndex = 6;
            this.lblProductName2.Text = "Ürün İsmi";
            // 
            // lblCategory2
            // 
            this.lblCategory2.AutoSize = true;
            this.lblCategory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory2.Location = new System.Drawing.Point(20, 135);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(104, 29);
            this.lblCategory2.TabIndex = 10;
            this.lblCategory2.Text = "Kategori";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice2.Location = new System.Drawing.Point(20, 197);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(64, 29);
            this.lblPrice2.TabIndex = 8;
            this.lblPrice2.Text = "Fiyat";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Güncelle";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(166, 250);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(230, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1304, 712);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ayarları";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwProduct)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCategory;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxProductPrice;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxProductName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProductName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProductPrice;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dqwProduct;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxPriceUpdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxProductNameUpdate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProductName2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrice2;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenFormCategory;
        private Bunifu.Framework.UI.BunifuFlatButton OpenHomeForm;
    }
}

