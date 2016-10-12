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
            visualManager.mainFormLocation = this.Location;
            visualManager.showNotice("Hello visualNotice");
            
        }


        //实现点击窗口非控件区域时拖动窗口改变窗口位置*****************
        private Point moveForm_MouseStartPosition = new Point(0, 0);       //触发mouseDown时的初始鼠标坐标，用于计算拖动偏移量
        private Point moveForm_FormStartPosition = new Point(0, 0);        //触发mouseDown时的初始窗口坐标，用于实现窗口偏移
        private bool isMoveFormEvent = false;

        private void _moveForm_MouseDown(object sender, MouseEventArgs e) {
            isMoveFormEvent = true;
            moveForm_MouseStartPosition = this.PointToScreen(e.Location);
            moveForm_FormStartPosition = this.Location;
        }
        private void _moveForm_MouseUP(object sender, MouseEventArgs e) {
            isMoveFormEvent = false;
            moveForm_MouseStartPosition = new Point(0, 0);
            moveForm_FormStartPosition = new Point(0, 0);
        }
        private void _moveForm_MouseMove(object sender, MouseEventArgs e) {
            if (isMoveFormEvent) {
                Point offset = new Point(MousePosition.X - moveForm_MouseStartPosition.X, MousePosition.Y - moveForm_MouseStartPosition.Y);
                this.Location = new Point(moveForm_FormStartPosition.X + offset.X, moveForm_FormStartPosition.Y + offset.Y);
            }
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e) {
            _moveForm_MouseDown(sender, e);
        }
        private void mainForm_MouseUp(object sender, MouseEventArgs e) {
            _moveForm_MouseUP(sender, e);
        }
        private void mainForm_MouseMove(object sender, MouseEventArgs e) {
            _moveForm_MouseMove(sender, e);
        }



        //**********************************************************

        private void label1_Click(object sender, EventArgs e) {

        }

    }
}
