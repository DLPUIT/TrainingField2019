using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch;

namespace student.watch
{
    class CITIZEN:SolarWatch,IShowAD
    {
        public void showTime()
        {
            Console.WriteLine("CITIZEN 显示时间");
        }
        public void showAdv()
        {
            Console.WriteLine("CITIZEN 显示广告");
        }

        public void ShowAD()
        {
            throw new NotImplementedException();
        }
    }
}
