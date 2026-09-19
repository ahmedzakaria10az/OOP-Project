using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time,int numberOfQuestions,Subject subject)
                        : base(time, numberOfQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");

            int grade = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQuestion();

                Console.Write("Enter your answer: ");
                int answer = int.Parse(Console.ReadLine()!);

                if (answer == Questions[i].RightAnswerId)
                {
                    grade += Questions[i].Mark;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Your Grade: {grade}");
        }
    }
}