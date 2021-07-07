using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuiz
{
    public class MultipleChoice : Questions
    {
        List<string> choices = new List<string>();

        public MultipleChoice(string q, string a, params string[] choices) : base(q, a)
        {
            foreach(string choice in choices)
            {
                this.choices.Add(choice);
            }
        }

        public override void DisplayAnswers()
        {
            Console.WriteLine("Select the correct answer");

            foreach(string a in choices)
            {
                Console.WriteLine(a);
            }
        }
    }
}
