using System;
using Microsoft.Extensions.Configuration;

namespace BlottEnDag
{
    class Program
    {
        private static readonly string greeting = "Ännu en dag.";
        private static readonly string instructions = "Fyll i J för Ja, N för Nej. Eller tryck Q för att avbryta.";

        static void Main(string[] args)
        {
            var configuration = SetupAppSettings();

            Console.WriteLine($"{greeting} {instructions}");

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
                        Console.WriteLine(instructions);
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

                oneDay.Save();
                
                Console.WriteLine("Sparad. Som din dag ska ock din kraft vara");
                Console.WriteLine();
                Console.WriteLine(oneDay.GetDate());
                Console.WriteLine();

                Console.WriteLine($"Din dag fick betyget {oneDay.GetRating()} av {OneDay.MAX_RATING}");
                Console.WriteLine();

                for (int i = 0; i < oneDay.GetQuestionCount(); i++)
                {
                    Console.WriteLine(oneDay.GetQuestionAndAnswer(i));
                }
            }
        }

        static private IConfiguration SetupAppSettings()
        {
            // https://blog.hildenco.com/2020/05/configuration-in-net-core-console.html
            // But also remember to copy in the .csproj file

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            return configuration;
        }
    }
}
