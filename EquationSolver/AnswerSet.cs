namespace EquationSolving
{
    public class AnswerSet
    {
        public EquastionSide Left { get; set; }

        public EquastionSide Right { get; set; }

        public AnswerSet(EquastionSide left, EquastionSide right)
        {
            Left = left;
            Right = right;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not AnswerSet set)
            {
                return false;
            }

            return (Left.Equals(set.Left) && Right.Equals(set.Right))
                || (Left.Equals(set.Right) && Right.Equals(set.Left));
        }

        public override string ToString()
        {
            return $"{Left.A}, {Left.B}, {Right.A}, {Right.B}";
        }
    }
}
