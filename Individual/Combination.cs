namespace Individual
{
    public class Combination : Element
    {
        public Combination() : base()
        {
            OutCount = 1;
        }

        public Combination(string name) : base(name)
        {
            OutCount = 1;
        }

        public Combination(string name, int inCount, int outCount) : base(name, inCount, outCount)
        {
            OutCount = 1;
        }
    }
}
