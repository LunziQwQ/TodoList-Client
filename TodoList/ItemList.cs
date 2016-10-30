using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace TodoList {
    class ItemList {
        //private int length;
        private List<TaskItem> list = new List<TaskItem>();

        private static ItemList instance;
        private ItemList() { }

        public static ItemList getInstance() {
            if (instance == null)
                instance = new ItemList();
            return instance;
        }

        //外部只读，只允许内部初始化
        /*public int Length {
            get { return length; }
        }*/

        private List<TaskItem> List {
            get { return list; }
        }

        public bool init() {
            int _tempLength;
            if (FileManager.getInstance().readSaveFile()) {
                string[] contentList = FileManager.getInstance().SaveContent.Split(new char[] { '#' });
                _tempLength = contentList.Length - 1;
                Debug.Print("-->listLength:" + _tempLength.ToString());
                for (int i = 0; i < _tempLength; i++) {
                    TaskItem _tempItem = new TaskItem();
                    if (!_tempItem.stringToItem(contentList[i]))
                        return false;
                    list.Add(_tempItem);
                }
                return true;
            } else return false;
        }

        public string listToString() {
            string temp = "";
            foreach (TaskItem item in list)
                temp += item.itemToString();
            return temp;
        }

        public TaskItem[] getListByPage(int page) {
            //重构，将返回列表与判断是否合法分离，函数专一化
            TaskItem[] _tempList = new TaskItem[5];

            int _count = 0;
            for (int i = (page - 1) * 5; i < 5 * page; i++) {
                Debug.Print("-->" + list.Count);
                _tempList[_count] = i < list.Count ? list[i] : new TaskItem(false);
                Debug.Print("-->"+_tempList[_count].Title);
                _count++;
            }

            return _tempList;
        }

        public void addItem() {
            list.Add(new TaskItem());
        }
    }
}