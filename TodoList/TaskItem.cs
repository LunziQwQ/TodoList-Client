using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList {
    class TaskItem {
        private const int maxTitleLength = 30;
        private const int maxTextLength = 255;

        private string title;
        private string moreText;
        public bool isStar;
        public int index;

        public string Title {
            get { return title; }
            set {
                if (value.Length <= maxTitleLength)
                    title = value;
                else
                    VisualManager.getInstance().sendNotice("Error:Title out of the MaxTitleLength.");
            }
        }

        public string MoreText {
            get { return moreText; }
            set {
                if (value.Length <= maxTextLength)
                    moreText = value;
                else
                    VisualManager.getInstance().sendNotice("Error:Text out of the MaxTextLength.");
            }
        }
    }
}
