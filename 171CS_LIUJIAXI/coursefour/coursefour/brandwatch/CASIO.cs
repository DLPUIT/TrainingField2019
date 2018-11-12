using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursefour.brandwatch
{
    //卡西欧
    public class CASIO : SolarWatch, ICalDay, IStopWatch
    {
        //afterday
        public void CalDayAfterN()
        {
            Console.WriteLine("N 天之后是 M day");
        }

        public void StartTiming()
        {
            //throw new NotImplementedException();
        }

        public void StopTiming()
        {
            //throw new NotImplementedException();
        }

        public void ShowStopWatch()
        {
            //throw new NotImplementedException();
        }
    }
}
