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
        public Exam ExamOfSubject { get; set; }


    }
}
