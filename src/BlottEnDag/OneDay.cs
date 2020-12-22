
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlottEnDag
{

    public class OneDay
    {
        public static readonly int MAX_RATING = 5;

        public static readonly int MIN_RATING = 1;

        private DateTime _Date;

        private List<QuestionAndAnswer> _QuestionAndAnswer;

        public OneDay(DateTime date)
        {
            this._Date = date;
            this._QuestionAndAnswer = QuestionsAndAnswers.GetQuestionsAndAnswers;
        }

        public string GetDate()
        {
            var culture = new CultureInfo("sv-SE");
            var day = culture.DateTimeFormat.GetDayName(this._Date.DayOfWeek);

            return $"{day.ToUpper()} {this._Date.ToShortDateString()}";
        }

        public int GetQuestionCount()
        {
            return this._QuestionAndAnswer.Count;
        }

        public string GetQuestion(int nr)
        {
            return this._QuestionAndAnswer[nr].Question;
        }

        public string GetQuestionAndAnswer(int nr)
        {
            var question = this._QuestionAndAnswer[nr].Question;
            var answer = this._QuestionAndAnswer[nr].Answer == true ? "Ja" : "Nej";

            return $"{question} | {answer}";
        }

        public void SetAnswer(int nr, bool answer)
        {
            this._QuestionAndAnswer[nr].Answer = answer;
        }

        public int GetRating()
        {
            var rating = 0;

            var didCrossFit = this._QuestionAndAnswer[0].Answer == true;
            var didLocalGym = this._QuestionAndAnswer[1].Answer == true;
            var didHomeGym = this._QuestionAndAnswer[2].Answer == true;
            var didManySteps = this._QuestionAndAnswer[3].Answer == true;
            var didntSitStill = this._QuestionAndAnswer[4].Answer == true;
            var didEatFruit = this._QuestionAndAnswer[5].Answer == true;
            var didEatVeggies = this._QuestionAndAnswer[6].Answer == true;
            var didEatDessert = this._QuestionAndAnswer[7].Answer == true;
            var didEatSnacks = this._QuestionAndAnswer[8].Answer == true;

            // ------------------------

            if (didCrossFit)
            {
                rating += 8;
            }

            if (didLocalGym)
            {
                rating += 7;
            }

            if (didHomeGym)
            {
                rating += 6;
            }

            // ------------------------

            if (didManySteps)
            {
                rating += 1;
            }
            else
            {
                rating -= 1;
            }

            if (didntSitStill)
            {
                rating += 1;
            }
            else
            {
                rating -= 1;
            }

            // ------------------------

            if (didEatFruit)
            {
                rating += 1;
            }
            else
            {
                rating -= 1;
            }

            if(didEatVeggies)
            {
                rating += 1;
            }
            else
            {
                rating -= 1;
            }

            if(didEatDessert)
            {
                rating -= 3;
            }

            if(didEatSnacks)
            {
                rating -= 3;
            }

            // ------------------------

            if (rating < OneDay.MIN_RATING)
            {
                return OneDay.MIN_RATING;
            }

            if (rating > OneDay.MAX_RATING)
            {
                return OneDay.MAX_RATING;
            }

            return rating;
        }

    }

}
