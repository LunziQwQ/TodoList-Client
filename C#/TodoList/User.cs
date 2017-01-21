using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList{
    class User{
        private string userName;    //用户名
        private string password;    //密码

        public string UserName {
            get { return userName; }
            set { userName = value; }
        }
        public string Password {
            get { return password; }
            set { password = value; }
        }
    }
}
