using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_five
{
    public interface ITimeKeeping
    {
        void Beginning();
        void Stopping();
        void Duration();
    }
}
