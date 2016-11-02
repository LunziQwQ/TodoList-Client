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
        
        private int tickCount = -1;

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
            foreach(Label x in visualManager.labelList) 
                x.BringToFront();
            #region someToolSendToClass"VisiualManager"
            visualManager.labelListStartLocation = new Point[] { TaskItem1.Location, TaskItem2.Location, TaskItem3.Location, TaskItem4.Location, TaskItem5.Location };
            visualManager.btn_delList = new Label[] { btn_del1, btn_del2, btn_del3, btn_del4, btn_del5 };
            visualManager.btn_editList = new Label[] { btn_edit1, btn_edit2, btn_edit3, btn_edit4, btn_edit5 };
            visualManager.pageIndex = this.PageIndex;
            #endregion
            visualManager.sendNotice(ItemList.getInstance().init() ? "    Welcome, Click here to hide this notice." : "Error:TaskItem init faild", 2);
            visualManager.showPage();
        }


        //实现点击窗口非控件区域时拖动窗口改变窗口位置*****************
        private void mainForm_MouseDown(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseDown(e.Location, this);
        }
        private void mainForm_MouseUp(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseUP();
        }
        private void mainForm_MouseMove(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseMove(this);
        }



        //**********************************************************

        private void btn_pgUp_Click(object sender, EventArgs e) {
            visualManager.changePage(true, tickCount);
        }

        private void btn_pgDn_Click(object sender, EventArgs e) {
            visualManager.changePage(false, tickCount);
        }

        private void btn_add_Click(object sender, EventArgs e) {
            visualManager.addItem();
        }

        #region LabelList_MouseRightClickEvent
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
        #region btn_delListClickEvent
        private void btn_del1_Click(object sender, EventArgs e) {
            visualManager.delItem(0);
        }

        private void btn_del2_Click(object sender, EventArgs e) {
            visualManager.delItem(1);
        }

        private void btn_del3_Click(object sender, EventArgs e) {
            visualManager.delItem(2);
        }

        private void btn_del4_Click(object sender, EventArgs e) {
            visualManager.delItem(3);
        }

        private void btn_del5_Click(object sender, EventArgs e) {
            visualManager.delItem(4);
        }
        #endregion
        #region btn_editClickEventList
        private void btn_edit1_Click(object sender, EventArgs e) {
            visualManager.editItem(0);
        }

        private void btn_edit2_Click(object sender, EventArgs e) {
            visualManager.editItem(1);
        }

        private void btn_edit3_Click(object sender, EventArgs e) {
            visualManager.editItem(2);
        }

        private void btn_edit4_Click(object sender, EventArgs e) {
            visualManager.editItem(3);
        }

        private void btn_edit5_Click(object sender, EventArgs e) {
            visualManager.editItem(4);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e) {
            tickCount++;
            visualManager.mainForm_menuOffsetByTimer(tickCount);
            visualManager.mainForm_PageOffsetByTimer(tickCount);
        }
    }
}
