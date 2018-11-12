using System;
using System.Collections.Generic;
using System.Text;

namespace watch完整版.watch
{
   public class OMEGA:Automaticwatch, Iwinding
    {
        public void StartTime()
        {
            Console.WriteLine("现在从零开始计时");
        }

        public void StopTime()
        {
            Console.WriteLine("经过10s停止");
        }

        public void ShowSopTime()
        {
            Console.WriteLine("共10s");
        }
    }
}
