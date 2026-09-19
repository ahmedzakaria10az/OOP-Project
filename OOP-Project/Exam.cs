using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Subject Subject { get; set; }

        public Exam(int time,int numberOfQuestions,Subject subject)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Subject = subject;
            Questions = new Question[numberOfQuestions];
        }
        public abstract void ShowExam();

    }
}
