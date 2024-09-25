namespace Individual
{
    public class FinalOr
    {
        private readonly AndCombination _andCombination;
        private readonly XorCombination _xorCombination;
        private readonly And2Combinatin _and2Combinatin;
        private readonly OrCombination _orCombination;
        
        public FinalOr()
        {
            _andCombination = new AndCombination();
            _xorCombination = new XorCombination();
            _and2Combinatin = new And2Combinatin();
            _orCombination = new OrCombination();
        }

        public int Result(int x0, int x1, int x2, int x3)
        {
            int res1 = _andCombination.Result(x3, x1);
            int res2 = _xorCombination.Result(x2, x3, x1, x0);
            int res3 = _and2Combinatin.Result(x3, x1, x0);
            int res4 = _orCombination.Result(x3, x2, x0);
            return res1 | res2 | res3 | res4;
        }
    }
}