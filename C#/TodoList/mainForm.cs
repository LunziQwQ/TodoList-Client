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
    public partial class MainForm : Form {

        private VisualManager visualManager = VisualManager.getInstance();
        private FileManager fileManager = FileManager.getInstance();
        
        private int tickCount = -1;

        public MainForm() {
            InitializeComponent();
        }

        
        private void mainForm_Load(object sender,EventArgs e) {
            //visualManager类的初始值传递
            #region someToolSendToClass"VisiualManager"
            visualManager.visualMain = this;
            visualManager.labelList = new Label[] { TaskItem1, TaskItem2, TaskItem3, TaskItem4, TaskItem5 };
            visualManager.labelListStartLocation = new Point[] { TaskItem1.Location, TaskItem2.Location, TaskItem3.Location, TaskItem4.Location, TaskItem5.Location };
            visualManager.btn_delList = new Label[] { btn_del1, btn_del2, btn_del3, btn_del4, btn_del5 };
            visualManager.btn_editList = new Label[] { btn_edit1, btn_edit2, btn_edit3, btn_edit4, btn_edit5 };
            visualManager.pageIndex = this.PageIndex;
            #endregion
            foreach (Label x in visualManager.labelList)
                x.BringToFront();
            visualManager.sendNotice(ItemList.getInstance().init() ? "    Welcome, Click here to hide this notice." : "Error:TaskItem init faild", 2);
            visualManager.showPage();
            visualManager.moreTextForm_init();
        }

        #region 点击窗口非控件区域时拖动窗口改变窗口位置
        private void mainForm_MouseDown(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseDown(e.Location, this);
        }
        private void mainForm_MouseUp(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseUP();
        }
        private void mainForm_MouseMove(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseMove(this);
        }
        #endregion
        #region 关闭，新增Item，翻页按钮
        private void btn_close_Click(object sender, EventArgs e) {
            if (fileManager.autoSave()) {
                visualManager.sendNotice("Save success.", 2);
                visualManager.isCloseAllForm = true;
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

        private void btn_pgUp_Click(object sender, EventArgs e) {
            visualManager.changePage(true, tickCount);
        }

        private void btn_pgDn_Click(object sender, EventArgs e) {
            visualManager.changePage(false, tickCount);
        }

        private void btn_add_Click(object sender, EventArgs e) {
            visualManager.addItem();
        }
        #endregion
        #region LabelList_MouseRightClickEventList
        private void TaskItem1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(0);
        }

        private void TaskItem2_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(1);
        }

        private void TaskItem3_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(2);
        }

        private void TaskItem4_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(3);
        }

        private void TaskItem5_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                visualManager.item_mouseClick(4);
        }
        #endregion
        #region btn_delClickEventList
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
            visualManager.mainForm_nowTick = tickCount;
            visualManager.mainForm_menuOffsetByTimer(tickCount);
            visualManager.mainForm_PageOffsetByTimer(tickCount);
            visualManager.moreTextForm_changeLocation();
        }

        #region Label_HoverEventList
        private void TaskItem1_MouseHover(object sender, EventArgs e) {
            visualManager.item_mouseHover(0);
        }
        private void TaskItem2_MouseHover(object sender, EventArgs e) {
            visualManager.item_mouseHover(1);
        }
        private void TaskItem3_MouseHover(object sender, EventArgs e) {
            visualManager.item_mouseHover(2);
        }
        private void TaskItem4_MouseHover(object sender, EventArgs e) {
            visualManager.item_mouseHover(3);
        }
        private void TaskItem5_MouseHover(object sender, EventArgs e) {
            visualManager.item_mouseHover(4);
        }
        #endregion
        #region Label_LeaveEventList
        private void TaskItem1_MouseLeave(object sender, EventArgs e) {
            visualManager.item_mouseLeave(0);
        }

        private void TaskItem2_MouseLeave(object sender, EventArgs e) {
            visualManager.item_mouseLeave(1);
        }

        private void TaskItem3_MouseLeave(object sender, EventArgs e) {
            visualManager.item_mouseLeave(2);
        }

        private void TaskItem4_MouseLeave(object sender, EventArgs e) {
            visualManager.item_mouseLeave(3);
        }

        private void TaskItem5_MouseLeave(object sender, EventArgs e) {
            visualManager.item_mouseLeave(4);
        }
        #endregion
    }
}
