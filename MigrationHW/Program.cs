﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new StudentContext())
            {
                context.Students.ToArray();
            }
        }
    }
}
