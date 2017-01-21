using System;
using System.IO;
using System.Diagnostics;

namespace TodoList {
    class FileManager {
        private MysqlConnector mysqlConnector = new MysqlConnector();

        private string autoSavePath = @"C:\Users\" + System.Environment.UserName + @"\Documents\TodoList_AutoSave.tdl";
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
                if (!File.Exists(autoSavePath))
                    File.WriteAllText(autoSavePath, "");
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
                //mysqlConnector.CloudSync(saveContent);
            }catch (Exception e) {
                Debug.Print("-->Class:FileManager, Line: 42 \n" + e.Message+"\n");
                return false;
            }
            return true;
        }
    }
}
