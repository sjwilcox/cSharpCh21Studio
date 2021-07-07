using System;

namespace FunWithQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            TrueFalse q1 = new TrueFalse("Is a rabbit heavier than an anvil.", "false", "True", "False", "true", "false");
            quiz.AddQuestion(q1);

            CheckTheBox q2 = new CheckTheBox("Who is in this household?", "Ryan, Chrissa, Steven", "Diana", "Chirssa", "Silvia", "Steven", "Ryan");
            quiz.AddQuestion(q2);

            MultipleChoice q3 = new MultipleChoice("What is 2 + 2?", "4", "1", "2", "3", "4");
            quiz.AddQuestion(q3);

            quiz.Run();
        }
    }
}
