namespace EquationSolving
{
    public static class EquationSolver
    {
        public static List<AnswerSet> FindProperSets(int amount)
        {
            var answers = new List<AnswerSet>();

            for (int a = 1; answers.Count < amount; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    for (int c = b + 1; c < a; c++)
                    {
                        var d = FindD(a, b, c);
                        if ((int)d == d && d < c)
                        {
                            var set = new AnswerSet(a, b, c, (int)d);                               
                            answers.Add(set);
                        }
                    }
                }
            }

            return answers;
        }

        private static double FindD(int a, int b, int c)
        {
            var dCube = Math.Pow(a, 3) + Math.Pow(b, 3) - Math.Pow(c, 3);
            return Math.Cbrt(dCube);
        }
    }
}