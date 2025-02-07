using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Exam
{
    internal class Exam
    {
        #region Properties
        public int NumberOfQuestions { get; set; }

        //NOTE: Time DataType is TimeSpan --> (not DateTime)

        private TimeSpan Time;
        #endregion

        #region Methods
        public TimeSpan _time()
        {
            Time = TimeSpan.FromMinutes(Minutes());
            return Time;
        }

        // Method for Setting Minutes of TimeSpan property

        // NOTE: Implement this method to set the Time property of the Exam class
        public static int Minutes()
        {
            int _minutes;
            do
            {
                _minutes = int.Parse(Console.ReadLine());
            } while (_minutes < 30 || _minutes > 180);
            return _minutes;
        }

        public Exam()
        {
            Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final) ");
            int _type = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Time Of The Exam From ( 30 min to 180 min )");
            Minutes();
            Console.WriteLine("Please Enter The Number Of Questions");
            NumberOfQuestions = int.Parse(Console.ReadLine());
            if (_type == 1)
            {
                 new PracticalExam();
            }
            else if (_type == 2)
            {
                 new FinalExam();
            }
        }
        #endregion
    }

    internal class FinalExam : Exam
    // Remember:
    //      1. Final Exam has MCQ & TF Questions
    //      2. Final Exam Shows the Questions, Answers and Grade. --> Can be implemented by ToString() Method override
    {
        public FinalExam()
        {
            // Note this for loop --> to create the number of questions based on the user input
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine("Please Enter The Type Of Question ( 1 For MCQ | 2 For True | False )");
                int _type = int.Parse(Console.ReadLine());
                if (_type == 1)
                {
                    MCQ mcq = new MCQ();
                }
                else if (_type == 2)
                {
                    TF tf = new TF();
                }
            }
        }
    }

    internal class PracticalExam : Exam
    // Remember:
    //      1. Practical Exam has MCQ Questions only
    //      2. Practical Exam Shows the right answer after finishing the Exam. --> Can be implemented by ToString() Method override
    {
        public PracticalExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                MCQ mcq = new MCQ();
            }
        }
    }
}
