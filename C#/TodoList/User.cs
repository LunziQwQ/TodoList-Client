using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList{
    class User{
        private string username;    //用户名
        private string password;    //密码

        public string Username {
            get { return username; }
            set { username = value; }
        }
        public string Password {
            get { return password; }
            set { password = value; }
        }
    }
}
