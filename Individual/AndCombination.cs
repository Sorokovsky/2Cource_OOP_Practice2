namespace Individual
{
    public class AndCombination : Element
    {
        public int Result(int x3, int x1)
        {
            x3 = Inversion(x3);
            return x3 & x1;
        }
    }
}