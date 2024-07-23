using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Value Type datatypes
    /// Integral values for the constants defined
    /// </summary>
    enum TrafficLight
    {
        green,
        red,
        yellow
    }
    internal class Enumeration
    {
        static void Main(string[] args)
        {
            int go=(int)TrafficLight.green;
            int stop=(int)TrafficLight.red;
            int walk=(int)TrafficLight.yellow;
            Console.WriteLine($"{TrafficLight.green}:{go}");
            Console.WriteLine(stop);
            Console.WriteLine(walk);
            Signal(TrafficLight.green);
            Signal(TrafficLight.red);
            Signal(TrafficLight.yellow);
            Console.ReadLine();
        }

        public static void Signal(TrafficLight tl)
        {
            int value;
            value = (int)tl;
            if(value==0)
            {
                Console.WriteLine("You can GO");
            }
             else if(value==1)
            {
                Console.WriteLine("STOP");
            }
            else
            {
                Console.WriteLine("WALK");
            }
        }
    }
}
