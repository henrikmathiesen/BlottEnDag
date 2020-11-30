
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlottEnDag
{

    public class OneDay
    {

        private DateTime date;

        private List<QuestionAndAnswer> questionAndAnswer;

        public OneDay(DateTime date)
        {
            this.date = date;
            this.questionAndAnswer = QuestionsAndAnswers.GetQuestionsAndAnswers;
        }

        public string GetDate()
        {
            var culture = new CultureInfo("sv-SE");
            var day = culture.DateTimeFormat.GetDayName(this.date.DayOfWeek);

            return $"{day.ToUpper()} {this.date.ToShortDateString()}";
        }

        public int GetQuestionCount()
        {
            return this.questionAndAnswer.Count;
        }

        public string GetQuestion(int nr)
        {
            return this.questionAndAnswer[nr].Question;
        }

        public string GetQuestionAndAnswer(int nr)
        {
            var question = this.questionAndAnswer[nr].Question;
            var answer = this.questionAndAnswer[nr].Answer == true ? "Ja" : "Nej";
            
            return $"{question} | {answer}";
        }

        public void SetAnswer(int nr, bool answer)
        {
            this.questionAndAnswer[nr].Answer = answer;
        }

    }

}
