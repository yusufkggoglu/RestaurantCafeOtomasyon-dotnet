
namespace FormDesign
{
    partial class FormTableScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCardPayment = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCashPayment = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenTablesForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dqwOrders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCardPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCashPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dqwOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DarkRed;
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.btnCardPayment);
            this.bunifuCards2.Controls.Add(this.btnCashPayment);
            this.bunifuCards2.Controls.Add(this.btnDelete);
            this.bunifuCards2.Controls.Add(this.tbxPrice);
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.OpenTablesForm);
            this.bunifuCards2.Controls.Add(this.dqwOrders);
            this.bunifuCards2.Controls.Add(this.flpProducts);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1304, 712);
            this.bunifuCards2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1063, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kredi Kartı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(946, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nakit";
            // 
            // btnCardPayment
            // 
            this.btnCardPayment.BackColor = System.Drawing.Color.White;
            this.btnCardPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnCardPayment.Image")));
            this.btnCardPayment.ImageActive = null;
            this.btnCardPayment.Location = new System.Drawing.Point(1056, 485);
            this.btnCardPayment.Name = "btnCardPayment";
            this.btnCardPayment.Size = new System.Drawing.Size(133, 105);
            this.btnCardPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCardPayment.TabIndex = 20;
            this.btnCardPayment.TabStop = false;
            this.btnCardPayment.Zoom = 10;
            this.btnCardPayment.Click += new System.EventHandler(this.btnCardPayment_Click);
            // 
            // btnCashPayment
            // 
            this.btnCashPayment.BackColor = System.Drawing.Color.White;
            this.btnCashPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnCashPayment.Image")));
            this.btnCashPayment.ImageActive = null;
            this.btnCashPayment.Location = new System.Drawing.Point(917, 485);
            this.btnCashPayment.Name = "btnCashPayment";
            this.btnCashPayment.Size = new System.Drawing.Size(133, 105);
            this.btnCashPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCashPayment.TabIndex = 19;
            this.btnCashPayment.TabStop = false;
            this.btnCashPayment.Zoom = 10;
            this.btnCashPayment.Click += new System.EventHandler(this.btnCashPayment_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(1074, 27);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Red;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Red;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(218, 66);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Enabled = false;
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPrice.Location = new System.Drawing.Point(927, 413);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(259, 38);
            this.tbxPrice.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(694, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ödenecek Tutar";
            // 
            // OpenTablesForm
            // 
            this.OpenTablesForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OpenTablesForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenTablesForm.BackColor = System.Drawing.Color.Blue;
            this.OpenTablesForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenTablesForm.BorderRadius = 0;
            this.OpenTablesForm.ButtonText = "Geri";
            this.OpenTablesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenTablesForm.DisabledColor = System.Drawing.Color.Gray;
            this.OpenTablesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenTablesForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenTablesForm.Iconcolor = System.Drawing.Color.Transparent;
            this.OpenTablesForm.Iconimage = ((System.Drawing.Image)(resources.GetObject("OpenTablesForm.Iconimage")));
            this.OpenTablesForm.Iconimage_right = null;
            this.OpenTablesForm.Iconimage_right_Selected = null;
            this.OpenTablesForm.Iconimage_Selected = null;
            this.OpenTablesForm.IconMarginLeft = 0;
            this.OpenTablesForm.IconMarginRight = 0;
            this.OpenTablesForm.IconRightVisible = true;
            this.OpenTablesForm.IconRightZoom = 0D;
            this.OpenTablesForm.IconVisible = true;
            this.OpenTablesForm.IconZoom = 90D;
            this.OpenTablesForm.IsTab = false;
            this.OpenTablesForm.Location = new System.Drawing.Point(36, 27);
            this.OpenTablesForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OpenTablesForm.Name = "OpenTablesForm";
            this.OpenTablesForm.Normalcolor = System.Drawing.Color.Blue;
            this.OpenTablesForm.OnHovercolor = System.Drawing.Color.Blue;
            this.OpenTablesForm.OnHoverTextColor = System.Drawing.Color.White;
            this.OpenTablesForm.selected = false;
            this.OpenTablesForm.Size = new System.Drawing.Size(218, 66);
            this.OpenTablesForm.TabIndex = 13;
            this.OpenTablesForm.Text = "Geri";
            this.OpenTablesForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenTablesForm.Textcolor = System.Drawing.Color.White;
            this.OpenTablesForm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenTablesForm.Click += new System.EventHandler(this.OpenTablesForm_Click);
            // 
            // dqwOrders
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dqwOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dqwOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwOrders.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dqwOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dqwOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dqwOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dqwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwOrders.DoubleBuffered = true;
            this.dqwOrders.EnableHeadersVisualStyles = false;
            this.dqwOrders.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dqwOrders.HeaderForeColor = System.Drawing.Color.White;
            this.dqwOrders.Location = new System.Drawing.Point(693, 117);
            this.dqwOrders.Name = "dqwOrders";
            this.dqwOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dqwOrders.RowHeadersWidth = 51;
            this.dqwOrders.RowTemplate.Height = 24;
            this.dqwOrders.Size = new System.Drawing.Size(597, 267);
            this.dqwOrders.TabIndex = 0;
            // 
            // flpProducts
            // 
            this.flpProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flpProducts.Location = new System.Drawing.Point(34, 117);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(627, 592);
            this.flpProducts.TabIndex = 2;
            // 
            // FormTableScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 712);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTableScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş ";
            this.Load += new System.EventHandler(this.FormTableScreen_Load);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCardPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCashPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dqwOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dqwOrders;
        private Bunifu.Framework.UI.BunifuFlatButton OpenTablesForm;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnCardPayment;
        private Bunifu.Framework.UI.BunifuImageButton btnCashPayment;
    }
}