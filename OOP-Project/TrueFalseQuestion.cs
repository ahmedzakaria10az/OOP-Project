using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header,string body,int mark) : base(header,body,mark)
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1,"True");
            AnswerList[1] = new Answer(2,"False");
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
