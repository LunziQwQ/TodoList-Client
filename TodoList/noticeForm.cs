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

        private int tickCount = 0;
        //淡入/淡出/窗口持续，时间：设置前面的数字，单位为ms
        private const int fadeInOut_Tick = 500/10;
        private const int hold_Tick = 2500/10;


        public noticeForm() {
            InitializeComponent();
            NoticeText.Text = messageNotice.MessageText;
        }
        private void Timer_Tick(object sender, EventArgs e) {
            tickCount++;
            if(tickCount<=fadeInOut_Tick)
                visualManager.noticeForm_fade(true);
            if (tickCount > fadeInOut_Tick + hold_Tick)
                visualManager.noticeForm_fade(false);
            if (tickCount == fadeInOut_Tick * 2 + hold_Tick)
                this.Close();
        }

        private void noticeForm_Click(object sender, EventArgs e) {
            this.tickCount = fadeInOut_Tick + hold_Tick;
        }
        
    }
}
