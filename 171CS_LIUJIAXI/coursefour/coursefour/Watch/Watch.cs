using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursefour
{
    public abstract class Watch : IShowTime, IShowAD
    {
        public string ADDescription;
        public string Name;

        //ad
        public void ShowAD()
        {
            Console.WriteLine(this.Name + "在做广告：" + this.ADDescription);
        }

        public void CheckPower()
        {
            throw new NotImplementedException();
        }

        public void CheckNetwork()
        {
            throw new NotImplementedException();
        }

        public void ShowTime()
        {
            Console.WriteLine("现在是......");
        }
    }
}
