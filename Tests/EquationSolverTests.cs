using EquationSolving;

namespace Tests
{
    public class EquationSolverTests
    {
        [Fact]
        public void FindProperSets_SimilarToNaive()
        {
            var amount = 40;
            var naiveResult = NaiveSolve(amount);

            var result = EquationSolver.FindProperSets(amount);

            Assert.Equal(naiveResult, result);
        }

        private static List<AnswerSet> NaiveSolve(int amount)
        {
            var answers = new List<AnswerSet>();

            for (int a = 1; answers.Count < amount; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    for (int c = 1; c < a; c++)
                    {
                        for (int d = 1; d < a; d++)
                        {
                            if (new int[] { a, b, c, d }.Distinct().Count() != 4)
                            {
                                continue;
                            }
                            if (Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                            {
                                var set = new AnswerSet(a, b, c, d);
                                if (!answers.Contains(set))
                                {
                                    answers.Add(set);
                                }
                            }
                        }
                    }
                }
            }

            return answers;
        }
    }
}