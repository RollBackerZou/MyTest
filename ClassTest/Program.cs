using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.Say();

            var stu = p as Person;
            stu.Say();

            Console.ReadKey();
        }

        public class Person
        {
           public void Say()
           {
               Console.WriteLine("我是父类");
           }
        }

        public class Student : Person
        {
            public void Say()
            {
                Console.WriteLine("我是子类");
            }
        }
    }
}
