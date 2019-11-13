using System;
using System.IO;

namespace ConsoleApp1
{
   
    class ReadBinaryFile
    {
        public static void ReadFile()
        {
            int nextByte;
            string path = @"C:\Users\Admn\Downloads\1.UNRST";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {           
                //Выводим header    
                fs.Seek(4, SeekOrigin.Begin);
                while ((nextByte = fs.ReadByte()) > 0)
                {
                    Console.Write(Convert.ToChar(nextByte));
                }
                Console.WriteLine();
                //Выводим число элементов элементов
                fs.Seek(8, SeekOrigin.Begin);
                while ((nextByte = fs.ReadByte()) > 0)
                {
                    Console.Write(Convert.ToInt32(nextByte));
                }
                Console.WriteLine();
                //Выводим тип данных
                fs.Seek(8, SeekOrigin.Begin);
                while ((nextByte = fs.ReadByte()) > 0)
                {
                    Console.Write(Convert.ToChar(nextByte));
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ReadFile();
            Console.ReadKey();
        }
    }
}
