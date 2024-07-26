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
            Console.WriteLine("******************************");
            ListDemo();
            Console.WriteLine("******************************");
            SortedListDemo();
            Console.WriteLine("******************************");
            StackDemo();
            Console.WriteLine("******************************");
            QueueDemo();
            Console.WriteLine("******************************");
            LinkedListDemo();
            Console.ReadLine();
        }
        public static void ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("John");
            arrayList.Add(123.45f);
            arrayList.Add(true);
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Reverse();
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Remove(true);
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.RemoveAt(1);
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }

        }

        public static void ListDemo()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (int i in list)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void SortedListDemo()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(1, "CSharp");
            keyValuePairs.Add(2, "Java");
            keyValuePairs.Add(3, "PHP");
            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine(keyValue);
            }
        }

        /// <summary>
        /// LIFO - Stack of Books
        /// PUSH,POP,PEEK
        /// </summary>
        public static void StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Pushed Elements");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            stack.Pop();
            Console.WriteLine("Elements after POP");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(stack.Peek());
        }

        /// <summary>
        /// FIFO - Ticket Booking
        /// enqueue,dequeue,peek
        /// </summary>
        public static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("Elements in the queue");
            foreach (int x in queue)
            {
                Console.WriteLine(x);
            }
            queue.Dequeue();
            Console.WriteLine("Elements after dequeue");
            foreach (int x in queue)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(queue.Peek());
        }
        /// <summary>
        /// LinkedList - Nodes
        /// Singly,Doubly,Circular
        /// </summary>
        public static void LinkedListDemo()
        {
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddFirst(3);
            linkedlist.AddFirst(4);
            linkedlist.AddLast(5);
            foreach (var x in linkedlist)
            {
                Console.WriteLine(x);
            }
        }
    }

}
