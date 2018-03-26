using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ClassTest;

namespace MyTest
{
   public class RefelectTEST
    {
       public static void MyMethod()
       {
           Assembly assembly = Assembly.Load("ClassTest");
           Type[] types = assembly.GetTypes();
           foreach(Type type in types)
           {
               if (type.Name == "Student")
               {
                   var instance = Activator.CreateInstance(type) as Student;
                   if(instance!=null)
                   {
                       instance.Say();
                   }
               }
           }
       }
       
    }
}
