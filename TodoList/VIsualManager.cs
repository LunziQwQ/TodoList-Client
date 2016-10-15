using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TodoList {
    class VisualManager {
        private const double fadeAcceleration = 0.003;                  //淡入淡出动画加速度
        private MessageNotice message = MessageNotice.getInstance();    //通知实例
        public mainForm visualMain;         //主窗口视图实例
        public noticeForm visualNotice;     //通知窗口视图实例
        public bool closeAllForm = false;
        private int fadeTickCount = 0;

        //实现单例模式
        private VisualManager(){}
        private static VisualManager instance;
        
        public static VisualManager getInstance() {
            if (instance == null)
                instance = new VisualManager();
            return instance;
        }

        public void noticeForm_fade(bool isIn) {
            fadeTickCount += isIn ? 1 : -1;
            if (fadeTickCount < 0) fadeTickCount = 0;   //边界维护，使每个noticeForm关闭后计数器一定为 0 ，防止fadeIn未完成时点击触发fadeOut使计数器为负数。
            visualNotice.Opacity += (isIn) ? 0.02+fadeAcceleration*fadeTickCount : -0.02-fadeAcceleration*(50-fadeTickCount);
        }

        //显示通知窗口并显示通知消息
        public void sendNotice(string text) {
            message.MessageText = text;
            visualNotice = new noticeForm();
            Point mainFormLocation = visualMain.Location;
            visualNotice.Show();
            visualNotice.Opacity = 0.01;
            visualNotice.Location = new Point(mainFormLocation.X + visualMain.Width, mainFormLocation.Y);
        }

        //实现点击窗口非控件区域时拖动窗口改变窗口位置*****************
        private Point moveForm_MouseStartPosition = new Point(0, 0);       //触发mouseDown时的初始鼠标坐标，用于计算拖动偏移量
        private Point moveForm_FormStartPosition = new Point(0, 0);        //触发mouseDown时的初始窗口坐标，用于实现窗口偏移
        private bool isMoveFormEvent = false;

        public void moveForm_MouseDown(object sender, MouseEventArgs e) {
            isMoveFormEvent = true;
            moveForm_MouseStartPosition = visualMain.PointToScreen(e.Location);
            moveForm_FormStartPosition = visualMain.Location;
        }
        public void moveForm_MouseUP(object sender, MouseEventArgs e) {
            isMoveFormEvent = false;
            moveForm_MouseStartPosition = new Point(0, 0);
            moveForm_FormStartPosition = new Point(0, 0);
        }
        public void moveForm_MouseMove(object sender, MouseEventArgs e) {
            if (isMoveFormEvent) {
                Point offset = new Point(Control.MousePosition.X - moveForm_MouseStartPosition.X, Control.MousePosition.Y - moveForm_MouseStartPosition.Y);
                visualMain.Location = new Point(moveForm_FormStartPosition.X + offset.X, moveForm_FormStartPosition.Y + offset.Y);  //移动主窗口
                visualNotice.Location = new Point(visualMain.Location.X + visualMain.Width, visualMain.Location.Y);                 //使通知窗口随主窗口移动
            }
        }
    }
}
