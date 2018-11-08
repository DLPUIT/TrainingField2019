
// 卡西欧手表具体实类

namespace Watch_ALG
{
    #region using directives

    using System;

    #endregion

    public class CASIO : SolarWatch, ICalDay, IStopWatch
        // 继承光能表、
    {
        public void CalDayAfterN()                      // 计算N天之后是哪一天
        {
            Console.WriteLine("N 天之后是 M day");
        }

        public void StartTiming()
        {
            throw new NotImplementedException();
        }

        public void StopTiming()
        {
            throw new NotImplementedException();
        }

        public void ShowStopWatch()
        {
            throw new NotImplementedException();
        }
    }
}