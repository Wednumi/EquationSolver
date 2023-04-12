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

                    var c = a - 1;

                    int cCube;
                    int dCube;

                    while (c > b)
                    {
                        if (answers.Count == amount)
                        {
                            return answers;
                        }

                        cCube = Cube(c);
                        dCube = leftSum - cCube;
                        if(dCube > cCube)
                        {
                            break;
                        }

                        var d = Math.Cbrt(dCube);
                        if (d == (int)d)
                        {
                            var set = new AnswerSet(a, b, c, (int)d);
                            answers.Add(set);
                        }

                        c--;
                    }
                }
            }
        }

        private static int Cube(int i) => (int)Math.Pow(i, 3);
    }
}