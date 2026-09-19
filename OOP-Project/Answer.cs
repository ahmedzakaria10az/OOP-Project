using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class Answer : ICloneable, IComparable
    {
      public int AnswerId { get; set; }
    public string AnswerText { get; set; }

    public Answer(int id, string text)
    {
        AnswerId = id;
        AnswerText = text;
    }

    public object Clone()
    {
        return new Answer(AnswerId, AnswerText);
    }

    public int CompareTo(object obj)
    {
        Answer other = (Answer)obj;

        return AnswerId.CompareTo(other.AnswerId);
    }

        public override string ToString()
        {
            return $"AnswerId : {AnswerId} && AnswerText : {AnswerText}";
        }
    }
}
