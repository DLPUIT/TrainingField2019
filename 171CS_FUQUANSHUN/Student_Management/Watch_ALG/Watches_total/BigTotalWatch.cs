
// 手表抽象大类

namespace Watch_ALG
{
    #region using directives

    using System;

    #endregion

    public abstract class BigTotalWatch : IShowTime, IShowAD
        // 实现显示时间和打广告接口
    {
        public string ADDescription;
        public string Name;

        public void ShowAD()                    // 打广告
        {
            Console.WriteLine(this.Name + "我在打广告：" + this.ADDescription);
        }

        public void CheckPower()                // 检查电源是否有电
        {
            throw new NotImplementedException();
        }

        public void CheckNetwork()              // 检查网络是否正常
        {
            throw new NotImplementedException();
        }

        public void ShowTime()                  // 报时间
        {
            Console.WriteLine("现在是XXXXXXX");
        }
    }
}