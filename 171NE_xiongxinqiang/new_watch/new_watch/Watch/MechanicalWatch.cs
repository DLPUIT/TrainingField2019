﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Java、C#不支持多继承，但可以实现多个接口
namespace new_watch
{
    public abstract class MechanicalWatch : Watch, IAutomaticWinding
    {
        public void AutomaticWinding()
        {
            Console.WriteLine("我正在上弦");
        }
    }
}
