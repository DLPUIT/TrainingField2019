using System;

namespace watch
{
    public interface IShow
    {
        void Showtime();
    }
    public interface IAd
    {
        void ShowAd();
    }
    class People
    {
        public class Watch
        {
            public class Quartzwatch
            {
                public void TISSOT()
                {
                    Console.WriteLine("秒表计时功能");
                }
                public void RODO()
                {

                }
            }
            public class Automaticwatch
            {
                public void OMEGA()
                {
                    Console.WriteLine("秒表计时功能");
                }
                public void IWC()
                {

                }
            }
            public class Solarwatch
            {
                public void CASIO()
                {
                    Console.WriteLine("X天之后是哪一天");
                }
                public void CITIZEN()
                {

                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var watchname = new People.Watch();


        }
    }
}
