using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ThreadTest
{
    public class ThreadTest
    {
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(() => Console.WriteLine("1234")));
            Thread t2 = new Thread(new ParameterizedThreadStart(TestMethod));
            t1.IsBackground = true;
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
        
        public static void TestMethod(object data)
        {
            Console.WriteLine("5678");
        }
    }
}
