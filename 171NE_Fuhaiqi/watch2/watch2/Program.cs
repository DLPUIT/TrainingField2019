using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<Watch>

            {
                new CASIO(),
                new OMEGA{Name="my omega"}
            };

            foreach (Watch watch in list)

            {
                Console.WriteLine("I am" + watch.Name);

                if (watch is TISSOT)
                {

                    (watch as TISSOT).StartTiming();

                    (watch as TISSOT).StopTiming();

                    (watch as TISSOT).ShowStopTime();

                }

                if (watch is OMEGA)

                {

                    (watch as OMEGA).StartTiming();

                    (watch as OMEGA).StopTiming();

                    (watch as OMEGA).ShowStopTime();

                }

                if (watch is CASIO)

                {
                    (watch as CASIO).CalDayAfterN();
                }

            }



        }
    }
    public class Watch : IShowAD, IShowTime

    {
        public String Name;
        public void ShowAD()

        {

            String ADDescription = "";
            Console.WriteLine(Name + "在做广告" + ADDescription);

        }

        public void ShowTime()

        {

            Console.WriteLine("现在是X年X月X日XXX");

        }

    }
    public class MechanicaWatch : Watch, IAutomaticWinding

    {

        public void AutomaticWinding()

        {

            Console.WriteLine("我正在上弦");

        }

    }
    public class QuartzWatch:Watch 

    {
    }
    public class SolarWatch : Watch

    {
    }
    public class CASIO : SolarWatch, ICalDay

    {

        public void CalDayAfterN()

        {

            Console.WriteLine("N天之后是第M天");

        }

    }
    public class CITIZEN : SolarWatch

    {

    }
    public class IWC : MechanicaWatch

    {

    }
    public class RADO : QuartzWatch

    {

    }
    public class OMEGA : MechanicaWatch, IStopWatch

    {

        public void StartTiming()

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

    public class TISSOT : QuartzWatch, IStopWatch

    {

        public void StartTiming()

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
    public interface IAutomaticWinding

    {

        void AutomaticWinding();

    }
    public interface ICalDay

    {

        void CalDayAfterN();
    }
    public interface IShowAD

    {
        void ShowAD();

    }
    public interface IShowTime

    {
        void ShowTime();

    }
    public interface IStopWatch

    {
        void StartTiming();
        void StopTiming();
        void ShowStopTime();
    }


}

