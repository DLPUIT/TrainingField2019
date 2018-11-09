
// 卡西欧手表具体实类

namespace Watch_ALG
{
    #region using directives

    using System;

    #endregion

    public class CASIO : SolarWatch, ICalDay, IStopWatch
        // 继承光能表、
    {
        public void CalDayAfterN()                      // 计算N天之后是哪一天，需写具体实现方法
        {
            Console.WriteLine("N 天之后是 M day");
        }

        public void StartTiming()                       // 秒表计时功能，计时开始，需写具体实现方法
        {
            throw new NotImplementedException();
        }

        public void StopTiming()                        // 秒表计时功能，计时开始
        {
            throw new NotImplementedException();
        }

        public void ShowStopWatch()                     // 秒表计时功能，计时开始
        {
            throw new NotImplementedException();
        }
    }
}