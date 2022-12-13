using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;
using FormTasarım;

namespace FormDesign
{
    public partial class FormTableScreen : Form
    {
        public int id;
        public FormTableScreen()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _orderService = new OrderManager(new EfOrderDal());
            _tableService = new TableManager(new EfTableDal());
            _paymentService = new PaymentManager(new EfPaymentDal());
        }
        IProductService _productService;
        IOrderService _orderService;
        ITableService _tableService;
        IPaymentService _paymentService;
        private void FormTableScreen_Load(object sender, EventArgs e)
        {
            GetProducts();
            GetOrderByTableId();
            GetPrice();
        }
        private void GetOrderByTableId()
        {
            dqwOrders.DataSource = _orderService.GetAll(id);
        }
        private void GetPrice()
        {
            var list = _orderService.GetAll(id);
            decimal price = 0;
            foreach (var temp in list)
            {
                price += temp.Price;
            }
            tbxPrice.Text =price.ToString();
            if (list.Count==0)
            {
                ChangeStatus0();
            }
        }
        public void GetProducts()
        {
            var model = _productService.GetAll();
            for (int i = 0; i < model.Count; i++)
            {
                Button btn = new Button();
                btn.Text = model[i].ProductName;
                btn.Font= new Font("Microsoft Sans Serif",15);
                btn.Name = model[i].ProductID.ToString();
                btn.Height = 125;
                btn.Width = 125;
                btn.AccessibleDescription = model[i].Price.ToString();
                btn.BackColor = Color.Orange;
                flpProducts.Controls.Add(btn);
                btn.Click +=newOrder;
            }
        }
        public void ChangeStatus1()
        {
            _tableService.Update(new Table
            {
                TableID = id,
                Status = 1,
            });
        }
        public void ChangeStatus0()
        {
            _tableService.Update(new Table
            {
                TableID = id,
                Status = 0,
            });
        }
        public void newOrder(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            _orderService.Add(new Order()
            {
                ProductName = btn.Text,
                Price = Convert.ToDecimal(btn.AccessibleDescription),
                TableID = id,
                Amount = 1,
            });
            GetOrderByTableId();
            GetPrice();
            ChangeStatus1();
            MessageBox.Show("Ürün eklendi !");
        }

        private void OpenTablesForm_Click(object sender, EventArgs e)
        {
            ReturnTables();
        }

        private void ReturnTables()
        {
            FormTable frm = new FormTable();
            frm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _orderService.Delete(new Order
            {
                OrderID = Convert.ToInt32(dqwOrders.CurrentRow.Cells[0].Value)
            });
            GetOrderByTableId();
            GetPrice();
            MessageBox.Show("Ürün Silindi!");
        }
        private void OffTable()
        {
            var list = _orderService.GetAll(id);
            foreach (var temp in list)
            {
                _orderService.Delete(temp);
            }
            MessageBox.Show("Hesap Ödendi!");
        }
        private void btnCardPayment_Click(object sender, EventArgs e)
        {
            _paymentService.Add(new Payment
            {
                Price = Convert.ToDecimal(tbxPrice.Text),
                DateTime = DateTime.Now,
                PaymentMethod = "Kredi Kartı",
            });
            OffTable();
            ChangeStatus0();
            ReturnTables();
        }
        private void btnCashPayment_Click(object sender, EventArgs e)
        {
            _paymentService.Add(new Payment
            {
                Price = Convert.ToDecimal(tbxPrice.Text),
                DateTime = DateTime.Now,
                PaymentMethod = "Nakit",
            });
            OffTable();
            ChangeStatus0();
            ReturnTables();
        }
    }
}

