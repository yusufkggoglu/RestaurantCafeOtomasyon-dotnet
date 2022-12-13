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

        //private void FormTable_Load(object sender, EventArgs e)
        //{
        //    dqwTable.DataSource = _orderService.GetAll();
        //}

       

        private void OpenFormTableScreen(int tbl)
        {
            FormTableScreen frm = new FormTableScreen()
            {
                id = tbl,
            };
            frm.Show();
            this.Hide();
        }

        ////private int TableClick(int tabl)
        //{
        //    Table table = new Table
        //    {
        //        TableID = tabl,
        //    };
        //    int tbl = table.TableID;
        //    if (table.Status == 0)
        //    {
        //        _tableService.Update(new Table()
        //        {
        //            TableID = tbl,
        //            Status = 1,
        //        });
        //        btnTable1.BackColor = Color.Red;
        //    }

        //    return tbl;
        //}
        //private void btnTable1_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(1);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable2_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(2);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable3_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(3);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable4_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(4);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable5_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(5);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable6_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(6);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable7_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(7);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable8_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(8);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable9_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(9);
        //    OpenFormTableScreen(tbl);
        //}

        //private void btnTable10_Click(object sender, EventArgs e)
        //{
        //    var tbl = TableClick(10);
        //    OpenFormTableScreen(tbl);
        //}

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
