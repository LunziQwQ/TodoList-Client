using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList {
    class MessageNotice {
        private int aliveTime = 3;              //通知持续时间
        private string messageText;             //通知内容

        //实现单例模式
        private static MessageNotice Instance;
        private MessageNotice() {}

        public static MessageNotice getInstance() {
            if (Instance == null)
                Instance = new MessageNotice();
            return Instance;
        }

        public void showNotice() {
            noticeForm temp = new noticeForm();
            temp.Show();
        }
        
    }
}
