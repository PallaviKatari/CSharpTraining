using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Pass By Value
    /// </summary>
    internal class PassByValueRef
    {
        static void Main(string[] args)
        {
            PassByValueRef passByValueRef = new PassByValueRef();
            int x = 10;
            int y = 20;
            Console.WriteLine("Before swap:x:{0}", x);
            Console.WriteLine("Before swap:y:{0}", y);
            //passByValueRef.Swap(x, y); // Pass by value = x,y (1001,1004) = 10,20 - Separate copy in the memory
            passByValueRef.Swap1(ref x, ref y); // Pass by reference = x,y (1001,1004) = 10,20 - Same copy in the memory
            Console.WriteLine("After swap:x:{0}", x);
            Console.WriteLine("After swap:y:{0}", y);
            Console.ReadLine();
            
        }
        public void Swap(int a, int b) // 10, 20 // a,b (1007,1011) = 10,20 - Separate copy in the memory
        {
            Console.WriteLine("Before swap:a:{0}", a);
            Console.WriteLine("Before swap:b:{0}", b);
            int temp;
            temp = a; // 10
            a = b; // 20
            b = temp; // 10
            Console.WriteLine("After swap:a:{0}", a);
            Console.WriteLine("After swap:b:{0}", b);
        }
        public void Swap1(ref int a, ref int b) // 10, 20 // a,b (1001,1004) = 10,20 - Same copy in the memory
        {
            Console.WriteLine("Before swap:a:{0}", a);
            Console.WriteLine("Before swap:b:{0}", b);
            int temp;
            temp = a; // 10
            a = b; // 20
            b = temp; // 10
            Console.WriteLine("After swap:a:{0}", a);
            Console.WriteLine("After swap:b:{0}", b);
        }
    }
}
