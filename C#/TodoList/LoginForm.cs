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
    public partial class LoginForm : Form
    {
        //private MysqlConnector mysqlConnector = new MysqlConnector();

        public LoginForm() {
            InitializeComponent();
        }

        private void ConnectTest_Click(object sender, EventArgs e) {
            //mysqlConnector.ConnectionTest();
        }

        private void btn_close_Click(object sender, EventArgs e) {
            this.Close();
            Application.Exit();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e) {
            btn_close.BackColor = Color.FromArgb(250, 112, 1);
        }

        private void btn_close_MouseLeave(object sender, EventArgs e) {
            btn_close.BackColor = Color.Transparent;
        }
    }
}
