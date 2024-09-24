namespace Individual
{
    public abstract class Combination : Element
    {
        public abstract string Operation { get; init; }

        private int[] _inputs;

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

        public void SetInputs(params int[] inputs)
        {
            _inputs = new int[InCount];
            for (int i = 0; i < InCount; i++)
            {
                _inputs[i] = inputs[i];
            }
        }

        public abstract int GetOutput();

        public override void Show()
        {
            base.Show();
            for (int i = 0; i < InCount; i++)
            {
                Console.WriteLine($"x{i}: {_inputs.ElementAt(i)}.");
            }
            Console.WriteLine($"Output: {GetOutput()}.");
        }
    }
}