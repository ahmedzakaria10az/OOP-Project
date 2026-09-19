namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C# Programming");

            FinalExam exam = new FinalExam(60, 2, subject);

            Answer[] answers1 =
            {
            new Answer(1, "True"),
            new Answer(2, "False")
        };

            MCQQuestion question1 = new MCQQuestion(
                "Question 1",
                "Which language is used with .NET?",
                5,
                answers1,
                1
            );

            Answer[] answers2 =
            {
            new Answer(1, "HTML"),
            new Answer(2, "C#"),
            new Answer(3, "CSS")
        };

            MCQQuestion question2 = new MCQQuestion(
                "Question 2",
                "Which one is an OOP language?",
                5,
                answers2,
                2
            );

            exam.Questions[0] = question1;
            exam.Questions[1] = question2;

            subject.CreateExam(exam);

            Console.WriteLine(subject);
            Console.WriteLine("Exam Time: " + subject.Exam.Time);

            subject.Exam.ShowExam();
        }
    }
}