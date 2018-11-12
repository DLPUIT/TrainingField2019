
// 机械表抽象类

namespace Watch_ALG
{
    #region using directives

    using System;

    #endregion

    public abstract class MechanicalWatch : BigTotalWatch, IAutomaticWinding
        // 继承手表，实现自动上弦接口
    {
        public void AutomaticWinding()                  
        {
            Console.WriteLine("我正在上弦");
        }
    }
}