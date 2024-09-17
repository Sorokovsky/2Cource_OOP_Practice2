namespace Individual
{
    public class Combination : Element
    {
        public new int OutCount { get { return base.OutCount; } init { base.OutCount = value; } }

        public Combination() : base()
        {
        }

        public Combination(string name) : base(name)
        {
        }

        public Combination(string name, int inCount) : base(name, inCount, 1)
        {
        }

        
    }
}