using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace TodoList {
    class VisualManager {

        private const int
            taskItemLabel_Heigth = 80,      //每个项目Item高度            
            LabelOffsetAcceleration = 1,    //项目Item动画加速度
            PageOffsetAcceleration = 1;     //翻页动画加速度

        //淡入淡出动画加速度
        private const double fadeAcceleration = 0.003;

        private int
            menuOffsetStartTick,            //Item动画的开始Tick
            pageOffsetStartTick,            //翻页动画的开始Tick
            moreTextFormShowStartTick,      //moreText窗口开始显示的Tick
            moreTextFormHideStartTick,      //moreText窗口开始隐藏的Tick
            moreTextFormAliveTime = 300,    //moreText窗口满透明度生存时间
            nowPage = 1;            //当前主窗口所在页码
        public int
            mainForm_nowTick,               //主窗口的计时器Tick
            nowNoticeFormCount = 0;         //当前已存在的消息窗口数量

        //当前已占用的消息窗口位置 true:正在占用 false:空闲
        public bool[] isNoticeFormLocationExist = new bool[5];
        public bool 
            isCloseAllForm = false,         //当前是否为点击关闭按钮后触发的消息窗口
            isPageOffseting = false,        //当前是否在进行翻页动画
            isMouseItemHover = false;       //当前鼠标是否在Hover Item 
        private bool[]
            isLabelMenuOffseting = new bool[5],     //各个Item动画是否正在进行
            lableMenuOffsetStatus = new bool[5];    //各个Item动画当前位置 ture:Offseted   false:Origin
        private bool isPageOffsetTurnLeft = false;  //当前翻页动画方向

        public MainForm visualMain;             //主窗口实例
        public NoticeForm visualNotice;         //最新通知窗口实例 
        public MoreTextForm visualMoreText;     //详情实例

        //主窗口的五个编辑，删除按钮以及Item列表
        public Label[] 
            btn_delList, 
            btn_editList, 
            labelList;
        public Label
            pageIndex,                  //主窗口的页码label
            moreTextLabel;              //moreText窗口的Label

        public Point[] labelListStartLocation;  //五个项目Item的label初始位置

        //页码Label各页的文本列表
        private string[] pageIndexTextList =  {
            "1  ·  ·  ·  · ",
            "·  2  ·  ·  · ",
            "·  ·  3  ·  · ",
            "·  ·  ·  4  · ",
            "·  ·  ·  ·  5 ",
        };

        #region 实现单例模式
        private VisualManager(){}
        private static VisualManager instance;
        public static VisualManager getInstance() {
            if (instance == null)
                instance = new VisualManager();
            return instance;
        }
        #endregion

        //显示通知窗口并显示通知消息
        public void sendNotice(string text, int aliveTime) {
            if (nowNoticeFormCount == 5) return;
            MessageNotice.getInstance().MessageText = text;
            MessageNotice.getInstance().AliveTime = aliveTime;
            visualNotice = new NoticeForm();
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

        #region 点击窗口非控件区域时拖动窗口改变窗口位置*****************
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
        #endregion

        //主窗口翻页，激活翻页Flag
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

        #region 页面初始化，信息更新，控件复位
        //初始化页面
        public void showPage() {
            visualValueUpdate();
            visualToolsVisibleSet();
            visualToolsInit();
        }

        //初始化所有动画及控件位置
        private void visualToolsInit() {
            for (int i = 0; i < 5; i++) {
                labelList[i].Location = labelListStartLocation[i];
                isLabelMenuOffseting[i] = false;
                lableMenuOffsetStatus[i] = false;
                isPageOffseting = false;
            }
        }

        //根据获得的ItemList决定控件是否显示
        private void visualToolsVisibleSet() {
            for (int i = 0; i < 5; i++) {
                labelList[i].Visible = labelList[i].Text == "null" ? false : true;
                btn_delList[i].Visible = labelList[i].Text == "null" ? false : true;
                btn_editList[i].Visible = labelList[i].Text == "null" ? false : true;
            }
        }

        //根据获得的ItemList更新控件信息
        public void visualValueUpdate() {
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
        #endregion

        #region Item增删查改，变更isStar状态

        public void addItem() {
            ItemList.getInstance().addItem();
            visualValueUpdate();
            visualToolsVisibleSet();
        }

        public void delItem(int index) {
            ItemList.getInstance()
                .delItme(getItemByVisualIndex(index).index);
            showPage();
        }

        public TaskItem getItemByVisualIndex(int index) {
            return ItemList.getInstance().getListByPage(nowPage)[index];
        }

        public void editItem(int index) {
            ItemEditForm visualEdit = new ItemEditForm(index, nowPage);
            visualEdit.Show();
        }
        public void changeIsStar(int index) {
            ItemList.getInstance()
                .changeIsStar(getItemByVisualIndex(index).index);
        }
        #endregion

        //右键ItemLabel时触发动画位移，检查使已位移的控件复位
        public void item_mouseClick(int item_index) {
            for(int i= 0; i < 5; i++) {
                if (isLabelMenuOffseting[i]) {
                    sendNotice("Error:Menu is offsetting now.", 2);
                    return;
                } else if (lableMenuOffsetStatus[i]) {
                    item_index = i;
                    break;   
                }
            }
            menuOffsetStartTick = mainForm_nowTick;
            Debug.Print("VM.cs line:219-->" + (item_index).ToString());
            isLabelMenuOffseting[item_index] = true;
        }

        #region About the MoreTextForm
        
        public void moreTextForm_changeLocation() {
            visualMoreText.Location = new Point(
                visualMain.Location.X - visualMoreText.Size.Width,
                visualMain.Location.Y
                );
        }

        public void moreTextForm_init() {
            visualMoreText = new MoreTextForm();
            moreTextForm_changeLocation();
            visualMoreText.Show();
            visualMoreText.Opacity = 0;
        }
        public void moreTextForm_fadeByTick() {
            int _tick = visualMoreText.tickCount;
            if (isMouseItemHover) moreTextFormAliveTime = 300;
            switch (visualMoreText.status) {
                case 0:
                    int fadeInTick = _tick - moreTextFormShowStartTick;
                    visualMoreText.Opacity += 0.02 + fadeAcceleration * fadeInTick;
                    if (visualMoreText.Opacity >= 1) {
                        visualMoreText.status = 1;
                        visualMoreText.Opacity = 1;
                    }
                    break;
                case 1:
                    moreTextFormAliveTime--;
                    if (moreTextFormAliveTime == 0)
                        visualMoreText.status = 2;
                    break;
                case 2:
                    int fadeOutTick = _tick - moreTextFormHideStartTick;
                    visualMoreText.Opacity -= 0.02 *- fadeAcceleration * (50 - fadeOutTick);
                    if (visualMoreText.Opacity <= 0) {
                        visualMoreText.Opacity = 0;
                        visualMoreText.status = 3;
                    }
                    break;
                case 3:
                    moreTextFormAliveTime = 300;
                    visualMoreText.status = 3;
                    break;
            }
        }
          
        public void item_mouseHover(int index) {
            string _temp = getItemByVisualIndex(index).MoreText;
            moreTextLabel.Text = _temp.Length > 0 ? _temp : "No more text. Please click right this item to add it.";

            isMouseItemHover = true;
            if (visualMoreText.status == 3) {
                moreTextFormShowStartTick = visualMoreText.tickCount;
                visualMoreText.status = 0;
            }
            if (visualMoreText.status == 2) {
                moreTextFormHideStartTick = -1;
                moreTextFormShowStartTick = visualMoreText.tickCount;
                visualMoreText.status = 0;
            }
            if (visualMoreText.status == 1)
                moreTextFormAliveTime = 300;
        } 

        public void item_mouseLeave(int index) {
            isMouseItemHover = false;
        }

        #endregion

        #region 主窗口动画实现，Item位移，翻页位移

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
        #endregion

    }
}