using System;
using System.IO;

namespace Day20_FileIO
{
    class Program
    {
        static String folderPath = @"c:\temp\";
        static void Main(string[] args)
        {
            //WriteSample();
            ReadSample2();
        }

        static void ReadSample2()
        {
            String fileName = folderPath + "sample1.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);

                String line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }

                reader.Close();

            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }

        static void ReadSample1()
        {
            String fileName = folderPath + "sample1.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                String a = reader.ReadToEnd();
                reader.Close();
                Console.WriteLine(a);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
        static void WriteSample()
        {
            String fileName = folderPath + "sample1.txt";
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine("aa");
                writer.WriteLine("bb");
                writer.WriteLine("cc");
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
