using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TF : Question
    {
        public TF()
        {
            Header = "True | False Question";
            Answers = new Answer[2]
            {
                new Answer { AnsID = 1, AnsText = "True"},
                new Answer { AnsID = 2, AnsText = "False"}
            };
            Console.WriteLine($"{Header}");
            Console.WriteLine("Please Enter Question Body");
            Body = Console.ReadLine();
            Console.WriteLine("Please Enter Question Mark");
            Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Right Answer ID ( 1 For True | 2 For False )");
            RightAnswer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{Body}");
        }

        //public override void MakeQuestion()
        //{
        //    Console.WriteLine($"{Header}");
        //    Console.WriteLine("Please Enter Question Body");
        //    Body = Console.ReadLine();
        //    Console.WriteLine("Please Enter Question Mark");
        //    Mark = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Please Enter The Right Answer ID ( 1 For True | 2 For False )");
        //    RightAnswer = Convert.ToInt32(Console.ReadLine());
        //    Console.Clear();
        //}

    }
}
