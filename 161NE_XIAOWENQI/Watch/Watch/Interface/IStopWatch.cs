﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Watch
{
    public interface IStopWatch
    {
        void StartTiming();
        void StopTiming();
        void ShowStopTime();
    }
}
