using System;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace TodoList {
    public partial class LoginForm: Form {
        private Sync sync = Sync.getInstance();
        public LoginForm() {
            InitializeComponent();
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
