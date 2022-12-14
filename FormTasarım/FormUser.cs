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
using Entities.Concrete;

namespace FormTasarım
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());

        }
        private IUserService _userService;

        private void FormUser_Load(object sender, EventArgs e)
        {
            
        }

        private void tbxRegister_Click(object sender, EventArgs e)
        {
            _userService.Add(new User
            {
                Name = tbxName.Text,
                Password = tbxPassword.Text,
            });
            MessageBox.Show("Kullanıcı Eklendi!");
        }

        private void OpenHomeForm_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm();
            frm.Show();
            this.Hide();
        }
    }
}
