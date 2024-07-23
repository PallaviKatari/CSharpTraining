using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Generics - Special type of Datatype
    /// Class,Variable,Method,Constructor,Property
    /// <T>
    /// </summary>
    internal class Generics<T>
    {
        public Generics(T a) 
        { 
            Console.WriteLine(a);
        }
        public T MyProperty { get; set; }
        public void Display(T a)
        {
            Console.WriteLine(MyProperty);
            Console.WriteLine(a);
        }
       
    }
    internal class Generics1<T,T1>
    {
        public Generics1(T a,T1 b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public T MyProperty1 { get; set; }
        public void Display1(T1 a)
        {
            Console.WriteLine(MyProperty1);
            Console.WriteLine(a);
        }

    }
    internal class GenericDemo
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(10);
            generics.MyProperty = 100;
            generics.Display(200);
            Generics<float> generics1 = new Generics<float>(10.12f);
            generics1.MyProperty = 100.12f;
            generics1.Display(200.12f);
            Generics1<int, float> generics2 = new Generics1<int, float>(10, 20.5f);
            generics2.MyProperty1 = 120;
            generics2.Display1(123.45f);
            Console.ReadLine();

        }
    }
}
