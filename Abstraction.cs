using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class Abstraction
    {
        static void Main(string[] args)
        {
            //Base - Derived
            AbstractDemo1 abstractDemo1;
            abstractDemo1 = new AbstractDemo2();
            abstractDemo1.Display1();
            abstractDemo1 = new AbstractDemo3();
            abstractDemo1.Display1();
            Console.ReadLine();
        }
    }
    /// <summary>
    /// Abstraction - Data hiding,Security
    /// Abstract classes,variables and methods
    /// Cannot create an instance
    /// </summary>
    internal abstract class AbstractDemo1
    {
        /// <summary>
        /// Cannot declare a method body
        /// </summary>
        public abstract void Display1();
        public void Display2()
        {
            Console.WriteLine("Abstract Class");
        }
    }

    internal class AbstractDemo2: AbstractDemo1
    {
        /// <summary>
        /// Method Overriding - Run time polymorphism
        /// </summary>
        public override void Display1()
        {
            Console.WriteLine("Display 1 overriden in AbstractDemo2");
        }
    }
    internal class AbstractDemo3 : AbstractDemo1
    {
        /// <summary>
        /// Method Overriding - Run time polymorphism
        /// </summary>
        public override void Display1()
        {
            Console.WriteLine("Display 1 overriden in AbstractDemo3");
        }
    }
}
