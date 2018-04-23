using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyTest
{
   public class defaultTest
    {
       public static T GetDefault<T>()
       {
           return default(T);
       }
    }

    public struct structDemo
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}
