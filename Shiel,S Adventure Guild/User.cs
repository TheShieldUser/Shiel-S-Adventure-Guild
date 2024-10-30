using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiel_S_Adventure_Guild
{
    internal class User
    {
        public User(string Username, string Password)
        {
            this.username = Username;
            this.password = Password;
            Class1 = Classes.notselected;
        }

        public string username { get; set; }

        public Classes Class1 { get; set; }

        public string password { get; set; }
        public string hum { get; set; }


    }
}
