using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public override string ToString()
        {
            return $"SubjectId : {SubjectId} &&  SubjectName: {SubjectName}";
        }
    }
}
