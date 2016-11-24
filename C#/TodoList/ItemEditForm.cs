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
        private int index;
        private TaskItem thisItem;
        private string 
            _tempSaveInputTitleText,
            _tempSaveInputMoreText;
        private bool 
            _tempSaveIsStar;


        public ItemEditForm(int index,int nowPage) {
            InitializeComponent();
            this.index = index;
            thisItem = visualManager.getItemByVisualIndex(index);
            editText.Text = thisItem.Title;
            editMoreText.Text = thisItem.MoreText;
            editText.BackColor = thisItem.isStar ? Color.FromArgb(245, 179, 177) : Color.FromArgb(255, 252, 216);
            editMoreText.BackColor = thisItem.isStar ? Color.FromArgb(245, 179, 177) : Color.FromArgb(255, 252, 216);
            btn_isStar.BackgroundImage = thisItem.isStar ? Properties.Resources.star1 : Properties.Resources.star0;
            visualManager.visualMain.Enabled = false;
        }

        private void btn_confirm_Click(object sender, EventArgs e) {
            thisItem.Title = editText.Text;
            thisItem.MoreText = editMoreText.Text;
            visualManager.visualMain.Enabled = true;
            visualManager.visualValueUpdate();
            visualManager.item_mouseClick(0);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            visualManager.visualValueUpdate();
            visualManager.visualMain.Enabled = true;
            visualManager.item_mouseClick(0);
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

        private void editText_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter)
                btn_confirm_Click(sender, e);
        }

        private void editText_TextChanged(object sender, EventArgs e) {
            Size size = TextRenderer.MeasureText(editText.Text,visualManager.labelList[0].Font);

            if (size.Width >= 600) {
                visualManager.sendNotice("Error:Input lenth out of the MaxTitleLength", 2);
                editText.Focus();
                editText.Text = _tempSaveInputTitleText;

            } else {
                _tempSaveInputTitleText = editText.Text;
            }

        }

        private void btn_isStar_Click(object sender, EventArgs e) {
            visualManager.changeIsStar(index);
            btn_isStar.BackgroundImage = thisItem.isStar ? Properties.Resources.star1 : Properties.Resources.star0;
            editText.BackColor = thisItem.isStar ? Color.FromArgb(245, 179, 177) : Color.FromArgb(255, 252, 216);
            editMoreText.BackColor = thisItem.isStar ? Color.FromArgb(245, 179, 177) : Color.FromArgb(255, 252, 216);
        }

        private void editMoreText_TextChanged(object sender, EventArgs e) {
            if(editMoreText.Text.Length >= TaskItem.maxTextLength) {
                visualManager.sendNotice("Error:Input lenth out of the MaxTitleLength", 2);
                editMoreText.Focus();
                editMoreText.Text = _tempSaveInputMoreText;
            }else{
                _tempSaveInputMoreText = editMoreText.Text;
            }
        }
    }
}
