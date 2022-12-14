using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormProduct;

namespace FormTasarım
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void OpenTables_Click(object sender, EventArgs e)
        {
            FormTable frm = new FormTable();
            frm.Show();
            this.Hide();
        }

        private void OpenProducts_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
            this.Hide();
        }

        private void OpenPayments_Click(object sender, EventArgs e)
        {
            FormPayment frm = new FormPayment();
            frm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormUser frm = new FormUser();
            frm.Show();
            this.Hide();
        }
    }
}
