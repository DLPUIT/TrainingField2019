using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watch
{
    //创建基类Watch
    class Watch
    {
        protected string name;
        protected string time;
        protected string sentence;
        public Watch(string n,string t)
        {
            name = n;
            time = t;
        }
        public void GetQute(string ad)
        {
            sentence = ad;
        }
        public void Display()
        {
            Console.WriteLine("my name is {0}",name);
            Console.WriteLine("{0}",sentence);
            Console.WriteLine("{0}", sentence);
        }
    }

    //创建派生类石英表
    class Quartz_watch : Watch
    {
        public Quartz_watch(string n,string t) : base(n,t)
        { }
        public int TISSOT()
        {
            Console.WriteLine("timing start");
            return 1;
        }
    }

    //创建派生类机械表
    class Mechanical_watch : Watch
    {
        public Mechanical_watch(string n, string t) : base(n, t)
        { }
        public int UC()
        {
            Console.WriteLine("I can upper chord!");
            return 1;
        }
        public int TOMEGA()
        {
            Console.WriteLine("timing start");
            return 1;
        }
    }

    //创建派生类光能表
    class Light_energy_watch : Watch
    {
        public Light_energy_watch(string n, string t) : base(n, t)
        {

        }
        public int CASIO_getday()
        {
            int day = 0;
            Console.WriteLine("input the day of number:");
            return day;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var T = DateTime.Now.ToString();
            string name1 = "IWC";
            string name2 = "CITIZEN";
            string name3 = "RADO";
            Mechanical_watch I = new Mechanical_watch(name1, T);
            Light_energy_watch C = new Light_energy_watch(name2, T);
            Quartz_watch R = new Quartz_watch(name3, T);

            Console.WriteLine("{0}/n{1}", I.UC(),I.TOMEGA());
            Console.WriteLine("{0}", C.CASIO_getday());
            Console.WriteLine("{0}", R.TISSOT());
            Console.ReadKey();
        }
    }
}
