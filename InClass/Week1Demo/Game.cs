using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Demo
{
    internal class Game
    {
        List<FactAnswerCombo> statements = new List<FactAnswerCombo>();

        public void Run()
        {
            MakeStatements();

            var userFact = Ask();

            for(int i = 0; i < 10; i++)
            {
                GetAnswer(userFact);
            }

            GiveAnswer(userFact);
        }

        private void GiveAnswer(FactAnswerCombo userFact)
        {
            var result = Compare(Compare(userFact.Answer1, userFact.Answer0), userFact.Answer2);
            Console.WriteLine($"The correct answer is {result.Ans}");

        }

        private Answer Compare(Answer x, Answer y)
        {
            if (x.Count>y.Count)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        private void GetAnswer(FactAnswerCombo userFact)
        {
            Console.WriteLine("Enter an answer: ");
            var answer = Console.ReadLine().ToLower();

            if(answer == userFact.Answer0.Ans.ToLower())
            {
                userFact.Answer0.Count++;
            }
            if (answer == userFact.Answer1.Ans.ToLower())
            {
                userFact.Answer0.Count++;
            }
            if (answer == userFact.Answer2.Ans.ToLower())
            {
                userFact.Answer0.Count++;
            }
            else
            {

            }
        }

        private FactAnswerCombo Ask()
        {
            Console.WriteLine($"The first fact is {statements[0].Fact0}");
            Console.WriteLine($"The second fact is {statements[0].Fact1}");

            return statements[0];
        }

        private void MakeStatements()
        {
            var statement1 = new FactAnswerCombo();
            var statement2 = new FactAnswerCombo();

            statement1.Fact0 = "1";
            statement1.Fact1 = "diagonal";
            statement1.Answer0 = new Answer() { Ans = "a" };
            statement1.Answer1 = new Answer() {Ans =  "b" };
            statement1.Answer2 = new Answer() { Ans = "c" };

            statement2.Fact0 = "2";
            statement2.Fact1 = "labradoodle";
            statement2.Answer0 = new Answer() { Ans = "at least 6" };
            statement2.Answer1 = new Answer() { Ans = "soup" };
            statement2.Answer2 = new Answer() { Ans = "bee" };

            statements.Add(statement1);
            statements.Add(statement2);
        }
    }
}
