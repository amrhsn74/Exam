using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam;

namespace Exam
{
    internal abstract class Question
    {
        #region Properties
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer[]? Answers { get; set; }
        public int RightAnswer { get; set; }
        #endregion

        #region Methods

        public abstract void DisplayQuestion();
        public abstract void MakeQuestion();

        #endregion

    }
}
