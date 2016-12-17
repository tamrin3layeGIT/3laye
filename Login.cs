using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                this.Hide();
                Main m = new Main();
                m.ShowDialog();
            }
            else {
                lblMessge.Text = "نام کاربری و یا کلمه عبور اشتباه است";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
