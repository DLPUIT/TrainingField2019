namespace Watch2.BrandWatch
{
    #region using directives

    using System;
    using Watch2.Interface;
    using Watch2.Watch;

    #endregion

    public class OMEGA : MechanicalWatch, IStopWatch
    {
        public OMEGA()
        {
            this.ADDescription = "Omega is the best.";
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
