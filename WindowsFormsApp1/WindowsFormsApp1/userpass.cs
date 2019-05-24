using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class userpass
    {
        private string username,username1;
        private string password,password1;

        public void setUser(string a)
        {
            this.username = a;
        }
        public string getUser()
        {
            return username;
        }
        public void setUser1(string b)
        {
            this.username1 = b;
        }
        public string getUser1()
        {
            return username1;
        }
        public void setPass(string a)
        {
            this.password = a;
        }
        public string getPass()
        {
            return password;
        }
        public void setPass1(string b)
        {
            this.password1 = b;
        }
        public string getPass1()
        {
            return password1;
        }
  
    }
}
