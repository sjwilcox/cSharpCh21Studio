using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuiz
{
    class TrueFalse : Questions
    {
        List<string> choices = new List<string>();

        public TrueFalse(string q, string a, params string [] choices) : base(q, a)
        {
            foreach(string choice in choices)
            {
                this.choices.Add(choice);
            }
        }

        public override void DisplayAnswers()
        {
            Console.WriteLine("Please enter your answer exactly as the choices shown below.");

            foreach(string a in choices)
            {
                Console.WriteLine(a);
            }
        }
    }
}
