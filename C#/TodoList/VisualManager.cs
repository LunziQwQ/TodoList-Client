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
        private const int 
            taskItemLabel_Heigth = 80,
            labelMenuOffset = 100,
            LabelOffsetAcceleration = 1,
            PageOffsetAcceleration = 1;

        public int nowNoticeFormCount = 0;     //当前已存在的消息窗口数量
        public bool[] isNoticeFormLocationExist = new bool[5];   //当前已占用的消息位置

        public mainForm visualMain;             //主窗口视图实例
        public noticeForm visualNotice;         //通知窗口视图实例 
        public Point[] labelListStartLocation;  //主窗口的五个label初始位置
        public Label[] 
            btn_delList, 
            btn_editList, 
            labelList;//主窗口的五个编辑，删除按钮以及Item列表

        public Label pageIndex;                 //主窗口的页码label
        public bool closeAllForm = false;       //判断是否为点击关闭按钮后触发的消息窗口
        private int nowPage = 1;                //当前主窗口列表页数

        private int 
            menuOffsetStartTick,
            pageOffsetStartTick;

        private bool isPageOffsetTurnLeft = false;
        public bool isPageOffseting = false;

        private bool[]
            isLabelMenuOffseting = new bool[5],
            lableMenuOffsetStatus = new bool[5]; //true offseted,false origin position

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

        public void changePage(bool isNext, int tickCount) {
            int _tempPage = nowPage;
            nowPage += isNext ? 1 : -1;
            if (nowPage >= 1 && nowPage <= 5) {
                isPageOffseting = true;
                isPageOffsetTurnLeft = isNext;
                pageOffsetStartTick = tickCount;
                for (int i = 0; i < 5; i++)  {
                    btn_delList[i].Visible = false;
                    btn_editList[i].Visible = false;
                }
            } else {
                sendNotice("Error: No more page to change.", 2);
                nowPage = _tempPage;
            }
        }

        public void showPage() {
            visualValueUpdate();
            visualToolsVisibleSet();
            visualToolsInit();
        }
        private void visualToolsInit() {
            for (int i = 0; i < 5; i++) {
                labelList[i].Location = labelListStartLocation[i];
                isLabelMenuOffseting[i] = false;
                lableMenuOffsetStatus[i] = false;
                isPageOffseting = false;
            }
        }

        private void visualToolsVisibleSet() {
            for (int i = 0; i < 5; i++) {
                labelList[i].Visible = labelList[i].Text == "null" ? false : true;
                btn_delList[i].Visible = labelList[i].Text == "null" ? false : true;
                btn_editList[i].Visible = labelList[i].Text == "null" ? false : true;
            }
        }

        private void visualValueUpdate() {
            int _count = 0;
            foreach (TaskItem x in ItemList.getInstance().getListByPage(nowPage)) {
                if (x.Title != "") {
                    labelList[_count].Text = x.Title;
                    labelList[_count].BackColor = x.isStar ? Color.Orange : Color.WhiteSmoke;
                }
                _count++;
            }
            pageIndex.Text = pageIndexTextList[nowPage - 1];
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
                _tempSpeed = _tempCount/4 * LabelOffsetAcceleration + 1;
            for (int i = 0; i < 5; i++) {
                if (isLabelMenuOffseting[i] && _tempCount <= 30) {
                    labelList[i].Location = new Point(labelList[i].Location.X + (lableMenuOffsetStatus[i] ? _tempSpeed : -_tempSpeed), labelList[i].Location.Y);
                    if (_tempCount == 30) {
                        isLabelMenuOffseting[i] = false;
                        lableMenuOffsetStatus[i] = !lableMenuOffsetStatus[i];
                    }
                }
            }
        }


        public void mainForm_PageOffsetByTimer(int tickCount) {
            int _tempCount = tickCount - pageOffsetStartTick,
                _tempSpeed = _tempCount < 16 ? 25 : 25 - PageOffsetAcceleration * (_tempCount - 12)/2;
            if (isPageOffseting) {
                if (_tempCount != 12) {
                    foreach (Label x in labelList) {
                        x.Location = new Point(x.Location.X + (isPageOffsetTurnLeft ? -_tempSpeed: _tempSpeed), x.Location.Y);
                    }
                    if(_tempCount != 0&& labelList[0].Location == labelListStartLocation[0])
                        showPage();
                } else {
                    foreach (Label x in labelList) {
                        x.Location = new Point(isPageOffsetTurnLeft ? 445 : -445, x.Location.Y);
                    }
                    visualValueUpdate();
                    visualToolsVisibleSet();
                    for (int i = 0; i < 5; i++) {
                        btn_delList[i].Visible = false;
                        btn_editList[i].Visible = false;
                    }
                }
                if (_tempCount == 35) {
                    showPage();
                }
            }
        }
        public void editForm_inputOutOfMaxLength() {
            sendNotice("Error:Input out of max length", 2);
        } 
    }
}
