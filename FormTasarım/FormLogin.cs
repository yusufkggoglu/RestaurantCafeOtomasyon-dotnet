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

namespace FormTasarım
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());

        }
        private IUserService _userService;
       
        private void OpenHomeForm()
        {
            HomeForm frm = new HomeForm();
            frm.Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserControl();
        }

        private void UserControl()
        {
            if (_userService.UserProvider(tbxName.Text, tbxPassword.Text))
            {
                OpenHomeForm();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlış!\nTekrar Deneyiniz.");
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                UserControl();
            }
        }
    }
}
