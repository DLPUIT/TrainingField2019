﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biao2.watch1
{
    public class TISSOT : Quartz, IStopWatch
    {
        public void Starttime()
        {
            Console.WriteLine("开始计时");
        }

        public void Stoptime()
        {
            Console.WriteLine("停止计时");
        }

        public void Showstopwatch()
        {
            Console.WriteLine("共计n秒");
        }
    }
}