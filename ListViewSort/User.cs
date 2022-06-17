using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSort
{
    internal class User
    {
        public string name { get; set; }
        public string country { get; set; }
        public int age { get; set; }

        public User(string name, string country, int age)
        {
            this.name = name;
            this.country = country;
            this.age = age;
        }

    }
}
