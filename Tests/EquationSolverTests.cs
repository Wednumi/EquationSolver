using EquationSolving;

namespace Tests
{
    public class EquationSolverTests
    {
        [Fact]
        public void FindSets_SetHasEqualSumOfCubes()
        {
            var result = EquationSolver.FindSets(1).First();

            var sumOfCubesEqual = Math.Pow(result.A, 3) + Math.Pow(result.B, 3) ==
                Math.Pow(result.C, 3) + Math.Pow(result.D, 3);
            Assert.True(sumOfCubesEqual);
        }

        [Fact]
        public void FindSets_ReturnDistinct()
        {
            var amount = 2;
            var result = EquationSolver.FindSets(amount);

            var distinctCount = result.Distinct().Count();
            Assert.Equal(amount, distinctCount);
        }
    }
}