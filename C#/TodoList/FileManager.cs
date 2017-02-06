using System;
using System.IO;
using System.Diagnostics;

namespace TodoList {
    class FileManager {
        private string autoSavePath = @"C:\Users\" + System.Environment.UserName + @"\Documents\TodoList_AutoSave\";
        private string AutoSavePath {
            get {
                if (!Directory.Exists(autoSavePath))                //如果路径文件夹不存在，先创建一个
                    Directory.CreateDirectory(autoSavePath);
                if (MysqlConnector.getInstance().Username != null)  //登录成功后Username非null后将会使用以Username作为缓存文件的文件名
                    return autoSavePath + MysqlConnector.getInstance().Username + ".tdl";
                else
                    return autoSavePath + "default.tdl";            //未登录状态下Username为null，将使用“default”作为缓存文件的文件名
            }
        }

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
                if (!File.Exists(AutoSavePath))
                    File.WriteAllText(AutoSavePath, "");
                saveContent = File.ReadAllText(AutoSavePath);
            }catch(Exception e) {
                Debug.Print("-->Class:FileManager, Line: 31 \n "+e.Message+"\n");
                return false;
            }
            return true;
        }

        public bool autoSave() {
            saveContent = ItemList.getInstance().listToString();
            try {
                File.WriteAllText(AutoSavePath, saveContent);
                //Account.getInstance().mysqlConnector.cloudSync_Download();
                //Account.getInstance().mysqlConnector.cloudSync_Upload(saveContent);
            }catch (Exception e) {
                Debug.Print("-->Class:FileManager, Line: 42 \n" + e.Message + "\n");
                return false;
            }
            return true;
        }
    }
}
