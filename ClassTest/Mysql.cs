﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
   public class Mysql
    {
        public string DbName
        {
            get
            {
                return "Mysql";
            }
        }

        public void Add()
        {
            Console.WriteLine("Add in " + DbName);
        }

        public void Delete()
        {
            Console.WriteLine("Delete in " + DbName);
        }

        public void Select()
        {
            Console.WriteLine("Select in " + DbName);
        }

        public void Update()
        {
            Console.WriteLine("Update in " + DbName);
        }
    }
}
