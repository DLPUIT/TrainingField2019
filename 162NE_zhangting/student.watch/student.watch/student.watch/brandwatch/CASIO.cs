using student.watch.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch;

namespace student.watch 
{

    //卡西欧手表
    class CASIO: SolarWatch,ICalDay,IShowAD
    {
        
        public void countTime()
        {
            Console.WriteLine("CASIO 开始计时");
        }
        public void showTime()
        {
            Console.WriteLine("CASIO 显示时间");
        }

        public void CalDayAfterN()
        {
            throw new NotImplementedException();
        }

        public void ShowAD()
        {
            throw new NotImplementedException();
        }
    } 
}
