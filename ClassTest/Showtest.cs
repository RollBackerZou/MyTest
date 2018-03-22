using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
   public class Showtest:IShow
    {
       public void Show()
       {
           Console.WriteLine(this.GetType().FullName);
       }
    }
}
