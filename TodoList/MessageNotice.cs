using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList {
    class MessageNotice {
        private static int maxNoticeLength = 30;
        private static int maxAliveTime = 15;
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
        
        public int AliveTime {
            set {
                if (value > 0 && value <= maxAliveTime)
                    aliveTime = value;
            }
            get { return aliveTime; }
        }
        public string MessageText {
            set {
                if (value.Length <= maxNoticeLength) 
                    messageText = value;
            }
            get { return messageText; }
        }
    }
}
