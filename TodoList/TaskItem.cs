using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TodoList {
    class TaskItem {
        private const int maxTitleLength = 30;
        private const int maxTextLength = 255;

        private string title;
        private string moreText;
        public bool isStar;
        public int index;

        public TaskItem() { }
        public TaskItem(bool isNull) {
            title = "NULL";
        }

        public string Title {
            get { return title; }
            set {
                if (value.Length <= maxTitleLength)
                    title = value;
                else
                    VisualManager.getInstance().sendNotice("Error:TitleLength out of the MaxTitleLength.", 3);
            }
        }

        public string MoreText {
            get { return moreText; }
            set {
                if (value.Length <= maxTextLength)
                    moreText = value;
                else
                    VisualManager.getInstance().sendNotice("Error:TextLength out of the MaxTextLength.", 3);
            }
        }

        public bool stringToItem(string itemContent) {
            Debug.Print("--> Content: " + itemContent);
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
        
        public void show() {

        }
    }
}
