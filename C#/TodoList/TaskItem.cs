using System;
using System.Diagnostics;

namespace TodoList {
    class TaskItem {
        public const int maxTextLength = 255;

        private string title;
        private string moreText;
        public bool isStar;
        public int index;

        public TaskItem() {
            title = "Please edit the new item";
            moreText = "";
        }
        public TaskItem(bool isNull) {
            title = "null";
            moreText = "";
        }

        public string Title {
            get { return title; }
            set { title = value;}
        }

        public string MoreText {
            get { return moreText; }
            set {
                if (value.Length <= maxTextLength)
                    moreText = value;
            }
        }
        public bool stringToItem(string itemContent) {
            string[] temp = itemContent.Split(new char[] {'&'});
            try {
                index = Int32.Parse(temp[0].Substring(6));
                isStar = Boolean.Parse(temp[1].Substring(7));
                title = temp[2].Substring(6);
                moreText = temp[3].Substring(9);
            }catch(Exception e) {
                Debug.Print("-->Class:TaskItem, Line: 51 \n"+e.Message+"\n");
                return false;
            }
            return true;
        }

        public string itemToString() {
            return String.Format("index:{0}&isStar:{1}&title:{2}&moreText:{3}#", index, isStar, title, MoreText);
        }
    }
}
