using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace TodoList
{
    class MysqlConnector:User{
        private static string Mysql_server = "119.29.149.254";              //服务器地址
        private static string Mysql_username = "todolist_tester";            //访问数据库的用户名
        private static string Mysql_password = "todolisttest233";           //访问数据库的密码
        private static string Mysql_database = "todolist_test";             //要访问的数据库
        private string ConnectStr = String.Format(                          //远程连接Mysql所需要的信息
            "Data Source={0};User Id={1};Password={2};Database={3}",
            Mysql_server, Mysql_username, Mysql_password, Mysql_database);   

        private static MysqlConnector instance;
        private MysqlConnector() { }
        public static MysqlConnector getInstance() {
            if (instance == null) 
                instance = new MysqlConnector();
            return instance;
        }


        //测试mysql能否连接上
        public void insert() {
            string QueryStr = String.Format(
                "INSERT INTO todolists (username,password,todo) VALUES ('{0}','{1}','{2}')"
                ,Username,Password,"test");
            try {
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
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

        //将本地文件上传到Mysql中
        public void cloudSync(string saveContent) {
            string QueryStr = String.Format(
                "UPDATE todolists SET todo='{0}' WHERE username='{1}' and password='{2}'",
                saveContent, Username, Password);
            try {
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
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

        //查询用户是否存在
        public void selectUser() {
            try {
                string QueryStr = String.Format("SELECT username FROM todolists WHERE username='{0}'", Username);
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
                MySqlCommand mysqlCommand = new MySqlCommand(QueryStr);
                mysqlCommand.Connection = mysqlConnection;
                mysqlConnection.Open();
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                if(rdr.Read()) {
                    MessageBox.Show(rdr[0].ToString());
                }else {
                    MessageBox.Show("No this user");

                }
                rdr.Close();
                mysqlCommand.Connection.Close();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //对比密码
        public bool comparePassword(string password) {
            try {
                string QueryStr = String.Format("SELECT password FROM todolists WHERE username='{0}'", Username);
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
                MySqlCommand mysqlCommand = new MySqlCommand(QueryStr);
                mysqlCommand.Connection = mysqlConnection;
                mysqlConnection.Open();
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                if (rdr.Read()) {
                    if (password == rdr[0].ToString()) {
                        rdr.Close();
                        mysqlConnection.Close();
                        return true;
                    }else {
                        rdr.Close();
                        mysqlConnection.Close();
                        MessageBox.Show("wrong password");
                        return false;
                    }
                }else {
                    MessageBox.Show("user not found");
                    rdr.Close();
                    mysqlConnection.Close();
                    return false;
                }
            }catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
