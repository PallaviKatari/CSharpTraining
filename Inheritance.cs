using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// Inheritance - Reusability
    /// Types - Single,Multi-level,Hierarchial,Hybrid,Multiple(not supported)
    /// </summary>
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            HR hr = new HR();
            //hr.TrainerId = 1;
            hr.TrainerName = "John Doe";
            hr.TraineeId = 100;
            hr.TraineeName = "Jane Doe";
            hr.HrId = 12;
            hr.HrName = "Sam";
            hr.DisplayTraineeDetails();
            //hr.DisplayTrainerDetails();
            
            hr.DisplayHrDetails();           
            Console.ReadLine();
        }
    }

    internal class Trainer
    {
        protected int TrainerId;
        public string TrainerName;
        protected void DisplayTrainerDetails()
        {
            Console.WriteLine($"{TrainerName}'s Id is {TrainerId}");
        }

    }
    internal class Trainee:Trainer
    {
        public int TraineeId;
        public string TraineeName;
        public void DisplayTraineeDetails()
        {
            TrainerId = 1;
            Console.WriteLine($"{TraineeName}'s Id is {TraineeId}");
            DisplayTrainerDetails();
        }

    }
    internal class HR:Trainee
    {
        public int HrId;
        public string HrName;
        public void DisplayHrDetails()
        {
            Console.WriteLine($"{HrName}'s Id is {HrId}");
        }

    }
}
