using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//（interface）接口定义行为，只定义不实现
//行为可以有多种实现方式，接口只定义有这个行为，但不实现，这就是接口的好处
namespace new_watch
{
    public interface IAutomaticWinding
    {
        void AutomaticWinding();
    }
}
