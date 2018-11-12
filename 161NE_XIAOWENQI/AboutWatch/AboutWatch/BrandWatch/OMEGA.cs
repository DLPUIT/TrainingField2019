using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutWatch.BrandWatch
{
     public class OMEGA : MechanicalWatch, IStopWatch
    {
        public OMEGA()
        {
            this.ADDescription = "Omega is the best.";
        }
        public void StartTiming()
        {
            throw new NotImplementedException();
        }
        public void StopTiming()
        {
            throw new NotImplementedException();
        }
        public void ShowStopWatch()
        {
            throw new NotImplementedException();
        }
    }
}
