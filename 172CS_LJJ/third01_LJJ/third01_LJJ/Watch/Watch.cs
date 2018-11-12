using System;

namespace third01_LJJ
{
    public abstract class Watch : IShowTime,IShowAd
    {
        public string Name;
        public void ShowTime()
        {
            throw new NotImplementedException();
        }
        public void ShowAd()
        {
            throw new NotImplementedException();
        }
    }
}
