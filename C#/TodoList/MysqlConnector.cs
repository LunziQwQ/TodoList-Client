using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TodoList{
    class MysqlConnector:User{
        string ConnectStr = "Data Source=119.29.149.254;User Id=todolist_tester;Password=todolisttest233;Database=todolist_test";   //远程连接Mysql所需要的信息

        private static MysqlConnector instance;
        private MysqlConnector() { }
        public static MysqlConnector getInstance() {
            if (instance == null) {
                instance = new MysqlConnector();
            }
            return instance;
        }

        //获取用户输入的用户名与密码
        //public void getAccount(string username, string password) {

        //}

        //测试mysql能否连接上
        public void connectionTest() {
            try {
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
                string QueryStr = "INSERT INTO connect_test(test) VALUES ('test2')";
                MySqlCommand mysqlCommand = new MySqlCommand(QueryStr);
                mysqlCommand.Connection = mysqlConnection;
                mysqlConnection.Open();
                mysqlCommand.ExecuteNonQuery();
                mysqlCommand.Connection.Close();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        //将本地文档同步到Mysql中
        public void cloudSync(string saveContent) {
            try{
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
                string QueryStr = "UPDATE todolists SET todo='"
                    + saveContent + "' WHERE username='username'";
                MySqlCommand mysqlCommand = new MySqlCommand(QueryStr);
                mysqlCommand.Connection = mysqlConnection;
                mysqlConnection.Open();
                mysqlCommand.ExecuteNonQuery();
                mysqlCommand.Connection.Close();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
