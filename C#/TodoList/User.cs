using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList{
    class User{
        private string username;    //用户名
        private string password;    //密码

        public string Username {
            get {
                return username;
            }

            set {
                if (value != String.Empty)
                    username = value;
                else
                    MessageBox.Show("Please enter the username.");
            }
        }
        public virtual string Password {
            get {
                return password;
            }
            set {
                if (value != String.Empty)
                    password = value;
                else
                    MessageBox.Show("Password can not be empty!");
            }
        }
    }
}
