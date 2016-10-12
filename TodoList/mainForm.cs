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
        private VisualManager visualManager = VisualManager.getInstance();

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

        private void mainForm_Load(object sender,EventArgs e) {
            visualManager.visualMain = this;
            visualManager.sendNotice("欢迎使用TodoList，点击窗口 通知将立即消失");
        }


        //实现点击窗口非控件区域时拖动窗口改变窗口位置*****************
        private void mainForm_MouseDown(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseDown(sender, e);
        }
        private void mainForm_MouseUp(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseUP(sender, e);
        }
        private void mainForm_MouseMove(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseMove(sender, e);
        }



        //**********************************************************

        private void label1_Click(object sender, EventArgs e) {

        }

    }
}
