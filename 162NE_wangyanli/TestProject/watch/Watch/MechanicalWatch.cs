namespace Watch2.Watch
{
    #region using directives

    using System;
    using Watch2.Interface;

    #endregion

    // 机械表
    public abstract class MechanicalWatch : Watch, IAutomaticWinding
    {
        public void AutomaticWinding()
        {
            Console.WriteLine("我正在上弦");
        }
    }
}
