using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class Program
    {
        public delegate void noise();

        static void Main(string[] args)
        {
            noise noiseVar = beep;
            Console.WriteLine("Equalizers flip to side 2");
            noiseVar();

            noiseVar = beepBeep;
            Console.ReadLine();
            noiseVar();
        }

        static void beep()
        {
            Console.Beep();
        }

        static void beepBeep()
        {
            Console.Beep();
            Console.Beep();
        }
    }
}
