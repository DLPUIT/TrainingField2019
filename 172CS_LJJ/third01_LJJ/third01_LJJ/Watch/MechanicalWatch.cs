﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third01_LJJ
{
    public abstract class MechanicalWatch : Watch,IAutoWinding
    {
        public void AutoWinding()
        {
            throw new NotImplementedException();
        }
    }
}
