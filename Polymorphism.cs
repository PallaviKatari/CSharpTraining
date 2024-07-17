using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Polymorphism - Many Forms of the same method
    /// Method Overloading - compile time
    /// Method Overriding - runtime
    /// </summary>
    internal class Polymorphism
    {
        /// <summary>
        /// Function/Method signature - diff in no of parameters,datatype,sequence
        /// </summary>
        /// <param name="a"></param>
        public void Add(int a)
        {
            Console.WriteLine(a);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b+c);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public void Add(float a)
        {
            Console.WriteLine("Float:"+a);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add(int a, float b)
        {
            Console.WriteLine(a + b);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add(float a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Polymorphism polymorphism = new Polymorphism();
            polymorphism.Add(10);
            polymorphism.Add(10, 20);
            polymorphism.Add(10, 20, 30);
            polymorphism.Add(12.3f);
            polymorphism.Add(1, 1.2f);
            Console.ReadLine();
        }
    }
}
