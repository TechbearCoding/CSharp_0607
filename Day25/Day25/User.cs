using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25
{
    class User
    {
        public String userName { get; set; }
        public String passWord { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public int year { get; set; }

        public void InitUser(String userName, String passWord, String name, String lastName, int year)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.name = name;
            this.lastName = lastName;
            this.year = year;
        }

        public override string ToString()
        {
            return "Izvada info";
        }


    }
}
