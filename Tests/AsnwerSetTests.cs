using EquationSolving;

namespace Tests
{
    public class AsnwerSetTests
    {
        [Fact]
        public void Equals_IgnoreOrder()
        {
            var set1 = new AnswerSet(new EquastionSide(1, 2), new EquastionSide(3, 4));
            var set2 = new AnswerSet(new EquastionSide(2, 1), new EquastionSide(4, 3));

            var equal = set1.Equals(set2);

            Assert.True(equal);
        }

        [Fact]
        public void Equals_IgnoreSide()
        {
            var set1 = new AnswerSet(new EquastionSide(1, 2), new EquastionSide(3, 4));
            var set2 = new AnswerSet(new EquastionSide(3, 4), new EquastionSide(1, 2));

            var equal = set1.Equals(set2);

            Assert.True(equal);
        }
    }
}
