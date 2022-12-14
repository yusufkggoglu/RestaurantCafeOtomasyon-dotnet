using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using FormDesign;

namespace FormTasarım
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
            _tableService = new TableManager(new EfTableDal());
            _orderService = new OrderManager(new EfOrderDal());

        }
        private ITableService _tableService;
        private IOrderService _orderService;
        private void OpenFormTableScreen(int tbl)
        {
            FormTableScreen frm = new FormTableScreen()
            {
                id = tbl,
            };
            frm.Show();
            this.Hide();
        }
        private void GetTables()
        {
            var model = _tableService.GetAll();
            for (int i = 0; i < model.Count; i++)
            {
                Button btn = new Button();
                btn.Text = model[i].TableID.ToString();
                btn.Name = model[i].TableID.ToString();
                btn.Font = new Font("Microsoft Sans Serif", 15);
                btn.Height = 150;
                btn.Width = 150;
                flpTable.Controls.Add(btn);
                btn.Click += OpenTableScreenForm;
                if (model[i].Status==0)
                {
                    btn.BackColor = Color.Green;
                }
                else 
                {
                    btn.BackColor = Color.DarkRed;
                }
            }
        }
        public void OpenTableScreenForm(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            FormTableScreen frm = new FormTableScreen()
            {
                id = Convert.ToInt32(btn.Text),
            };
            frm.Show();
            this.Hide();
        }
        private void FormTable_Load(object sender, EventArgs e)
        {
            GetTables();
        }

        private void OpenHomeForm_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm();
            frm.Show();
            this.Hide();
        }
    }
}
