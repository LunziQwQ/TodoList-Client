using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e) {
            btn_close.BackColor = Color.OrangeRed;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e) {
            btn_close.BackColor = Color.Transparent;
        }

        private void mainForm_MouseDown(object sender, EventArgs e) {

        }
        
    }
}
