namespace Task_1;
public static class Program 
{
    public static void Main()
    {
        while(true)
        {

        }
    }

    public static Pupil EnterPupil() {
        Console.WriteLine("Choose type.");
        Console.WriteLine("1-Pupil.");
        Console.WriteLine("2-Exelent.");
        Console.WriteLine("3-Good.");
        Console.WriteLine("4-Bad.");
        Console.Write(">> "); int type = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a name: "); string name = Console.ReadLine();
        switch (type)
        {
            case 1:
                return new Pupil(name);

            default:
                return new Pupil(name);
        }
    }
}