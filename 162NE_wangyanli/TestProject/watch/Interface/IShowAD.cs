using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch2.Interface
{
    public interface IShowAD
    {
        void CheckPower();

        void CheckNetwork();

        void ShowAD();
    }
}
