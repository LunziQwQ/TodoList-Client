using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList {
    class ItemList {
        private int length;
        private TaskItem[] list;

        private static ItemList instance;
        private ItemList() { }

        public static ItemList getInstance() {
            if (instance == null)
                instance = new ItemList();
            return instance;
        }

        //外部只读，只允许内部初始化
        public int Length {
            get { return length; }
        }

        private TaskItem[] List {
            get { return list; }
        }

        public bool init() {
            if (FileManager.getInstance().readSaveFile()) {
                string[] contentList = FileManager.getInstance().SaveContent.Split(new char[] { '#' });
                length = contentList.Length - 1;
                list = new TaskItem[length];
                for (int i = 0; i < length; i++) {
                    list[i] = new TaskItem();
                    if (!list[i].stringToItem(contentList[i]))
                        return false;
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
            TaskItem[] _tempList = new TaskItem[5];
            int _count = 0;
            if (length >= page * 5 && page >= 1 && page <= 5)
                for (int i = page * 5 - 1; i < 5 * page; i++) {
                    if (i > length)
                        _tempList[_count] = i < length ? list[i] : new TaskItem(false);
                    _count++;
                } else VisualManager.getInstance().sendNotice("Error:No more page to change.", 3);
            return _tempList;
        }
    }
}