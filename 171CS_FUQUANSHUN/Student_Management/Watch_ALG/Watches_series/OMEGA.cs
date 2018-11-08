
// 欧米茄手表实类

namespace Watch_ALG
{
    #region using directives

    using System;

    #endregion

    public class OMEGA : MechanicalWatch, IStopWatch
    {
        public OMEGA()
        {
            this.ADDescription = "Omega is the best.";
        }

        public void StartTiming()               // 秒表计时功能，计时开始
        {
            throw new NotImplementedException();
        }

        public void StopTiming()                // 秒表计时功能，计时结束
        {
            throw new NotImplementedException();
        }

        public void ShowStopWatch()             // 秒表计时功能，显示计时时间
        {
            throw new NotImplementedException();
        }
    }
}