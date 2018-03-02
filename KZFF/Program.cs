using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KZFF
{
    class Program
    {
        static void Main(string[] args)
        {
            JuiceCup cup = new JuiceCup();
            cup.Add("白开水");
            cup.Items.ForEach(m => {
                Console.WriteLine(m);
            });
            Console.ReadKey();
        }
    }
    public static class KZ
    {
        public static List<string> Add(this JuiceCup cup,string water)
        {
            cup.Items.Add(water);
            return cup.Items;
        }
    }
}
