using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;
namespace TodoList {
    class Sync {
        private VisualManager visualManager = VisualManager.getInstance();
        private const int serverPort = 5299;      //远程服务器端口号
        private IPAddress serverIP = IPAddress.Parse("119.29.115.127");
        private string token = null;
        private bool isLogin = false;

        #region 实现单例模式
        private Sync() { }
        private static Sync instance;
        public static Sync getInstance() {
            if (instance == null)
                instance = new Sync();
            return instance;
        }
        #endregion

        private const string cmdTemplet_CUK = "{{\"command\":\"{0}\",\"name\":\"{1}\",\"keyword\":\"{2}\"}}";

        //初始化Socket
        private Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

        public bool connectToServer() {
            try {
                socket.Connect(new IPEndPoint(serverIP, serverPort));
            } catch (Exception e) {
                Debug.Print(e.Message);
                visualManager.sendNotice("Connect to server failed.", 2);
                visualManager.sendNotice("Please check your internet status", 2);
                return false;
            }
            visualManager.sendNotice("Connect to server success", 2);
            return true;
        }

        private Command sendCommand(Command cmd) {
            socket.Send(Encoding.UTF8.GetBytes(cmd.toJsonText()));
            byte[] receive = new byte[1024];
            int receiveLength = socket.Receive(receive);
            string receiveStr = Encoding.UTF8.GetString(receive, 0, receiveLength);
            return Command.praseJsonText(receiveStr);
        }

        public bool login(string username, string keyword) {
            Command login = new Command("login", username, keyword);
            Command result = sendCommand(login);
            isLogin = result.isSuccess == "true";
            token = isLogin ? result.token : null;
            return isLogin;
        }

        public bool create(string username, string keyword) {
            Command create = new Command("create", username, keyword);
            Command result = sendCommand(create);
            return result.isSuccess == "true";
        }

        public string getData() {
            if (!isLogin || token == null) {
                Debug.Print("Not login. Can't getData. ");
                return null;
            }
            Command getData = new Command("getData", token);
            Command result = sendCommand(getData);
            return result.data;
        }

        public bool saveData(string data) {
            if (!isLogin || token == null) {
                Debug.Print("Not login. Can't saveData. ");
                return false;
            }
            Command saveData = new Command("saveData", data, token);
            Command result = sendCommand(saveData);
            return result.isSuccess == "true";
        }

        public bool logout() {
            if (!isLogin || token == null) {
                Debug.Print("Not login. Can't logout. ");
                return false;
            }
            Command logout = new Command("logout", token);
            Command result = sendCommand(logout);
            if(result.isSuccess == "true") {
                isLogin = false;
                token = null;
            }
            return !isLogin;
        }
    }
}
