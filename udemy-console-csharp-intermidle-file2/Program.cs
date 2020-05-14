using System;
using System.IO;

namespace udemy_console_csharp_intermidle_file2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;


            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }
        }
    }
}
