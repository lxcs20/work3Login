using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppWork2ABCcompny
{
    public partial class Form1 : Form
    {
        public static int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "12345";

            if (i > 3)
            {
                MessageBox.Show("Your Login Failed Please Try Again Later", "Login");
            }
            else if (txtUsername.Text == user && txtPassword.Text == pass)
            {
                MessageBox.Show("Welcome", "Login Success");
                frmMain btnLogin = new frmMain();
                btnLogin.Show();
            }
            else
            {
                MessageBox.Show("Your Username or Password not Correct", "Login fail");
                i++;
            }
        }
    }
}
