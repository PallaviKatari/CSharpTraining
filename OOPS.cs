using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// OOPS - Object Oriented Programming System/Structure
    /// Class,Objects,Abtraction,Encapsulation,Polymorphism,Inheritance
    /// </summary>
    internal class OOPS
    {
        public void Demo()
        {
            Console.WriteLine("Demo Method");
        }
        static void Main(string[] args)
        {
            OOPS oops = new OOPS();
            oops.Demo();
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Id = 10;
            //encapsulation.Name = "Jane";
            encapsulation.AccessSpecifiers();
            Console.WriteLine(encapsulation.Id);
            Console.ReadLine();

        }
    }

    internal class Encapsulation
    {
        private int id; // default access specifier for a variable - private
        private string name = "John";
        /// <summary>
        /// public,private,internal,protected(inheritance),internal protected
        /// </summary>
        public void AccessSpecifiers()
        {
            Console.WriteLine(id);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
