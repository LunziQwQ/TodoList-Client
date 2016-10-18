using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList {
    class ItemList {
        private int length;
        private TaskItem[] list;

        public int Length {
            get { return length; }
        }

        private TaskItem[] List {
            get { return list; }
        }

        public bool init() {
            bool allSuccess = true;
            if (FileManager.getInstance().readSaveFile()) {
                string[] contentList = FileManager.getInstance().SaveContent.Split(new char[] { '\n' });
                length = contentList.Length;
                list = new TaskItem[length];
                for (int i = 0; i < length; i++) {
                    list[i] = new TaskItem();
                    if(!list[i].stringToItem(contentList[i]))
                        allSuccess = false;
                }
                return allSuccess ? true : false;
            } else return false;
        }

        public string listToString() {
            string temp = "";
            foreach (TaskItem item in list) 
                temp += item.itemToString();
            return temp;
        }
    }
}
