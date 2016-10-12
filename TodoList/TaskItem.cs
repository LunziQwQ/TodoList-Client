using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList {
    class TaskItem {
        private static int maxTitleLength = 30;
        private static int maxTextLength = 255;

        private string title;
        private string moreText;
        private bool isStar;

        public string Title {
            get { return title; }
            set {
                if (value.Length >= maxTitleLength) {
                    
                }
            }
        }
    }
}
