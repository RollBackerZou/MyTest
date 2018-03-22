using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyTest
{
    public class HashPractice
    {
        public void HashTableMethod()
        {
            Hashtable ht = BuildHt();
            foreach(DictionaryEntry item in ht)
            {
                int code = item.GetHashCode();
                Console.WriteLine(" 我的第一个hashtable是{0}",item.Value.ToString());
            }
            ht.Remove(1);
            foreach(var removeitem in ht.Keys)
            {
                Console.WriteLine(" 剩下的hashtable是{0}", (string)ht[removeitem]);
            }
            if(ht.Contains(1))
            {
                Console.WriteLine("第二项未删除成功");
            }
            else
            {
                Console.WriteLine("第二项已被删除");
            }
        }

        private Hashtable BuildHt()
        {
            Hashtable ht = new Hashtable();
            for (var i = 0; i < 3; i++)
            {
                ht.Add(i, i.ToString());
            }
            return ht;
        }
    }
}
