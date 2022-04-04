using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Models
{
    internal class Account
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        
        public string ShowInfo()
        {
            return $@"Name-{Name}
E-Mail-{EMail}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
