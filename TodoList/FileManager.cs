using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TodoList {
    class FileManager {
        private string autoSavePath = @"C:\Users\Public\Documents\TodoList_AutoSave.tdl";
        private string saveContent;

        private static FileManager instance;
        private FileManager() { }
        public static FileManager getInstance() {
            if (instance == null)
                instance = new FileManager();
            return instance;
        }

        public bool autoSave() {
            try {
                File.WriteAllText(autoSavePath, saveContent);
            }catch (Exception e) {
                return false;
            }
                return true;
        }
    }
}
