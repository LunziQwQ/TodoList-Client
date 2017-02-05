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
            
            FileManager.getInstance().account.Username = textbox_username1.Text;
            FileManager.getInstance().account.Password = textbox_password1.Text;
            FileManager.getInstance().account.setAccount();
            FileManager.getInstance().account.signIn();
            if (Account.getInstance().signInStatus)
                MessageBox.Show("SignIn success!");
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
            Account.getInstance().signUp(textbox_password1.Text, textbox_password2.Text);
        }
    }
}
