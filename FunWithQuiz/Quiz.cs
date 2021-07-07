using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuiz
{
    class Quiz
    {
        List<Questions> questions = new List<Questions>();
        int totalCorrect;

        public Quiz()
        {
            totalCorrect = 0;
        }

        public void AddQuestion(Questions question)
        {
            questions.Add(question);
        }


        public void Run()
        {
            Console.WriteLine("Starting the quiz:");

            foreach(Questions q in questions)
            {
                q.DisplayQuestion();
                q.DisplayAnswers();
                string answer = Console.ReadLine();

                if (q.CheckAnswer(answer))
                    totalCorrect += 1;
            }

            Console.WriteLine("Thank you for taking this quiz\n");

            GradeQuiz();
        }

        private void GradeQuiz()
        {
            int totalQuestions = questions.Count;

            double score = (double)totalCorrect / (double)totalQuestions;
            score *= 100;

            Console.WriteLine($"Your score is {score}");
        }
    }
}
