using System;
using System.Windows.Forms;

namespace TodoList {
    public partial class MoreTextForm: Form {
        private VisualManager visualManager = VisualManager.getInstance();
        
        public int tickCount = 0;
        public int status = 3;

        public MoreTextForm() {
            InitializeComponent();
            visualManager.moreTextLabel = moreTextLabel;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            tickCount++;
            visualManager.moreTextForm_changeLocation();
            visualManager.moreTextForm_fadeByTick();
        }
    }
}
