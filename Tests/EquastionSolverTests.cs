using EquationSolving;

namespace Tests
{
    public class EquastionSolverTests
    {
        [Fact]
        public void Solve_FindsCorrectSets()
        {
            var sut = new EquastionSolver(100);

            var result = sut.Solve();

            result.ForEach(s => AssertSet(s));
        }

        private void AssertSet(AnswerSet set)
        {
            var left = Math.Pow(set.Left.A, 3) + Math.Pow(set.Left.B, 3);
            var right = Math.Pow(set.Right.A, 3) + Math.Pow(set.Right.B, 3);

            Assert.Equal(left, right);
        }

        [Fact]
        public void Solve_FindsUnicSets()
        {
            var sut = new EquastionSolver(100);

            var result = sut.Solve();

            var resultCount = result.Count();
            var resultDistinctCount = result.Distinct().Count();
            Assert.Equal(resultCount, resultDistinctCount);
        }
    }
}