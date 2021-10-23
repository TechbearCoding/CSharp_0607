using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Day25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework.Rakstitajs();
            List<User> lstUsr = new List<User>();
            lstUsr.Add(new User());
            lstUsr[0].InitUser("user", "user", "user", "user", 2011);

            lstUsr.Add(new User());
            lstUsr[1].InitUser("user2", "user2", "user2", "user2", 2012);

            String jsonString = JsonSerializer.Serialize(lstUsr);
            Console.WriteLine(jsonString);


            List<User> lstUsr2 = JsonSerializer.Deserialize<List<User>>(jsonString);

            Console.WriteLine(lstUsr2[0].name);
        }
    }
}
