//Variant 11(3)
namespace Extra;
public static class Program
{
    public static void Main()
    {
        Console.Write("Enter a 1 number: "); string first = Console.ReadLine();
        Console.Write("Enter a 2 number: "); string second = Console.ReadLine();
        DecimalString one = new DecimalString(first);
        DecimalString two = new DecimalString(second);
        Console.WriteLine("{0}-{1}={2}.", one.GetString(), two.GetString(), one.Subtract(two));
        Console.WriteLine("{0}>{1}={2}.", one.GetString(), two.GetString(), one.isMore(two));
        Console.WriteLine("{0}<{1}={2}.", one.GetString(), two.GetString(), one.isLess(two));
    }
}