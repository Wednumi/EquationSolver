namespace EquationSolving
{
    public static class EquationSolver
    {
        public static List<AnswerSet> FindSets(int amount)
        {
            var answers = new List<AnswerSet>();

            for (int a = 1; ; a++)
            {
                var aCube = Cube(a);
                for (int b = 1; b < a; b++)
                {
                    var bCube = Cube(b);
                    var leftSum = aCube + bCube;

                    for(int c = a - 1; c > b; c--)
                    {
                        if (answers.Count == amount)
                        {
                            return answers;
                        }

                        var cCube = Cube(c);
                        var dCube = leftSum - cCube;
                        if(cCube <= dCube)
                        {
                            break;
                        }

                        var d = Math.Cbrt(dCube);
                        if (d == (int)d)
                        {
                            var set = new AnswerSet(a, b, c, (int)d);
                            answers.Add(set);
                        }
                    }
                }
            }
        }

        private static int Cube(int i) => i * i * i;
    }
}