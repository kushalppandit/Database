using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS_WebForm
{
    public class User
    {
        public User(int id, string uid, string password, string name)
        {
            this.id = id;
            this.uid = uid;
            this.password = password;
            this.name = name;
        }

        public int id { get; set; }
        public string uid { get; set; }
        public string password { get; set; }
        public string name { get; set; }
    }
}