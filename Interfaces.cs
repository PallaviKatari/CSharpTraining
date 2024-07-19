using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Interface - pure abstraction,abstract methods,properties,cannot have variables
    /// Multiple inheritance is overcome by multiple interface
    /// </summary>
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            IInterface1 interface1;
            interface1 = new InterfaceDemo();
            interface1.Id = 1;
            interface1.Name = "John Doe";
            interface1.Display();
            IInterface2 interface2;
            interface2 = new InterfaceDemo();
            interface2.Age = 21;
            interface2.Designation = "Trainee";
            interface2.Display();
            Console.ReadLine();
        }

    }

    interface IInterface1
    {
        int Id { get; set; }
        string Name { get; set; }

        void Display();
    }
    interface IInterface2
    {
        int Age { get; set; }
        string Designation { get; set; }
        void Display();
    }
    /// <summary>
    /// InterfaceDemo implements IInterface1,IInterface2
    /// </summary>
    internal class InterfaceDemo : IInterface1, IInterface2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        void IInterface1.Display() 
        {
            Console.WriteLine($"{Id}:{Name}");
        }
        void IInterface2.Display()
        {
            Console.WriteLine($"{Age}:{Designation}");
        }
    }
}
