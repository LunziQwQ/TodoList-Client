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
        private const string Mysql_server = "119.29.149.254";               //服务器地址
        private const string Mysql_username = "todolist_tester";            //访问数据库的用户名
        private const string Mysql_password = "todolisttest233";            //访问数据库的密码
        private const string Mysql_database = "todolist_test";              //要访问的数据库
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


        //新增用户
        public void insert() {
            string QueryStr = String.Format(
                "INSERT INTO todolists (username,password,todo) VALUES ('{0}','{1}','{2}')"
                ,Username,Password,"");
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

        //将本地缓存中的todo上传到Mysql中
        public void cloudSync_Upload(string saveContent) {
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

        //将Mysql储存的todo下载下来
        public void cloudSync_Download() {
            string QueryStr = String.Format(
                "SELECT todo FROM todolists WHERE username = '{0}' and password = '{1}'", 
                Username, Password);
            try {
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
                MySqlCommand mysqlCommand = new MySqlCommand(QueryStr);
                mysqlCommand.Connection = mysqlConnection;
                mysqlConnection.Open();
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                if (rdr.Read()) {
                    FileManager.getInstance().SaveContent = rdr[0].ToString();
                }else {
                    MessageBox.Show("todo not found in table.");
                }
            }catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //查询用户是否存在
        public bool findUser() {
            try {
                string QueryStr = String.Format("SELECT username FROM todolists WHERE username='{0}'", Username);
                MySqlConnection mysqlConnection = new MySqlConnection(ConnectStr);
                MySqlCommand mysqlCommand = new MySqlCommand(QueryStr);
                mysqlCommand.Connection = mysqlConnection;
                mysqlConnection.Open();
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                if(rdr.Read()) {
                    rdr.Close();
                    mysqlCommand.Connection.Close();
                    return true;
                }else {
                    Debug.Print("-->Class:MysqlConnector, Line: 67 \n User not found.\n");
                    rdr.Close();
                    mysqlCommand.Connection.Close();
                    return false;
                }
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
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
                        MessageBox.Show("Wrong password.");
                    }
                }else {
                    MessageBox.Show("Username not found.");
                    
                }
                rdr.Close();
                mysqlConnection.Close();
                return false;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        
    }
}
