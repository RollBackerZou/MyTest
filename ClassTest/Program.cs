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
            //Person p = new Student();
            //p.Say();
            //Student s = new Student();
            //s.Say();
            //Person pp = new Person();
            //pp.Say();
            //var stu = p as Person;
            //stu.Say();

            //var b = new B();
            //b.PrintFields();
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

            #region 

            Number num = new Number();
            Console.WriteLine("第0次");
            num.ShowNum();
            IntNumber intnum = new IntNumber();
            Console.WriteLine("第一次");
            intnum.ShowNum();
            Console.WriteLine("第二次");
            intnum.ShowInfo();

            Number number = new IntNumber();
            Console.WriteLine("第三次");
            number.test();
            Console.WriteLine("第四次");
            number.ShowInfo();
            Console.WriteLine("第五次");
            number.ShowNum();
            #endregion
            Console.ReadKey();
        }
    }

    class Number
    {
        public Number()
        {
            Console.WriteLine("我是父类的构造函数");
        }
        public void test()
        {
            Console.WriteLine("纯测试");
        }
        public static int i = 123;
        public virtual void ShowInfo()
        {
            Console.WriteLine("base class.....");
        }
        public virtual void ShowNum()
        {
            Console.WriteLine(i.ToString());
        }
    }
    class IntNumber : Number
    {
        public IntNumber()
        {
            Console.WriteLine("我是子类的构造函数");
        }
        public void test()
        {
            Console.WriteLine("纯测试子类");
        }
        new public static int i = 456;
        public new virtual void ShowInfo()
        {
            Console.WriteLine("son class.....");
        }
        public override void ShowNum()
        {
            Console.WriteLine("base num is {0}", Number.i.ToString());
            Console.WriteLine("new num is {0}", i.ToString());
        }

    }
    class A
     {
          public A(){
                PrintFields();
           }

          public virtual void PrintFields(){}
      }

    class B : A
    {
        int x = 1;
        int y;
        public B()
        {

            y = -1;

        }

        public override void PrintFields()
        {

            Console.WriteLine("x={0},y={1}", x, y);

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
        public new void Say()
        {
            Console.WriteLine("我是子类");
        }
    }
}
