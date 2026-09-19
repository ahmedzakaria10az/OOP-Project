using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public int RightAnswerId { get; set; }

        public Question(string header,string body,int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new Answer[0];
        }

        public abstract void ShowQuestion();

        public override string ToString()
        {
            return $"Header : {Header} && Body : {Body}";
        }
    }
}
