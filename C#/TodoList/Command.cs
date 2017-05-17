using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TodoList {
    class Command {
        public string command;
        public string name;
        public string keyword;
        public string token;
        public string data;
        public string message;
        public string isSuccess;

        public Command() { }

        public Command(string command) {
            this.command = command;
        }

        public Command(string command, string token):this(command) {
            this.token = token;
        }

        public Command(string command, string name_data, string keyword_token):this(command) {
            if(command == "saveData") {
                this.data = name_data;
                this.token = keyword_token;
            } else {
                this.name = name_data;
                this.keyword = keyword_token;
            }
        }
        public string toJsonText() {
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.NullValueHandling = NullValueHandling.Ignore;
            return JsonConvert.SerializeObject(this, setting);
        }

        public static Command praseJsonText(string jsonText) {
            return JsonConvert.DeserializeObject<Command>(jsonText);
        }
    }
}
