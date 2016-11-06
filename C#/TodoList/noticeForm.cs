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
    public partial class noticeForm : Form {
        private VisualManager visualManager = VisualManager.getInstance();
        private MessageNotice messageNotice = MessageNotice.getInstance();
        private const int fadeInOut_Tick = 500 / 10;
        private const double fadeAcceleration = 0.003;
        private int fadeTickCount = 0;          //消息窗口的tickcount
        public int tickCount = 0;      //计时器tick计数，用于控制淡入淡出阶段
        public int locationIndex;
       
        public noticeForm() {
            InitializeComponent();
            NoticeText.Text = messageNotice.MessageText;
            visualManager.nowNoticeFormCount++;
        }
        private void Timer_Tick(object sender, EventArgs e) {
            tickCount++;
            if (tickCount <= fadeInOut_Tick)
                noticeForm_fade(true);
            if (tickCount > fadeInOut_Tick + MessageNotice.getInstance().AliveTime)
                noticeForm_fade(false);
            if (tickCount == fadeInOut_Tick * 2 + MessageNotice.getInstance().AliveTime) {
                visualManager.nowNoticeFormCount--;
                this.Close();
                visualManager.isNoticeFormLocationExist[locationIndex] = false;
                if (visualManager.isCloseAllForm && visualManager.nowNoticeFormCount == 0)
                    visualManager.visualMain.Close();
        }
    }

        private void noticeForm_Click(object sender, EventArgs e) {
            this.tickCount = fadeInOut_Tick + MessageNotice.getInstance().AliveTime;
        }

        private void noticeForm_fade(bool isIn) {
            fadeTickCount += isIn ? 1 : -1;
            //边界维护，使每个noticeForm关闭后计数器一定为 0 ，防止fadeIn未完成时点击触发fadeOut使计数器为负数。
            if (fadeTickCount < 0) fadeTickCount = 0;
            this.Opacity += (isIn) ? 0.02 + fadeAcceleration * fadeTickCount : -0.02 - fadeAcceleration * (50 - fadeTickCount);
        }
    }
}
