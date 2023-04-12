using EquationSolving;

namespace Tests
{
    public class AnswerSetTests
    {
        [Fact]
        public void Equal_IgnoreSideOrder()
        {
            var set1 = new AnswerSet(1, 12, 9, 10);
            var set2 = new AnswerSet(9, 10, 1, 12);

            Assert.Equal(set1, set2);
        }

        [Fact]
        public void Equal_IgnoreOrderInSides()
        {
            var set1 = new AnswerSet(12, 1, 10, 9);
            var set2 = new AnswerSet(1, 12, 9, 10);

            Assert.Equal(set1, set2);
        }

        [Fact]
        public void Equal_DoNotMixSides()
        {
            var set1 = new AnswerSet(1, 12, 9, 10);
            var set2 = new AnswerSet(1, 9, 12, 10);

            Assert.NotEqual(set1, set2);
        }
    }
}