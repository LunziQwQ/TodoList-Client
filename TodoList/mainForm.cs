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
        
        private int tickCount = 0;

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
            visualManager.labelListStartLocation = new Point[] { TaskItem1.Location, TaskItem2.Location, TaskItem3.Location, TaskItem4.Location, TaskItem5.Location };
            visualManager.sendNotice(ItemList.getInstance().init() ? "    Welcome, Click here to hide this notice." : "Error:TaskItem init faild", 2);
            visualManager.showPage();
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

        private void btn_pgUp_Click(object sender, EventArgs e) {
            visualManager.changePage(true);
        }

        private void btn_pgDn_Click(object sender, EventArgs e) {
            visualManager.changePage(false);
        }

        private void btn_add_Click(object sender, EventArgs e) {
            visualManager.addItem();
        }

        #region LabelList_MouseClickEvent
        private void TaskItem1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(1, tickCount);
        }

        private void TaskItem2_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(2, tickCount);
        }

        private void TaskItem3_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(3, tickCount);
        }

        private void TaskItem4_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(4, tickCount);
        }

        private void TaskItem5_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(5, tickCount);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e) {
            tickCount++;
            Debug.Print("-->"+tickCount.ToString());
            visualManager.mainForm_menuOffsetByTimer(tickCount);
        }
    }
}
