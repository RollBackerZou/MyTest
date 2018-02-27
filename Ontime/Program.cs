using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Ontime;

namespace Ontime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToMoreChar(6));
            Console.ReadKey();
        }

         private static string IntToMoreChar(int value)
       {
             string rtn = string.Empty;
              List<int> iList = new List<int>();
  
              //To single Int
              while (value / 26 != 0 || value % 26 != 0)
              {
                  iList.Add(value % 26);
                 value /= 26;
             }
 
             //Change 0 To 26
             for (int j = 0; j < iList.Count - 1; j++)
             {
                 if (iList[j] == 0)
                 {
                     iList[j + 1] -= 1;
                     iList[j] = 26;
                 }
             }
 
             //Remove 0 at last
             if (iList[iList.Count - 1] == 0)
             {
                 iList.Remove(iList[iList.Count - 1]);
             }
 
            //To String
             for (int j = iList.Count - 1; j >= 0; j--)
             {
                 char c = (char)(iList[j] + 64);
                 rtn += c.ToString();
             }
 
             return rtn;
         }
    }
}
