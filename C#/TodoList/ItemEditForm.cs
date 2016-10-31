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
        private int index, nowPage;
        public ItemEditForm(int index,int nowPage) {
            InitializeComponent();
            this.index = index;
            this.nowPage = nowPage;
            editText.Text = ItemList.getInstance().getListByPage(nowPage)[index].Title;
        }

        private void btn_confirm_Click(object sender, EventArgs e) {
            ItemList.getInstance().getListByPage(nowPage)[index].Title = editText.Text;
            VisualManager.getInstance().showPage();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_isStar_Click(object sender, EventArgs e) {
            VisualManager.getInstance().changeIsStar(index);
        }
    }
}
