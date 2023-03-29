namespace EquationSolving
{
    public class EquastionSide
    {
        public int A { get; set; }

        public int B { get; set; }

        public EquastionSide(int a, int b)
        {
            A = a;
            B = b;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not EquastionSide side)
            {
                return false;
            }

            return Enumerable.SequenceEqual(
                ToList().Order(), 
                side.ToList().Order());
        }

        private List<int> ToList()
        {
            return new List<int>()
            {
                A, B
            };
        }
    }
}
