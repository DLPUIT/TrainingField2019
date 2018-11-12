using student.watch.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch;


namespace student.watch
{
    class OMEGA:MechanicalWatch,IShowAD,IStopWatch
    {
        public string Name { get; internal set; }

        public void showTime()
        {
            Console.WriteLine("OMEGA 显示时间");
        }
        public  void  showAdv()
        {
            Console.WriteLine("OMEGA 显示广告");

        }
        public  void  showMi()
        {
            Console.WriteLine("OMEGA 秒表计时");

        }

        public void ShowAD()
        {
            throw new NotImplementedException();
        }

        public void StatTiming()
        {
            throw new NotImplementedException();
        }

        public void StopTiming()
        {
            throw new NotImplementedException();
        }

        public void ShowStopTime()
        {
            throw new NotImplementedException();
        }
    }
}
