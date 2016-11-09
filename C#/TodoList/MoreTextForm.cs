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
