using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList{
    class Account:User{
        private string encryptedPassword;   //加密后的密码

        private static Account instance;
        private Account() { }
        public static Account getInstance() {
            if(instance == null) {
                instance = new Account();
            }
            return instance;
        }

        private MysqlConnector mysqlConnector = MysqlConnector.getInstance();

        //加密密码
        //private string encryptPassword(string password) {
        //
        //    return password;
        //}
    }
}
