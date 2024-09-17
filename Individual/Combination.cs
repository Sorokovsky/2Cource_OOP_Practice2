namespace Individual
{
    public class Combination : Element
    {
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

        public int GetOutput()
        {
            int result = 0;
            int first, second, third, forth;
            if (InCount == 4)
            {
                first = _inputs.ElementAt(3) & _inputs.ElementAt(1);
                second = _inputs.ElementAt(2) ^ _inputs.ElementAt(3) ^ _inputs.ElementAt(2) ^ _inputs.ElementAt(0);
                third = _inputs.ElementAt(3) | _inputs.ElementAt(1) | _inputs.ElementAt(0);
                forth = _inputs.ElementAt(3) | _inputs.ElementAt(2) | _inputs.ElementAt(0);
                result = first | second | third | forth;
            }
            return result;
        }

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