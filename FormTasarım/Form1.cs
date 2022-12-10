using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace FormDesign
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        IProductService _productService;
        ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryID";


        }

        private void LoadProducts()
        {
            dqwProduct.DataSource = _productService.GetAll();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryID = Convert.ToInt32(cbxCategory.SelectedValue),
                ProductName = tbxProductName.Text,
                Price = Convert.ToDecimal(tbxProductPrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün Eklendi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductID = Convert.ToInt32(dqwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpdate.Text,
                CategoryID = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                Price = Convert.ToDecimal(tbxPriceUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün Güncellendi!");
        }

        private void dqwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxCategoryUpdate.SelectedValue = dqwProduct.CurrentRow.Cells[1].Value;
            tbxProductNameUpdate.Text = dqwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxPriceUpdate.Text = dqwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductID = Convert.ToInt32(dqwProduct.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Ürün Silindi!");
        }

        private void btnOpenFormCategory_Click(object sender, EventArgs e)
        {
            FormCategory frm = new FormCategory();
            frm.Show();
            this.Hide();
        }
    }
}
