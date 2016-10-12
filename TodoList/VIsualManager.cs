using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

namespace TodoList {
    class VisualManager {
        private MessageNotice message = MessageNotice.getInstance();
        public Point mainFormLocation;

        //实现单例模式
        private VisualManager(){}
        private static VisualManager instance;
        
        public static VisualManager getInstance() {
            if (instance == null)
                instance = new VisualManager();
            return instance;
        }

        //显示通知窗口并显示通知消息
        public void showNotice(string text) {
            message.MessageText = text;
            noticeForm temp = new noticeForm();
            temp.Location = new Point(mainFormLocation.X + 450, mainFormLocation.Y);
            temp.Show();
        }
    }
}
