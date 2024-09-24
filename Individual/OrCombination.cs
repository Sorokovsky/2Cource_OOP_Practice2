namespace Individual
{
    public class OrCombination : Element
    {
        public int Result(int x3, int x2, int x0)
        {
            x2 = Inversion(x2);
            x0 = Inversion(x0);
            return x3 | x2 | x0;
        }
    }
}