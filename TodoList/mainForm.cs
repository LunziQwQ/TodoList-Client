using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//Output debug info
using System.Diagnostics;

namespace TodoList {
    public partial class mainForm : Form {
        private VisualManager visualManager = VisualManager.getInstance();
        private FileManager fileManager = FileManager.getInstance();
        

        public mainForm() {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e) {
            if (fileManager.autoSave()) {
                visualManager.sendNotice("Save success.", 2);
                visualManager.closeAllForm = true;
            } else {
                visualManager.sendNotice("Oops. Save Failed.", 2);
            }
        }

        private void btn_close_MouseEnter(object sender, EventArgs e) {
            btn_close.BackColor = Color.OrangeRed;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e) {
            btn_close.BackColor = Color.Transparent;
        }

        private void mainForm_Load(object sender,EventArgs e) {
            //visualManager类的初始值传递
            visualManager.visualMain = this;
            visualManager.labelList =new Label[]{ TaskItem1, TaskItem2, TaskItem3, TaskItem4, TaskItem5};
            visualManager.sendNotice(ItemList.getInstance().init() ? "    Welcome, Click here to hide this notice." : "Error:TaskItem init faild", 2);
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
              
            /*SaveFileDialog a = new SaveFileDialog();
            Debug.Print("-->"+(a.ShowDialog()==DialogResult.Cancel).ToString());
            Debug.Print("-->Path: " + a.FileName);*/
        }

        private void btn_pgUp_Click(object sender, EventArgs e) {
            visualManager.changePage(true);
        }

        private void btn_pgDn_Click(object sender, EventArgs e) {
            visualManager.changePage(false);
        }
    }
}
