using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

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
            #region IOC
            //实例化Ninject
            //IKernel kernel = new StandardKernel();
            //kernel.Bind<IDatabase>().To<SqlServer>();
            //var db = kernel.Get<IDatabase>();
            //kernel.Bind<IShow>().To<Showtest>();
            //kernel.Bind<DataManager>().ToSelf();
            //kernel.Get<DataManager>().Show();
            //db.Add();
            #endregion
            Console.ReadKey();
        }
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
