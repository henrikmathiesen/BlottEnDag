using System;
using Xunit;

namespace BlottEnDag.Tests
{
    public class OneDayTests
    {
        [Fact]
        public void UseTheQuestionCountToSetAnswersAndGetTheAnswers()
        {
            var oneDay = new OneDay(DateTime.Now);

            for (int i = 0; i < oneDay.GetQuestionCount(); i++)
            {
                oneDay.SetAnswer(i, GetIsEvenNumber(i) ? true : false);
            }

            for (int i = 0; i < oneDay.GetQuestionCount(); i++)
            {
                var answer = oneDay.GetQuestionAndAnswer(i);
                
                var actual = answer.Split(" | ")[1].Trim();
                var expected = GetIsEvenNumber(i) ? "Ja" : "Nej";

                Assert.Equal(expected, actual);
            }
        }

        private bool GetIsEvenNumber(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
