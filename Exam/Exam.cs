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
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[]? QuestionList { get; set; }

        #endregion

        #region Methods

        public virtual void StartExam() { }
        #endregion
    }
}
