using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.IO;
namespace TodoList {
    class Sync {
        private VisualManager visualManager = VisualManager.getInstance();

        private const int serverPort = 5299;      //远程服务器端口号
        private IPAddress serverIP = IPAddress.Parse("119.29.115.127");

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
            string jsonText = String.Format("{{\"command\":\"{0}\",\"name\":\"{1}\",\"keyword\":\"{2}\"}}",
                    "login", username, keyword);
            socket.Send(Encoding.UTF8.GetBytes(jsonText));
            return true;
        }
        
    }
}
