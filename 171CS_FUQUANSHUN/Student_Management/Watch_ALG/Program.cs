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
            
            var list = new List<BigTotalWatch>
                // 泛型容器
            {
                // 内部指定
                new OMEGA {Name = "QiHuan's omega"},
                new OMEGA {Name = "Qiyanan's omega"},
                new CASIO(),
                new TISSOT()
            };

            // 泛型容器内容拿出来相当于：
            // a1.Name = "QiHuan's omega";
            // a2.Name = "Qiyanan's omega";

            foreach (BigTotalWatch watch in list)
                // 多态：遍历区分各种表，面向容器用 foreach 不用 for
            {
                Console.WriteLine("I'm " + watch.Name +  ",now I'm going to show you what I can do!");

                if (watch is ICalDay)
                    // 接口实现关系的对象替换
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