//Variant 11

namespace Individual;
public static class Program
{
    public static void Main()
    {
        int inCount = 4;
        int[] inputs = new int[inCount];
        Combination combination = new Combination("11", inCount);
        Console.WriteLine("Enter a inputs data");
        for(int i = 0; i < inCount; i++)
        {
            Console.Write($"x{i}: "); inputs[i] = Convert.ToInt32(Console.ReadLine());
        }
        combination.SetInputs(inputs);
        combination.Show();
    }
}