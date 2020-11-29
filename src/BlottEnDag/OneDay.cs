
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlottEnDag
{

    public class OneDay
    {

        private DateTime date;
        
        // TODO: object instead
        private List<string> questions;
        private List<bool> answers;

        public OneDay(DateTime date)
        {
            this.date = date;
            this.questions = QuestionsAndAnswers.questions;
            this.answers = QuestionsAndAnswers.answers;
        }

        public string GetDate()
        {
            var culture = new CultureInfo("sv-SE");
            var day = culture.DateTimeFormat.GetDayName(this.date.DayOfWeek);

            return $"{day.ToUpper()} {this.date.ToShortDateString()}";
        }

        public int GetQuestionCount()
        {
            if (this.questions.Count == this.answers.Count)
            {
                return this.questions.Count;
            }
            else
            {
                return 0;
            }
        }

        public string GetQuestion(int nr)
        {
            return this.questions[nr];
        }

        public string GetQuestionAndAnswer(int nr)
        {
            var question = this.questions[nr];
            var answer = this.answers[nr] == true ? "Ja" : "Nej";
            
            return $"{question} | {answer}";
        }

        public void SetAnswer(int nr, bool answer)
        {
            this.answers[nr] = answer;
        }

    }

}
