﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursefour
{
        // 机械表
        public abstract class MechanicalWatch : Watch, IAutomaticWinding
        {
            public void AutomaticWinding()
            {
                Console.WriteLine("我正在上弦");
            }
        }
}
