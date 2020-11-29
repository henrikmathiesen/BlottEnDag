
using System.Collections.Generic;

namespace BlottEnDag
{

    public class OneDay
    {

        private string date;
        
        // TODO: object instead
        private List<string> questions;
        private List<bool> answers;

        public OneDay(string date)
        {
            this.date = date;
            this.questions = QuestionsAndAnswers.questions;
            this.answers = QuestionsAndAnswers.answers;
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
