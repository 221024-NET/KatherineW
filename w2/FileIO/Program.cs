using System;
using System.IO;

namespace FileIO
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");

            string path = "./testFile.txt";

            string[] text = {"hi", "hello", "there", "hows", "it", "going?"};

            //File.WriteAllLines(path, text);
            //File.AppendAllLines(path, text);

            string[] content = File.ReadAllLines(path);

            foreach (string s in content)
            {
                Console.WriteLine(s);
            }
        }
    }
}