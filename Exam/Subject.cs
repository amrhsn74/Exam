using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string? SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int SubjectID, string SubjectName)
        {
            this.SubjectID = SubjectID;
            this.SubjectName = SubjectName;
            Console.WriteLine("Please Enter The Type Of Exam ( 1 For Practical | 2 For Final)");
            Console.Clear();
            int Type = int.Parse(Console.ReadLine());
            switch (Type)
            {
                case 1:
                    SubjectExam = new PracticalExam();
                    break;
                case 2:
                    SubjectExam = new FinalExam();
                    break;
            }

        }

    }
}
