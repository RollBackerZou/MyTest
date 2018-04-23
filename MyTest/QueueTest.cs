using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyTest
{
    public class QueueTest
    {
        private static object obj = new object();
        public static readonly Queue queue = new Queue();
        public static void CreateOrder()
        {
            for (var i = 1; i <= 10; i++)
            {
                lock (obj)
                {
                    OrderInfo order = new OrderInfo()
                    {
                        OrderId = i,
                        Price = 10,
                        ProductId = i,
                        Remarks = "产品" + i,
                    };
                    queue.Enqueue(order);
                }
            }
        }

        public static void DealOrder()
        {
            int flag=0;
            while(true)
            {
                if(queue.Count>0)
                {
                    lock(obj)
                    {
                        if(queue.Count>0)
                        {
                            var temp =(OrderInfo)queue.Dequeue();
                            Console.WriteLine(temp.OrderId+"价格： "+temp.Price+" "+temp.Remarks);
                        }
                    }
                }
                else
                {                   
                    flag++;
                    Thread.Sleep(1000);
                    if(flag>5)
                    {
                        Console.WriteLine("出队成功");
                        break;
                    }
                }
            }
        }
    }



    public class OrderInfo
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Decimal Price { get; set; }
        public string Remarks { get; set; }
    }
}
