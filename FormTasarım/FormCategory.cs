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
using FormDesign;

namespace FormDesign
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());

        }
        ICategoryService _categoryService;

        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dqwCategory.DataSource = _categoryService.GetAll();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            _categoryService.Add(new Category
            {
                CategoryName = tbxCategoryName.Text
            });
            LoadCategories();
            MessageBox.Show("Kategori Eklendi!");
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            _categoryService.Update(new Category
            {
                CategoryID = Convert.ToInt32(dqwCategory.CurrentRow.Cells[0].Value),
                CategoryName = tbxCategoryNameUpdate.Text,
            });
            LoadCategories();
            MessageBox.Show("Kategori Güncellendi!");
        }

        private void dqwCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCategoryNameUpdate.Text = dqwCategory.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _categoryService.Delete(new Category
            {
                CategoryID = Convert.ToInt32(dqwCategory.CurrentRow.Cells[0].Value)
            });
            LoadCategories();
            MessageBox.Show("Kategori Silindi!");
        }

        private void btnOpenProductForm_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
            this.Hide();
        }
    }
}
