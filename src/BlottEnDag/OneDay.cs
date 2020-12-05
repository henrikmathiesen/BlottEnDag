
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlottEnDag
{

    public class OneDay
    {
        public static readonly int MAX_RATING = 5;

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

            return 5;
        }

    }

}
