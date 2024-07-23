using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Collections - Dynamic memory allocation
    /// System.Collections.Generic;
    /// System.Collections;
    /// </summary>
    internal class Collections
    {
        static void Main(string[] args)
        {
            ArrayList();
            Console.ReadLine();
        }
        public static void ArrayList()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add(100);
            arrayList.Add("John");
            arrayList.Add(123.45f);
            arrayList.Add(true);
            foreach(object i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Reverse();
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Remove(true);
            foreach(object i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.RemoveAt(1);
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }

        }
    }
    
}
