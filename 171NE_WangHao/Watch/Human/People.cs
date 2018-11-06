using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watch.interfaces;

namespace Watch
{
    public abstract class People : IEat,IExercise
    {
        public void Exercise()
        {
            Console.WriteLine("As a people,I exercise everyday!");
        }

        public void ICanEat()
        {
            Console.WriteLine("I can use my right hand to eat!");
        }
    }
}
