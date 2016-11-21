using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TodoList {
    class ItemList {
        private List<TaskItem> list = new List<TaskItem>();

        private static ItemList instance;
        private ItemList() { }

        public static ItemList getInstance() {
            if (instance == null)
                instance = new ItemList();
            return instance;
        }

        private List<TaskItem> List {
            get { return list; }
        }

        public bool init() {
            int _tempLength;
            if (FileManager.getInstance().readSaveFile()) {
                string[] contentList = FileManager.getInstance().SaveContent.Split(new char[] { '#' });
                _tempLength = contentList.Length - 1;
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
                _tempList[_count] = i < list.Count ? list[i] : new TaskItem(false);
                Debug.Print("list's Title-->"+_tempList[_count].Title);
                _count++;
            }
            return _tempList;
        }

        public void addItem() {
            TaskItem _tempItem = new TaskItem();
            _tempItem.index = list.Count;
            list.Add(_tempItem);
        }

        public void delItme(int _index) {
            list.Remove(getItemByIndex(_index));
        }

        public void editItem(int _index, string text) {
            getItemByIndex(_index).Title = text;
        }

        public void changeIsStar(int _index) {
            getItemByIndex(_index).isStar = !getItemByIndex(_index).isStar;
        }

        private TaskItem getItemByIndex(int _index) {
            Predicate<TaskItem> FindValue = delegate (TaskItem x) {
                return x.index == _index;
            };
            return list.Find(FindValue);
        }
    }
}