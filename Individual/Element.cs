namespace Individual
{
    public class Element
    {
        public int InCount { get; set; } = 4;

        public int OutCount { get; set; } = 1;

        public string Name = "Element";

        public int Inversion(int x)
        {
            return x == 1 ? 0 : 1;
        }
    }
}
