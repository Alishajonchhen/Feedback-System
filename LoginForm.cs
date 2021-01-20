using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomerReview
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
           if (UsernameTxt.Text=="" && PasswordTxt.Text=="")
            {
                MessageBox.Show("Please Enter Username and Password!");
            }
            else
            {
                if(UsernameTxt.Text=="admin" && PasswordTxt.Text=="admin")
                {
                    this.Hide();
                    Home ap = new Home();
                    ap.Show();
               
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
            }
            
        }
    }
}
