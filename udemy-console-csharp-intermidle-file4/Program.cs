using System;
using System.IO;
using System.Collections.Generic;

namespace udemy_console_csharp_intermidle_file4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\";



            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }


                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\NewFolder2");



            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
