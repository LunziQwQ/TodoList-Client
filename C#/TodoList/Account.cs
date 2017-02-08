using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TodoList{
    class Account : User {
        private static Account instance;
        public MysqlConnector mysqlConnector;
        public bool _signInStatus = false;


        private Account() {
            mysqlConnector = MysqlConnector.getInstance();
        }
        public static Account getInstance() {
            if (instance == null)
                instance = new Account();
            return instance;
        }

        public override string Password {
            get {
                return base.Password;
            }

            set {
                if (value != String.Empty)
                    base.Password = encryptPassword(value);
                else
                    MessageBox.Show("Password can not be empty!");
            }
        }

        #region 用MD5加密来加密密码
        private static string encryptPassword(string sourcePassword) {
            MD5 md5Hash = MD5.Create();
            //用md5加密2次确保安全性
            string hash_once = GetMd5Hash(md5Hash, sourcePassword);
            string hash_twice = GetMd5Hash(md5Hash, hash_once);
            return hash_twice;
        }

        
        private static string GetMd5Hash(MD5 md5Hash, string input) {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));   //将input字符串转换成byte数组然后计算hash值
            StringBuilder sBuilder = new StringBuilder();                       //StringBuilder类用于将byte数组转成string
            
            for(int i = 0; i < data.Length; i++)                                //遍历byte数组并且将这些已经hash了的值转成16进制
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }

        #endregion

        //将Account的用户名与密码传给MysqlConnector
        public void setAccount() {
            mysqlConnector.Username = Username;
            mysqlConnector.Password = Password;
        }

        //注册
        public bool signUp(string password_1, string password_2) {
            if (!mysqlConnector.findUser()) {       //如果没有重复用户
                if (password_1 == password_2) {     //如果两次输入的密码相同
                    mysqlConnector.insert();
                    return true;
                }else {
                    MessageBox.Show("The password you enter twice must be same.");
                    return false;
                }
            }else {
                MessageBox.Show("Username already signup.Please use another username.");
                return false;
            }
        }

        //登录
        public void signIn() {
            if (mysqlConnector.comparePassword(Password)) {
                _signInStatus = true;
                mysqlConnector.cloudSync_Download();    //登录后立马将mysql中储存的todo下载下来
            }else
                _signInStatus = false;
        }
    }
}
