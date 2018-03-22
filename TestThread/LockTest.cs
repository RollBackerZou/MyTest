using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    public class LockTest
    {
        static LockTest instance = new LockTest(100);
        public static LockTest Instance { get { return instance; } }
        static object obj = new object();
        int balance;
        public LockTest(int initial)
        {
            balance = initial;
        }

        public void Sub(int amount)
        {
            if(balance>amount)
            {
                lock(obj)
                {
                    balance = balance - amount;
                    Console.WriteLine(balance);
                }
            }
        }
        
        public void DoAct()
        {
            Sub(new Random().Next(0,100));
        }

        public void RunThread()
        {
            Thread thread = new Thread(new ThreadStart(DoAct));
            //Thread thread = new Thread(new ThreadStart(() => {
            //    Sub(new Random().Next(0, 100));
            //}));
            thread.Start();
        }

    }
}
