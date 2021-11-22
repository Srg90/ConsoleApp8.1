using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                            
            string path = @"C:/users/santa/source/repos/consoleapp2.1";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Путь до файла: {0}", path);
                Console.WriteLine("Указанная директория существует");
                Console.WriteLine();
                Console.WriteLine("Список подкаталогов:");
                Console.WriteLine();

                string[] dir = Directory.GetDirectories(path);
                foreach (string d in dir)
                {
                     Console.WriteLine(d);
                }
                
                Console.WriteLine();
                Console.WriteLine("Список файлов:");
                Console.WriteLine();

                string[] files = Directory.GetFiles(path);
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Console.WriteLine();
                Console.WriteLine("Содержимое подкаталогов:");
                Console.WriteLine();

                string[] dir1 = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string d1 in dir1)
                {

                    Console.WriteLine(d1);
                }

                Console.WriteLine();
                Console.WriteLine("Общий список файлов во всех директориях:");
                Console.WriteLine();

                string[] files2 = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string f2 in files2)
                {

                    Console.WriteLine(f2);
                }

            }
           

            //else
            //{
            //    Console.WriteLine("Такого пути к файлу не существует");
            //}
            Console.ReadKey();
        }
    }
}
