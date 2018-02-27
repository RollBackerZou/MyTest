using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    delegate void GreetDelegate(string userName);
    class Program
    {      
        static void Main(string[] args)
        {
            GreetDelegate greetDelegate;
            while(true)
            {
                Console.WriteLine("------------请选择模式（0/1）------------");
                int mode = Convert.ToInt32(Console.ReadLine());
                if(mode == 0)
                {
                    
                    Console.WriteLine("------------狂喷模式------------");
                    Console.WriteLine("------------请输入用户名------------");
                    string username = Console.ReadLine();
                    greetDelegate = Chinese;
                    greetDelegate += English;
                    greetDelegate += Japan;
                    greetDelegate += Thailand;
                    greetDelegate += Default;
                    greetDelegate(username);
                }
                else
                {
                    greetDelegate = null;
                    Console.WriteLine("------------请输入用户名------------");
                    string username = Console.ReadLine();
                    Console.WriteLine("------------请输入语言------------");
                    string language = Console.ReadLine().ToLower();
                    switch (language)
                    {
                        case "chinese":
                            greetDelegate = Chinese;
                            greetDelegate(username);
                            break;
                        case "english":
                            greetDelegate = English;
                            greetDelegate(username);
                            break;
                        case "thailand":
                            greetDelegate = Thailand;
                           greetDelegate(username);
                            break;
                        case "japanese":
                            greetDelegate = Japan;
                            greetDelegate(username);
                            break;
                        default:
                            greetDelegate = Default;
                            greetDelegate(username);
                            break;
                    }
                }
            }
        }

        //public static void DelegateMethod(string username, GreetDelegate greetDelegate)
        //{
        //    return greetDelegate(username);
        //}

        public static void Chinese(string username)
        {
            Console.WriteLine( username + "  大傻子");
        }

        public static void English(string username)
        {
            Console.WriteLine( username + "  is a fool");
        }

        public static void Thailand(string username)
        {
            Console.WriteLine( username + "  ติงต๊อง 傻瓜");
        }
        public static void Default(string username)
        {
            Console.WriteLine(username + "  跟小万一样傻");
        }
        public static void Japan(string username)
        {
            Console.WriteLine( username + "  おろかもの");
        }
    }
}
