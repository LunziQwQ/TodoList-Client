using System;
using System.IO;
using System.Diagnostics;

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

        public string SaveContent {
            get { return saveContent; }
            set { saveContent = value; }
        }

        public bool readSaveFile() {
            try {
                saveContent = File.ReadAllText(autoSavePath);
            }catch(Exception e) {
                Debug.Print("-->Class:FileManager, Line: 31 \n "+e.Message+"\n");
                return false;
            }
            return true;
        }

        public bool autoSave() {
            saveContent = ItemList.getInstance().listToString();
            try {
                File.WriteAllText(autoSavePath, saveContent);
            }catch (Exception e) {
                Debug.Print("-->Class:FileManager, Line: 42 \n" + e.Message+"\n");
                return false;
            }
            return true;
        }
    }
}
