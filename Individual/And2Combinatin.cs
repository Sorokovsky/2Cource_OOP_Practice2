namespace Individual
{
    public class And2Combinatin : Element
    {
        public int Result(int x3, int x1, int x0)
        {
           x3 = Inversion(x3);
           x1 = Inversion(x1);
           x0 = Inversion(x0);
           return x3 & x1 & x0;
        }
    }
}