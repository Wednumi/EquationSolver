namespace EquationSolving
{
    public class AnswerSet
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public int D { get; set; }

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
            if (obj is not AnswerSet compared)
            {
                return false;
            }

            return Enumerable.SequenceEqual(ToList().Order(), compared.ToList().Order());
        }

        private List<int> ToList()
        {
            return new List<int> { A, B, C, D };
        }
    }
}
