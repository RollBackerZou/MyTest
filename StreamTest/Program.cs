using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteText();
            //ReadText();
            CopyTxt();
            Console.ReadKey();
        }

        private static void WriteText()
        {
            string str = "Hello World";
            FileStream fs = new FileStream(@"C:\TestMine\MyTest\Test.txt",FileMode.OpenOrCreate);
            byte[] array = Encoding.Default.GetBytes(str);
            fs.Write(array,0,array.Length);
            fs.Close();
        }
        private static void ReadText()
        {
            FileStream fs = new FileStream(@"C:\TestMine\MyTest\Test.txt", FileMode.OpenOrCreate);
            byte[] array = new byte[fs.Length];
            fs.Read(array,0,array.Length);
            fs.Close();
            string str = Encoding.Default.GetString(array);
            Console.WriteLine(str);
        }


        private static void CopyTxt()
        {
            string originalTxt = @"D:\sql.txt";
            string newTxt = @"C:\newsql.txt";
            using(FileStream fsRead = File.Open(originalTxt,FileMode.Open,FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[1024 * 1024];
                using (FileStream fsWrite = File.Open(newTxt,FileMode.OpenOrCreate,FileAccess.ReadWrite))
                {
                    while(true)
                    {
                        int rel = fsRead.Read(buffer,0,buffer.Length);
                        if(rel==0)
                        {
                            break;
                        }
                        else
                        {
                            fsWrite.Write(buffer,0,rel);
                        }
                    }
                }
            }
            Console.WriteLine("Copy Success!");
        }

    }
}
