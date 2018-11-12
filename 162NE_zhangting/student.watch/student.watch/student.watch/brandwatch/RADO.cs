using student.watch.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch;
namespace student.watch
{
    class RADO:QuartzWatch,IShowAD
    {

        public void ShowAD()
        {
            Console.WriteLine("RADO 显示广告");
        }
    }
}
