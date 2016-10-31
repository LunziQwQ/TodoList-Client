using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TodoList {
    class VisualManager {

        //淡入淡出时间：设置前面的数字，单位为ms
        private const int taskItemLabel_Heigth = 80;

        private const int labelMenuOffset = 100;
        private const int offsetAcceleration = 1;
        public int nowNoticeFormCount = 0;     //当前已存在的消息窗口数量
        public bool[] isNoticeFormLocationExist = new bool[5];   //当前已占用的消息位置

        public mainForm visualMain;             //主窗口视图实例
        public noticeForm visualNotice;         //通知窗口视图实例 
        public Label[] labelList;               //主窗口的五个label列表
        public Point[] labelListStartLocation;  //主窗口的五个label初始位置
        public Label[] btn_delList;             //主窗口的五个删除按钮列表
        public Label[] btn_editList;            //主窗口的五个编辑按钮列表
        public Label pageIndex;                 //主窗口的页码label
        public bool closeAllForm = false;       //判断是否为点击关闭按钮后触发的消息窗口
        private int nowPage = 1;                //当前主窗口列表页数
        private int menuOffsetStartTick;

        private bool[] isLabelMenuOffseting = new bool[5];
        private bool[] lableMenuOffsetStatus = new bool[5]; //true offseted,false origin position
        private string[] pageIndexTextList =  {
            "1  ·  ·  ·  · ",
            "·  2  ·  ·  · ",
            "·  ·  3  ·  · ",
            "·  ·  ·  4  · ",
            "·  ·  ·  ·  5 ",
        };

        //实现单例模式
        private VisualManager(){}
        private static VisualManager instance;
        
        public static VisualManager getInstance() {
            if (instance == null)
                instance = new VisualManager();
            return instance;
        }

        //显示通知窗口并显示通知消息
        public void sendNotice(string text, int aliveTime) {
            if (nowNoticeFormCount == 5) return;
            MessageNotice.getInstance().MessageText = text;
            MessageNotice.getInstance().AliveTime = aliveTime;
            visualNotice = new noticeForm();
            visualNotice.Opacity = 0;
            Point mainFormLocation = visualMain.Location;
            visualNotice.Show();
            for (int i = 0; i < 5; i++) {
                if (!isNoticeFormLocationExist[i]) {
                    visualNotice.Location = new Point(mainFormLocation.X + visualMain.Width, mainFormLocation.Y + i * (5 + visualNotice.Size.Height));
                    visualNotice.locationIndex = i;
                    isNoticeFormLocationExist[i] = true;
                    break;
                }
            }
        }

        //实现点击窗口非控件区域时拖动窗口改变窗口位置*****************
        private Point moveForm_MouseStartPosition = new Point(0, 0);       //触发mouseDown时的初始鼠标坐标，用于计算拖动偏移量
        private Point moveForm_FormStartPosition = new Point(0, 0);        //触发mouseDown时的初始窗口坐标，用于实现窗口偏移
        private bool isMoveFormEvent = false;

        public void moveForm_MouseDown(Point location, Form form) {
            isMoveFormEvent = true;
            moveForm_MouseStartPosition = form.PointToScreen(location);
            moveForm_FormStartPosition = form.Location;
        }
        public void moveForm_MouseUP() {
            isMoveFormEvent = false;
            moveForm_MouseStartPosition = new Point(0, 0);
            moveForm_FormStartPosition = new Point(0, 0);
        }
        public void moveForm_MouseMove(Form form) {
            if (isMoveFormEvent) {
                Point offset = new Point(Control.MousePosition.X - moveForm_MouseStartPosition.X, Control.MousePosition.Y - moveForm_MouseStartPosition.Y);
                form.Location = new Point(moveForm_FormStartPosition.X + offset.X, moveForm_FormStartPosition.Y + offset.Y);  //移动主窗口
            }
        }

        public void changePage(bool isNext) {
            int _tempPage = nowPage;
            nowPage += isNext ? 1 : -1;
            if (nowPage >= 1 && nowPage <= 5) {
                showPage();
                pageIndex.Text = pageIndexTextList[nowPage - 1];
            } else {
                sendNotice("Error: No more page to change.", 2);
                nowPage = _tempPage;
            }
        }

        public void showPage() {
            TaskItem[] temp = ItemList.getInstance().getListByPage(nowPage);
            int _count = 0;
            foreach (TaskItem x in temp) {
                if(x.Title != "") {
                    labelList[_count].Text = x.Title;
                    labelList[_count].BackColor = x.isStar ? Color.Orange : Color.WhiteSmoke;
                }
                _count++;
            }
            for (int i = 0; i < 5; i++) {
                labelList[i].Visible = labelList[i].Text == "null" ? false : true;
                btn_delList[i].Visible = labelList[i].Text == "null" ? false : true;
                btn_editList[i].Visible = labelList[i].Text == "null" ? false : true;
                labelList[i].Location = labelListStartLocation[i];
                isLabelMenuOffseting[i] = false;
                lableMenuOffsetStatus[i] = false;
            }
        }
        public TaskItem getItemByVisualIndex(int index) {
            return ItemList.getInstance().getListByPage(nowPage)[index];
        }

        public void addItem() {
            ItemList.getInstance().addItem();
            showPage();
        }

        public void delItem(int index) {
            ItemList.getInstance()
                .delItme(getItemByVisualIndex(index).index);
            showPage();
        }

        public void editItem(int index) {
            ItemEditForm visualEdit = new ItemEditForm(index, nowPage);
            visualEdit.Show();
        }
        public void changeIsStar(int index) {
            ItemList.getInstance()
                .changeIsStar(getItemByVisualIndex(index).index);
        }

        public void item_mouseClick(int item_index, int nowTick) {
            foreach(bool x in isLabelMenuOffseting) {
                if (x) {
                    sendNotice("Error:Menu is offseting now.", 2);
                    return;
                }
            }
            menuOffsetStartTick = nowTick;
            isLabelMenuOffseting[item_index - 1] = true;
        }

       
        public void mainForm_menuOffsetByTimer(int tickCount) {
            int _tempCount = tickCount - menuOffsetStartTick,
                _tempAcceleration = _tempCount/4 * offsetAcceleration;
            for (int i = 0; i < 5; i++) {
                if (isLabelMenuOffseting[i] && _tempCount <= 30) {
                    labelList[i].Location = new Point(labelList[i].Location.X + (lableMenuOffsetStatus[i] ? 1 + _tempAcceleration : -(1 + _tempAcceleration)), labelList[i].Location.Y);
                    if (_tempCount == 30) {
                        isLabelMenuOffseting[i] = false;
                        lableMenuOffsetStatus[i] = !lableMenuOffsetStatus[i];
                    }
                }
            }
        }
    }
}
