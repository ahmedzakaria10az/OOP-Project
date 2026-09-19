using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time,int numberOfQuestions,Subject subject)
                            : base(time, numberOfQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQuestion();

                Console.Write("Enter your answer: ");
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Right Answers");

            for (int i = 0; i < Questions.Length; i++)
            {
                int rightId = Questions[i].RightAnswerId;

                for (int j = 0; j < Questions[i].AnswerList.Length; j++)
                {
                    if (Questions[i].AnswerList[j].AnswerId == rightId)
                    {
                        Console.WriteLine(Questions[i].AnswerList[j].AnswerText);
                    }
                }
            }
        }
    }
}
