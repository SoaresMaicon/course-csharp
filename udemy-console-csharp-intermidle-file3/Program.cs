using System;
using System.IO;

namespace udemy_console_csharp_intermidle_file3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            string TargetPath = @"c:\temp\file2.txt";


            try
            {

                //using (StreamReader sr = File.OpenText(path))
                //{
                //    while (!sr.EndOfStream)
                //    {
                //        String line = sr.ReadLine();
                //        Console.WriteLine(line);
                //    }
                //}

                string[] lines = File.ReadAllLines(path);
                using (StreamWriter sw = File.AppendText(TargetPath))
                {
                    foreach (String line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
