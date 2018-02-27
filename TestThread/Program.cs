using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    class Program
    {
        static AutoResetEvent autoResetWork = new AutoResetEvent(false);
        static AutoResetEvent autoResetMain = new AutoResetEvent(false);

       
        static void Main(string[] args)
        {
            TestParallel();
            //Console.WriteLine("开始，AutoResetEvent 同步");

            //string threadName = "线程 1";
            //var t = new Thread((() => working(threadName, 10)));

            //t.Start();
            //Console.WriteLine("开始，第一次工作");


            //autoResetWork.WaitOne();//万事俱备只欠东风，事情卡在这里了，

            //Console.WriteLine("第一次工作完成");
            //Console.WriteLine("主线程操作，准备发信号");
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            ////发信号，说明值已经被写进去了。这里的意思是说Set是一个发信号的方法。

            //autoResetMain.Set();
            //Console.WriteLine("现在运行第二次工作。");
            //autoResetWork.WaitOne();
            //Console.WriteLine("第二次工作完成");
            Console.Read();
        }

        static void working(string name, int seconds)
        {
            Console.WriteLine("{0} 开始运行工作", name);
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine("{0}  正在工作。。。。。。",
              name);
            //发信号，说明值已经被写进去了。这里的意思是说Set是一个发信号的方法。

            autoResetWork.Set();
            Console.WriteLine("等待主线程完成工作，并发出信号");
            autoResetMain.WaitOne();
            Console.WriteLine("主线程发来信号，开始第二次工作");
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine("{0} 第二次工作正在进行中。。。。。", name);
            autoResetWork.Set();
        }

        static void ParallelForeach()
        {
            List<int> testList = new List<int>() { 1,55,25,11,556,57,14};
            Parallel.ForEach(testList, item => {
                Console.WriteLine(item);
            });
        }
        static void TestParallel()
        {
            Parallel.For(1, 100, (index,loopstate) =>
                {
                    if(index<50)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        loopstate.Stop();
                    }
                }
                );
        }
    }
}
