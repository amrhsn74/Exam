using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam()
        {
            do
            {
                Console.WriteLine("Please Enter The Time Of Exam From (30 min to 180 min)");
                Time = int.Parse(Console.ReadLine());

            } while (Time < 30 || Time > 180);
            Console.WriteLine("Please Enter The Number Of Questions");
            NumberOfQuestions = int.Parse(Console.ReadLine());
            QuestionList = new Question[NumberOfQuestions];
            Console.Clear();
            for (int i = 0; i < QuestionList.Length; i++)
            {
                QuestionList[i] = new MCQ();
            }
            Console.WriteLine("Do You Want To Start The Exam ( Y | N ): ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                StartExam();
            }
        }

        public override void StartExam()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] user_ans = new int[NumberOfQuestions];
            int total = 0;
            //QuestionList = new Question[NumberOfQuestions];
            for (int i = 0; i < QuestionList.Length; i++)
            {
                Console.WriteLine($"{QuestionList[i].Header}");
                Console.WriteLine($"Question {i + 1}:    Marks {QuestionList[i].Mark}");
                QuestionList[i].DisplayQuestion();
                Console.WriteLine("Please Enter The Answer ID");
                user_ans[i] = Convert.ToInt32(Console.ReadLine());
                if (user_ans[i] == QuestionList[i].RightAnswer)
                {
                    total += QuestionList[i].Mark;
                }
            }
            Console.Clear();
            stopwatch.Stop();
            TimeSpan timer = stopwatch.Elapsed;
            for (int i = 0; i < QuestionList.Length; i++)
            {
                Console.WriteLine($"Your Answers: {user_ans[i]}");
            }
            Console.WriteLine($"Time = {timer}");
            Console.WriteLine("Thank You!");
        }
    }
}
