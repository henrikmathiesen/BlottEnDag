using System;

namespace BlottEnDag
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Say something");

            // var input = Console.ReadLine();
            // var today = DateTime.Now.ToShortDateString();

            // var oneDay = new OneDay(today);

            // Console.WriteLine(input);

            var oneDay = new OneDay(DateTime.Now.ToShortDateString());

            for (int i = 0; i < oneDay.GetQuestionCount(); i++)
            {
                Console.WriteLine(oneDay.GetQuestionAndAnswer(i));
            }


            
        }
    }
}
