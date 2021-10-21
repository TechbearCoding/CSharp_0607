using System;
using System.Text.Json;

namespace Day24_json
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Sample1()
        {
            Student st = new Student();
            st.InitStudent("Juris", "Abele", 2);

            String jsonString = JsonSerializer.Serialize(st);

            Console.WriteLine(jsonString);

            Student st2 = JsonSerializer.Deserialize<Student>(jsonString);
            st2.Print();
        }
    }
}
