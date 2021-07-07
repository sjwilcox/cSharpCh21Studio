using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuiz
{
    class CheckTheBox : Questions
    {
        List<string> choices = new List<string>();

        public CheckTheBox(string q, string a, params string[] choices) : base(q, a)
        {
            foreach(string choice in choices)
            {
                this.choices.Add(choice);
            }
        }
        
        public override void DisplayAnswers()
        {
            Console.WriteLine("Check all that apply.");

            foreach(string a in choices)
            {
                Console.WriteLine(a);
            }
        }
    }
}
