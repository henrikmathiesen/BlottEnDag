using System.Collections.Generic;

namespace BlottEnDag
{

    static class QuestionsAndAnswers
    {
        private static List<QuestionAndAnswer> _GetQuestionsAndAnswers = new List<QuestionAndAnswer>()
        {
            new QuestionAndAnswer { Question = "Tränade du CrossFit?", Answer = false },
            new QuestionAndAnswer { Question = "Gick du till lokala gymmet?", Answer = false },
            new QuestionAndAnswer { Question = "Tränade du i hemmagymmet?", Answer = false },
            new QuestionAndAnswer { Question = "Över 7000 steg på stegräknaren?", Answer = false },
            new QuestionAndAnswer { Question = "Under 3 timmar i fåtölj?", Answer = false },
            new QuestionAndAnswer { Question = "Ätit en frukt?", Answer = false },
            new QuestionAndAnswer { Question = "Ätit grönsaker?", Answer = false },
            new QuestionAndAnswer { Question = "Ätit efterrätt?", Answer = false },
            new QuestionAndAnswer { Question = "Ätit snacks?", Answer = false },
        };

        public static List<QuestionAndAnswer> GetQuestionsAndAnswers
        {
            get { return  _GetQuestionsAndAnswers; }
        }

    }

}
