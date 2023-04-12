namespace EquationSolving
{
    public class AnswerSet
    {
        private int? _hashCode;

        public int A { get; init; }

        public int B { get; init; }

        public int C { get; init; }

        public int D { get; init; }

        public AnswerSet(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override string ToString()
        {
            return $"{A}, {B}, {C}, {D}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not AnswerSet comparing)
            {
                return false;
            }

            return GetHashCode() == comparing.GetHashCode();
        }

        public override int GetHashCode()
        {
            if(_hashCode == null)
            {
                var sumOfCubes = Math.Pow(A, 3) + Math.Pow(B, 3);

                var leftRatio = GetRatio(A, B);
                var rightRatio = GetRatio(C, D);

                var minRatio = Math.Min(leftRatio, rightRatio);
                var maxRatio = Math.Max(leftRatio, rightRatio);

                _hashCode = HashCode.Combine(sumOfCubes, minRatio, maxRatio);
            }
            return (int)_hashCode;

            double GetRatio(int i, int j)
            {
                return (double)Math.Max(i, j) / Math.Min(i, j);
            }
        }
    }
}
