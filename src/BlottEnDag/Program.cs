using System;

namespace BlottEnDag
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ännu en dag. Fyll i J för Ja, N för Nej. Eller tryck Q för att avbryta");

            var oneDay = new OneDay(DateTime.Now);
            var userAborted = false;

            for (int i = 0; i < oneDay.GetQuestionCount(); i++)
            {
                Console.WriteLine(oneDay.GetQuestion(i));

                var answer = Console.ReadLine();

                switch (answer.ToLower())
                {
                    case "q":
                        userAborted = true;
                        break;
                    case "j":
                        oneDay.SetAnswer(i, true);
                        break;
                    case "n":
                        oneDay.SetAnswer(i, false);
                        break;
                    default:
                        Console.WriteLine("FEL!");
                        i--;
                        break;
                }

                if (userAborted)
                {
                    break;
                }
            }

            if (userAborted)
            {
                Console.WriteLine("Avbryten");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sparad. Som din dag ska ock din kraft vara");
                Console.WriteLine();
                Console.WriteLine(oneDay.GetDate());
                Console.WriteLine();

                for (int i = 0; i < oneDay.GetQuestionCount(); i++)
                {
                    Console.WriteLine(oneDay.GetQuestionAndAnswer(i));
                }
            }



        }
    }
}
