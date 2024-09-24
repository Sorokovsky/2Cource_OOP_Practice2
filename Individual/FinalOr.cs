namespace Individual
{
    public class FinalOr
    {
        private AndCombinatin _andCombinatin;
        private XorCombination _xorCombination;
        private And2Combinatin _and2Combinatin;
        private OrCombination _orCombination;

        public int Result(int x0, int x1, int x2, int x3)
        {
            int res1 = _andCombinatin.Result(x3, x2);
            int res2 = _xorCombination.Result(x2, x3, x0, x1);
            int res3 = _and2Combinatin.Result(x3, x1, x0);
            int res4 = _orCombination.Result(x3, x2, x0);
            return res1 | res2 | res3 | res4;
        }
    }
}