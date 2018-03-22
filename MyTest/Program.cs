using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {

            HashPractice hp = new HashPractice();
            hp.HashTableMethod();


            //var list = Enum.GetNames(typeof(TestEnum)).ToList();
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //string s = "a , -- b";
            //string[] array = s.Split(new char[]{' ',',','-'},StringSplitOptions.RemoveEmptyEntries);
            //foreach(var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
            //IAnimal animal = new Animal();
            //animal.Dog();
            //using (FileStream fs = new FileStream(@"C:\TestMine\teststream.txt", FileMode.OpenOrCreate))
            //{
            //    byte[] data = new byte[fs.Length];
            //    fs.Read(data, 0, data.Length);
            //    foreach (var item in data)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadKey();
            //    // fs.Write(bytes, 0, bytes.Length);
            //}

        }

        public enum TestEnum
        {
            dog,
            pig,
            pm,
        }

        public static void Swap<T>(ref T o1,ref T o2)
        {
            T temp = o1;
            o1 = o2;
            o2 = temp;
        }


        public static string ProcessFoo()
        {
            int[] list = new int[10];
            string result = string.Empty;
            for (var i = 0; i < list.Length;i++)
            {
                result += Foo(i) + ",";
            }
            return result;
        }
        public static int Foo(int i)
        {
            if(i==0 || i==1)
            {
                return i + 1;
            }
            else
            {
                return Foo(i - 1) + Foo(i - 2);
            }
        }

        interface IAnimal
        {
            void Dog();
        }
        public class Animal : IAnimal
        {
            void IAnimal.Dog()
            {
                Console.Write("dog");
            }
        }
    }
}
