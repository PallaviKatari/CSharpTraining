﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Arrays and structures
    /// STRUCTURES - Small applications,no inheritance(no protected access specifier) - Value type - Stack
    /// Classes - Larger applications - All OOPS concepts - Reference type - Heap
    /// </summary>
    struct TraineeDetails
    {
        public int Id;
        public string Name;
        public string Designation;

        public void GetDetails()
        {
            Console.WriteLine("Enter Trainee Details");
            Id = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Designation = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"{Name}'s id is {Id} from {Designation} department");
        }
    }

    internal class classStruct
    {
        static void Main(string[] args)
        {
            TraineeDetails details = new TraineeDetails();
            TraineeDetails details1;
            details1.Id = 200;
            Console.WriteLine(details1.Id);
            details.GetDetails();
            details.DisplayDetails();
            Console.ReadLine();
        }
    }
}
