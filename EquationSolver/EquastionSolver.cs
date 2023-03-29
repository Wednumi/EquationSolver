namespace EquationSolving
{
    public class EquastionSolver
    {
        private record Request(EquastionSide Left, int C);

        private readonly int[] _cubeTable;

        private readonly List<AnswerSet> _answers;

        private int _range => _cubeTable.Length - 1;

        public EquastionSolver(int range)
        {
            _cubeTable = new int[range + 1];
            _answers = new List<AnswerSet>();
            SetCubeTable();
        }

        private void SetCubeTable()
        {
            for (int i = 1; i < _cubeTable.Length; i++)
            {
                _cubeTable[i] = (int)Math.Pow(i, 3);
            }
        }

        public List<AnswerSet> Solve()
        {
            for (int a = 1; a <= _range; a++)
            {
                for (int b = 1; b <= _range; b++)
                {
                    var left = new EquastionSide(a, b);
                    AddAnswers(left);
                }
            }

            return _answers;
        }

        private void AddAnswers(EquastionSide left)
        {
            for (int c = 1; c <= _range; c++)
            {
                var request = new Request(left, c);
                if (TryFindD(request, out var d) is false)
                {
                    continue;
                }

                var set = new AnswerSet(left, new EquastionSide(c, d));

                if (SetCorrect(set))
                {
                    _answers.Add(set);
                }
            }
        }

        private bool TryFindD(Request request, out int d)
        {
            var dCube = _cubeTable[request.Left.A] 
                + _cubeTable[request.Left.B] - _cubeTable[request.C];

            if(dCube < 0)
            {
                d = -1;
                return false;
            }

            d = Array.IndexOf(_cubeTable, dCube);
            return d != -1;
        }

        private bool SetCorrect(AnswerSet set)
        {
            return !(set.Left.Equals(set.Right) || _answers.Contains(set));
        }        
    }
}
