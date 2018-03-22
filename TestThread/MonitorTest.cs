using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    //public class MonitorTest
    //{
    //    private static Cell instance = new Cell();
    //    public static Cell Instance { get { return instance; } }
    //}

    public class MonitorTest
    {
        int cellContents;
        bool readFlag = false;
        
        public int ReadFromCell()
        {
            lock(this)
            {
                if (!readFlag)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (Exception)
                    {

                    }
                }

                Console.WriteLine("Consumer:{0}",cellContents);
                readFlag = false;
                Monitor.Pulse(this);
            }
            return cellContents;
        }

        public void WriteToCell(int n)
        {
            lock(this)
            {
                if(readFlag)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch(Exception)
                    {

                    }
                }

                cellContents = n;
                Console.WriteLine("Producer:{0}",cellContents);
                readFlag = true;
                Monitor.Pulse(this); //通知等待队列中的第一个线程开始执行
            }
        }
    }

    public class CellProcduer
    {
        MonitorTest cell;
        int counts;
        public CellProcduer(MonitorTest box, int request)
        {
            cell = box;
            counts = request;
        }

        public void ProcMethod()
        {
            for (var i = 1; i <= counts;i++)
            {
                cell.WriteToCell(i);
            }
        }
    }

    public class CellConsumer
    {
        MonitorTest cell;
        int counts;
        public CellConsumer(MonitorTest box, int request)
        {
            cell = box;
            counts = request;
        }

        public void ConsMethod()
        {
            for (var i = 1; i <= counts;i++)
            {
                cell.ReadFromCell();
            }
        }
    }
}
