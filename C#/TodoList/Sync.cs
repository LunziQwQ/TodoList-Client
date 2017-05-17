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

        public bool login(string username, string keyword) {
            Command login = new Command("login", username, keyword);
            socket.Send(Encoding.UTF8.GetBytes(login.toJsonText()));

            byte[] receive = new byte[1024];
            int receiveLength = socket.Receive(receive);
            string receiveStr = Encoding.UTF8.GetString(receive, 0, receiveLength);
            Command result = Command.praseJsonText(receiveStr);

            return result.isSuccess == "true";
        }
        
    }
}
