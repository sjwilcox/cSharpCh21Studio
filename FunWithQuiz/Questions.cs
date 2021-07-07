using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunWithQuiz
{
    public abstract class Questions
    {
        public string question { get; set; }
        public string answer { get; set; }
        
        public Questions(string ques, string ans)
        {
            question = ques;
            answer = ans;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(question);
        }

        public bool CheckAnswer(string a)
        {
            if (a == answer)
                return true;

            return false;
        }

        public abstract void DisplayAnswers();
    }
    

}
