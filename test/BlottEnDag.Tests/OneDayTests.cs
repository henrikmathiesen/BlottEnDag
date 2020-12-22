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

        [Fact]
        public void GetRatingsTests_A()
        {
            // Homegym with a longer walk or atleast not slacking in Sofa, is a rating of 3

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, false);
            oneDay.SetAnswer(1, false);
            oneDay.SetAnswer(2, true);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, false);
            oneDay.SetAnswer(4, true);

            // Fruit, Veggies
            oneDay.SetAnswer(5, false);
            oneDay.SetAnswer(6, false);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(3, oneDay.GetRating());
        }

        [Fact]
        public void GetRatingsTests_B()
        {
            // Homegym with a longer walk or atleast not slacking in Sofa, and fruit/veggies is a rating of 5

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, false);
            oneDay.SetAnswer(1, false);
            oneDay.SetAnswer(2, true);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, false);
            oneDay.SetAnswer(4, true);

            // Fruit, Veggies
            oneDay.SetAnswer(5, true);
            oneDay.SetAnswer(6, false);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(5, oneDay.GetRating());
        }

        [Fact]
        public void GetRatingsTests_C()
        {
            // No gym. But walked long distance, no sofa, fruit and veggies (skipping either brings it down to 2, both to 1), is a rating of 4.

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, false);
            oneDay.SetAnswer(1, false);
            oneDay.SetAnswer(2, false);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, true);
            oneDay.SetAnswer(4, true);

            // Fruit, Veggies
            oneDay.SetAnswer(5, true);
            oneDay.SetAnswer(6, true);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(4, oneDay.GetRating());
        }

        [Fact]
        public void GetRatingsTests_D()
        {
            // No gym. But walked long distance, fruit and veggies, but also slacking in sofa, rating of 2.
            // No gym. Walked long distance, no sofa, fruit and veggies is a rating of 4.

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, false);
            oneDay.SetAnswer(1, false);
            oneDay.SetAnswer(2, false);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, true);
            oneDay.SetAnswer(4, true);

            // Fruit, Veggies
            oneDay.SetAnswer(5, true);
            oneDay.SetAnswer(6, true);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(4, oneDay.GetRating());
        }

        [Fact]
        public void GetRatingsTests_E()
        {
            // Cross fit. Didnt walk long distance, but no slacking in Sofa. Eat a fruit. 5 points (even without the fruit).

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, true);
            oneDay.SetAnswer(1, false);
            oneDay.SetAnswer(2, false);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, false);
            oneDay.SetAnswer(4, true);

            // Fruit, Veggies
            oneDay.SetAnswer(5, false);
            oneDay.SetAnswer(6, true);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(5, oneDay.GetRating());
        }

        [Fact]
        public void GetRatingsTests_F()
        {
            // Cross fit. Didnt walk long distance, and slacking in Sofa. Eat a fruit. 5 points (even without the fruit).

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, true);
            oneDay.SetAnswer(1, false);
            oneDay.SetAnswer(2, false);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, false);
            oneDay.SetAnswer(4, false);

            // Fruit, Veggies
            oneDay.SetAnswer(5, true);
            oneDay.SetAnswer(6, false);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(5, oneDay.GetRating());
        }

        [Fact]
        public void GetRatingsTests_G()
        {
            // Gym, no walk, no sofa, and one fruit. 5 points.

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, false);
            oneDay.SetAnswer(1, true);
            oneDay.SetAnswer(2, false);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, false);
            oneDay.SetAnswer(4, true);

            // Fruit, Veggies
            oneDay.SetAnswer(5, true);
            oneDay.SetAnswer(6, false);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(5, oneDay.GetRating());
        }

        [Fact]
        public void GetRatingsTests_H()
        {
            // Gym, no walk, sofa, and one fruit. 5 points. 4 without the fruit.

            var oneDay = new OneDay(DateTime.Now);

            // Exercise
            oneDay.SetAnswer(0, false);
            oneDay.SetAnswer(1, true);
            oneDay.SetAnswer(2, false);

            // Stegraknare, No Sofa
            oneDay.SetAnswer(3, false);
            oneDay.SetAnswer(4, false);

            // Fruit, Veggies
            oneDay.SetAnswer(5, true);
            oneDay.SetAnswer(6, false);

            // Dessert, Snacks
            oneDay.SetAnswer(7, false);
            oneDay.SetAnswer(8, false);

            Assert.Equal(5, oneDay.GetRating());
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
