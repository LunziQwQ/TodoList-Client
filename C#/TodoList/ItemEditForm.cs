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
    public partial class ItemEditForm: Form {
        private VisualManager visualManager = VisualManager.getInstance();
        private int index, nowPage;
        private TaskItem thisItem;
        public ItemEditForm(int index,int nowPage) {
            InitializeComponent();
            this.index = index;
            thisItem = visualManager.getItemByVisualIndex(index);
            editText.Text = thisItem.Title;
            btn_isStar.BackColor = thisItem.isStar ? Color.Orange : Color.White;
            visualManager.visualMain.Enabled = false;
        }

        private void btn_confirm_Click(object sender, EventArgs e) {
            thisItem.Title = editText.Text;
            visualManager.showPage();
            visualManager.visualMain.Enabled = true;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            visualManager.showPage();
            visualManager.visualMain.Enabled = true;
            this.Close();
        }

        private void ItemEditForm_MouseDown(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseDown(e.Location, this);
        }

        private void ItemEditForm_MouseUp(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseUP();
        }

        private void ItemEditForm_MouseMove(object sender, MouseEventArgs e) {
            visualManager.moveForm_MouseMove(this);
        }

        private void btn_isStar_Click(object sender, EventArgs e) {
            visualManager.changeIsStar(index);
            btn_isStar.BackColor = thisItem.isStar ? Color.Orange : Color.White;
        }
    }
}
