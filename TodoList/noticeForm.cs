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
        public int tickCount = 0;      //计时器tick计数，用于控制淡入淡出阶段
       
        public noticeForm() {
            InitializeComponent();
            
        }
        private void Timer_Tick(object sender, EventArgs e) {
            tickCount++;
            NoticeText.Text = messageNotice.MessageText;
            visualManager.noticeForm_fadeByTimer(tickCount);
        }

        private void noticeForm_Click(object sender, EventArgs e) {
            this.tickCount = visualManager.noticeForm_Click();
        }
    }
}
