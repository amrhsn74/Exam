using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Question
    {
        #region Properties
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer[]? Answers { get; set; }
        public int RightAnswer { get; set; }
        #endregion

        #region Methods
        public Question(string _header)
        {
            Header = _header;
        }
        #endregion

    }

    internal class MCQ : Question
    {
        public MCQ() : base("MCQ Question")
        {
            //Header = "MCQ Question";
            Console.WriteLine($"{Header}");
            Console.WriteLine("Please Enter Question Body");
            Body = Console.ReadLine();
            Console.WriteLine("Please Enter Question Mark");
            int _Mark;
            bool isMark = false;
            do
            {
                isMark = int.TryParse(Console.ReadLine(), out _Mark);
            } while (!isMark);
            Console.WriteLine("Choices Of Question");
            Answers = new Answer[3];
            for (int i = 0; i < 3; i++)
            {
                Answers[i] = new Answer();
                Console.WriteLine($"Please Enter Choice Number {i + 1}");
                Answers[i].AnsText = Console.ReadLine();
            }
            Console.WriteLine("Please Enter The Right Answer ID");
            RightAnswer = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();
        }

        #region 2nd Solution
        //public void setHeader()
        //{
        //    Header = "MCQ Question";
        //}
        //public override void CreateQuestion()
        //{
        //    Console.WriteLine($"{Header}");
        //    Console.WriteLine("Please Enter Question Body");
        //    Body = Console.ReadLine();
        //    Console.WriteLine("Please Enter Question Mark");
        //    //Mark = Convert.ToInt32(Console.ReadLine());
        //    int _Mark;
        //    bool isMark = false;
        //    do
        //    {
        //        isMark = int.TryParse(Console.ReadLine(), out _Mark);
        //        if (!isMark)
        //        {
        //            Console.WriteLine("Please Enter A Valid Number");
        //        }
        //    } while (!isMark);
        //    Console.WriteLine("Choices Of Question");
        //    Answers = new Answer[3];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Answers[i] = new Answer();
        //        Console.WriteLine($"Please Enter Choice Number {i + 1}");
        //        Answers[i].AnsText = Console.ReadLine();
        //    }
        //    Console.WriteLine("Please Enter The Right Answer ID");
        //    RightAnswer = Convert.ToInt32(Console.ReadLine());
        //}
        #endregion
    }


    internal class TF : Question
    {
        public TF() : base("True | False Question")
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine("Please Enter Question Body");
            Body = Console.ReadLine();
            Console.WriteLine("Please Enter Question Mark");
            int _Mark;
            bool isMark = false;
            do
            {
                isMark = int.TryParse(Console.ReadLine(), out _Mark);
            } while (!isMark);
            Console.WriteLine("Please Enter The Right Answer ID ( 1 for True | 2 for False)");
            RightAnswer = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();
        }

        #region 2nd Solution
        //public void setHeader()
        //{
        //    Header = "True | False Question";
        //}
        //public override void CreateQuestion()
        //{
        //    Console.WriteLine($"{Header}");
        //    Console.WriteLine("Please Enter Question Body");
        //    Body = Console.ReadLine();
        //    Console.WriteLine("Please Enter Question Mark");
        //    Mark = Convert.ToInt32(Console.ReadLine());
        //    do
        //    {
        //    Console.WriteLine("Please Enter The Right Answer ID ( 1 for True | 2 for False)");
        //    RightAnswer = Convert.ToInt32(Console.ReadLine());
        //    } while (RightAnswer != 1 || RightAnswer != 2);
        //}
        #endregion
    }
}
