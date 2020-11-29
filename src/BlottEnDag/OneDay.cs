
using System.Collections.Generic;

namespace BlottEnDag {

    public class OneDay {

        private string date;
        private List<string> questions = new List<string>();
        private List<bool> answers = new List<bool>();

        public OneDay(string date){
            this.date = date;
            this.setQuestions();
            this.setAnswers();
        }

        public int GetQuestionCount()
        {
            if(this.questions.Count == this.answers.Count) 
            {
                return this.questions.Count;
            }
            else {
                return 0;
            }
        }

        public string GetQuestion(int nr)
        {
            return this.questions[nr];
        }

        public void SetAnswer(int nr, bool answer) 
        {
            this.answers[nr] = answer;
        }

        public string GetQuestionAndAnswer(int nr)
        {
            return $"{this.questions[nr]} | {this.answers[nr]}";
        }

        private void setQuestions()
        {
            this.questions.Add("Tränade du CrossFit?");
            this.questions.Add("Gick du till lokala gymmet?");
            this.questions.Add("Tränade du i hemmagymmet?");
            this.questions.Add("Över 7000 steg på stegräknaren?");
            this.questions.Add("Under 3 timmar i fåtölj?");
            this.questions.Add("Ätit en frukt?");
            this.questions.Add("Ätit grönsaker?");
            this.questions.Add("Ätit efterrätt?");
            this.questions.Add("Ätit snacks?");
        }

        private void setAnswers()
        {
            this.answers.Add(false);
            this.answers.Add(false);
            this.answers.Add(false);
            this.answers.Add(false);
            this.answers.Add(false);
            this.answers.Add(false);
            this.answers.Add(false);
            this.answers.Add(false);
            this.answers.Add(false);
        }

    }

}
