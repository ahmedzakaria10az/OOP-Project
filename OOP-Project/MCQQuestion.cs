using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header,string body,int mark,Answer[] answers,int rightAnswerId)
                          : base(header, body, mark)
        {
            AnswerList = answers;
            RightAnswerId = rightAnswerId;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine($"Mark: {Mark}");

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine(AnswerList[i]);
            }
        }
    }
}
