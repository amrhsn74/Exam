using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam()
        {
            do
            {
                Console.WriteLine("Please Enter The Time Of Exam From (30 min to 180 min)");
                Time = int.Parse(Console.ReadLine());

            } while (Time < 30 || Time > 180);
            Console.WriteLine("Please Enter The Number Of Questions");
            NumberOfQuestions = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine("Please Enter The Type of Question (1 For MCQ | 2 For True | False)");
                int _type = int.Parse(Console.ReadLine());
                if (_type == 1 )
                {
                    QuestionList[i] = new MCQ();
                }
                else if (_type == 2 )
                {
                    QuestionList[i] = new TF();
                }
            }
            Console.Clear();
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
            int total_user = 0;
            int total_marks = 0;
            Console.WriteLine($"Exam Time: {Time}");
            Console.WriteLine("Number of Questions: " + NumberOfQuestions);
            for (int i = 0; i < QuestionList.Length; i++)
            {
                total_marks += QuestionList[i].Mark;
                Console.WriteLine($"Question {i + 1}: Marks {QuestionList[i].Mark}");
                QuestionList[i].DisplayQuestion();
                Console.WriteLine("Enter your answer");
                user_ans[i] = Convert.ToInt32(Console.ReadLine());
                if (user_ans[i] == QuestionList[i].RightAnswer)
                {
                    total_user += QuestionList[i].Mark;
                }
            }
            Console.Clear();
            stopwatch.Stop();
            TimeSpan timer = stopwatch.Elapsed;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                QuestionList[i].DisplayQuestion();
                Console.WriteLine($"Q{i + 1})\t{QuestionList[i].Body}: {QuestionList[i].Answers[user_ans[i] - 1].AnsText}");
                Console.WriteLine($"Your Answers: {user_ans[i]}");
            }
            Console.WriteLine($"Your Exam Grade is {total_user} from {total_marks}");
            Console.WriteLine($"Time = {timer}");
            Console.WriteLine("Thank You!");
        }
    }
}
