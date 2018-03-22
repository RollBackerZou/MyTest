using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    public class MonitorMonster
    {

    }

    public class Monster
    {
        public int Blood;
        string Name;
        public Monster(int blood)
        {
            Blood = blood;
            Console.WriteLine("I am a Monster,and I hava {0} blood", blood);
        }

    }

    public class Attack
    {
        public string Name { get; set; }
        public int Power { get; set; }
        bool attackFlag = false;
        public void MagicAttack(object monster)
        {
            Monster ms = (Monster)monster;
            Monitor.Enter(ms);
            while (ms.Blood > 0)
            {
                //if(!attackFlag)
                {
                    Monitor.Wait(ms);
                }                
                Console.WriteLine("当前英雄{0}正在用法术攻击怪物", this.Name);
                if (ms.Blood >= Power)
                {
                    ms.Blood -= Power;
                }
                else
                {
                    ms.Blood = 0;
                }
                Console.WriteLine("怪物还有{0}血", ms.Blood);
                attackFlag = true;
                Monitor.Pulse(ms);
            }
            Monitor.Exit(ms);
        }

        public void PhysicalAttack(object monster)
        {
            Monster ms = (Monster)monster;
            Monitor.Enter(ms);
            while (ms.Blood > 0)
            {
                //if(!attackFlag)
                {
                    Monitor.PulseAll(ms);
                }
                if (Monitor.Wait(ms,1000))
                {
                    Console.WriteLine("当前英雄{0}正在用物理攻击怪物", this.Name);
                    if (ms.Blood >= Power)
                    {
                        ms.Blood -= Power;
                    }
                    else
                    {
                        ms.Blood = 0;
                    }
                    Console.WriteLine("怪物还有{0}血", ms.Blood);
                    attackFlag = true;
                    //Monitor.Pulse(ms);
                }
            }
            Monitor.Exit(ms);
        }
    }
}
