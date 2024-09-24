namespace Individual
{
    public class XorCombination : Element
    {
        public int Result(int x2, int x3, int x0, int x1)
        {
            x2 = Inversion(x2);
            x1 = Inversion(x1);
            return x2 ^ x3 ^ x0 ^ x1;

        } 
    }
}