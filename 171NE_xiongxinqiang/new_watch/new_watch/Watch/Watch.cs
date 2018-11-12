using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_watch
{
    public abstract class Watch : IShowTime, IShowAD
    {
        public string ADDscription;
        public string Name;

        public void ShowAD()
        {
            Console.WriteLine(this.Name + "在做广告" + this.ADDscription);
        }
            public void ShowTime()
        {
            Console.WriteLine("现在时间是");
        }
    }
}
