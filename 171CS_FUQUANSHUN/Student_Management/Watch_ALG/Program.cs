namespace Watch_ALG
{
    #region using directives

    using System;
    using System.Collections.Generic;

    #endregion using directives

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // ��������
            var list = new List<BigTotalWatch>
            {
                // �ڲ�ָ��
                new OMEGA {Name = "QiHuan's omega"},
                new OMEGA {Name = "Qiyanan's omega"},
                new CASIO(),
                new TISSOT()
            };

            // �������������ó����൱�ڣ�
            // a1.Name = "QiHuan's omega";
            // a2.Name = "Qiyanan's omega";

            foreach (BigTotalWatch watch in list)
            {
                Console.WriteLine("I'm " + watch.Name);

                if (watch is ICalDay)
                {
                    (watch as ICalDay).CalDayAfterN();
                }
                if (watch is IStopWatch)
                {
                    (watch as IStopWatch).StartTiming();
                    (watch as IStopWatch).StopTiming();
                    (watch as IStopWatch).ShowStopWatch();
                }
            }

            CASIO c1 = new CASIO();
            BigTotalWatch c2 = new CASIO();
            CASIO c3 = c2 as CASIO;

            BigTotalWatch w1 = new CASIO();
            BigTotalWatch w2 = new OMEGA();

            IStopWatch stopWatch = new CASIO();
            IStopWatch stopWatch2 = new OMEGA();

            foreach (var watch in list)
            {
                if (watch is OMEGA)
                {
                }
                if (watch is CASIO)
                {
                }
                if (watch is TISSOT)
                {
                }
            }

            Console.ReadKey(true);
        }
    }
}