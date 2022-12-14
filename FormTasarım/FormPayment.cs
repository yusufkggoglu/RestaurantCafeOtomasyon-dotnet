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
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace FormTasarım
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
            _paymentService = new PaymentManager(new EfPaymentDal());
        }

        private IPaymentService _paymentService;
        private void FormPayment_Load(object sender, EventArgs e)
        {
            LoadPayments();
            tbxSumPrice.Text = GetSumPrice();
        }

        private string GetSumPrice()
        {
            var list = _paymentService.GetAll();
            decimal price = 0;
            foreach (var temp in list)
            {
                price += Convert.ToDecimal(temp.Price);
            }

            return price.ToString();
        }

        private void LoadPayments()
        {
            dqwPayment.DataSource = _paymentService.GetAll();
        }

        private void OpenHomeForm_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm();
            frm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var list = _paymentService.GetAll();
            foreach (var temp in list)
            {
                _paymentService.Delete(temp);
            }
            LoadPayments();
        }
    }
}
