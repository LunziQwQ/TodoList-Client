using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class SignInForm : Form
    {
        //private MysqlConnector mysqlConnector = new MysqlConnector();

        public SignInForm() {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e) {
            Account.getInstance().Username = textbox_username1.Text;
            Account.getInstance().Password = textbox_password1.Text;
            Account.getInstance().setAccount();
            Account.getInstance().signIn();
            if (Account.getInstance()._signInStatus) {
                MessageBox.Show("SignIn success!");
                this.Close();
            }
            else
                MessageBox.Show("SignIn failed, try again!"); 
        }

        private void btn_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e) {
            btn_close.BackColor = Color.FromArgb(250, 112, 1);
        }

        private void btn_close_MouseLeave(object sender, EventArgs e) {
            btn_close.BackColor = Color.Transparent;
        }

        private void btn_signup_Click(object sender, EventArgs e) {
            Account.getInstance().Username = textbox_username2.Text;
            Account.getInstance().Password = textbox_password2.Text;
            Account.getInstance().setAccount();
            if (Account.getInstance().signUp(textbox_password2.Text, textbox_password3.Text)) {
                MessageBox.Show("SignUp success!");
            }else
                MessageBox.Show("SignUp failed,please try again.");
        }
    }
}
