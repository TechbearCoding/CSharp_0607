using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    class ListSamples
    {
        static String folderPath = @"C:\temp\";
        public static void Sample1()
        {
            String fileName = folderPath + "citati.txt";
            List<String> a = new List<String>();
            try
            {
                StreamReader reader = new StreamReader(fileName);
                String line = reader.ReadLine();
                while (line != null)
                {
                    a.Add(line);
                    line = reader.ReadLine();
                }

                reader.Close();

            }
            catch
            {
                Console.WriteLine("Fails neeksistē");
            }
        }
    }
}
