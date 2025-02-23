using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQ : Question
    {

        public MCQ()
        {
            Header = "MCQ Question";
            Answers = new Answer[3];
            Console.WriteLine($"{Header}");
            Console.WriteLine("Please Enter Question Body");
            Body = Console.ReadLine();
            Console.WriteLine("Please Enter Question Mark");
            Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choices Of Question");
            for (int i = 0; i < 3; i++)
            {
                Answers[i] = new Answer();
                Console.WriteLine($"Please Enter Choice Number {i + 1}");
                Answers[i].AnsText = Console.ReadLine();
            }
            Console.WriteLine("Enter Right Answer ID");
            RightAnswer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{Body}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}-) {Answers[i].AnsText}");
            }
        }

        //public override void MakeQuestion()
        //{
        //    Console.WriteLine($"{Header}");
        //    Console.WriteLine("Please Enter Question Body");
        //    Body = Console.ReadLine();
        //    Console.WriteLine("Please Enter Question Mark");
        //    Mark = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Choices Of Question");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Answers[i] = new Answer();
        //        Console.WriteLine($"Please Enter Choice Number {i + 1}");
        //        Answers[i].AnsText = Console.ReadLine();
        //    }
        //    Console.Clear();
        //}

    }
}
