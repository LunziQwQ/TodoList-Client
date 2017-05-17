using System;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace TodoList {
    public partial class LoginForm: Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e) {

        }

        private void btn_login_Click(object sender, EventArgs e) {

            if (checkInput()) {
                
            } else
                MessageBox.Show("输入有误");
        }

        private void btn_create_Click(object sender, EventArgs e) {
            if (checkInput()) {
                
                
            } else
                MessageBox.Show("输入有误");
        }

        private bool checkInput() {
            if (textBox_username.Text.Length == 0 || textBox_keyword.Text.Length == 0)
                return false;
            return true;
        }
    }
}
