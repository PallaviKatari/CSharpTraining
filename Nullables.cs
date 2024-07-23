using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Nullables - Using nullable types Value Type datatypes can be assigned with Null values
    /// ?, Nullable<T>
    /// </summary>
    internal class Nullables
    {
        int? a = null;
        Nullable<int> b = null;
        int? c= 100;
        int? d;


        static void Main(string[] args)
        {
            Nullables nullables = new Nullables();
            nullables.a = 1;
            Console.WriteLine(nullables.a);
            Console.WriteLine(nullables.b);
            nullables.d = nullables.b ?? nullables.c;// Null Coalease operator
            Console.WriteLine(nullables.d);
            Console.ReadLine();
        }
    }
}
