//Variant 11

namespace Individual;
public static class Program
{
    public static void Main()
    {
        FinalOr finalOr = new FinalOr();
        Console.WriteLine("| x0 | x1 | x2 | x3 | y |");
        for(int b = 0; b < 16; b++)
        {
            int x0 = 0, x1 = 0, x2 = 0, x3 = 0;
            for (int k = 0; k <= 3; k++)
            {
                int c = b & 1 << k;
                switch(k)
                {
                    case 0:
                        {
                            if (c == 0)
                            {
                                x0 = 1;
                            }
                            else
                            {
                                x0 = 0;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (c == 0)
                            {
                                x1 = 1;
                            }
                            else
                            {
                                x1 = 0;
                            }
                            break;
                        }
                    case 2:
                        {
                            if(c == 0)
                            {
                                x2 = 1;
                            }
                            else
                            {
                                x2 = 0;
                            }
                            break;
                        }
                    case 3:
                        if(c == 0)
                        {
                            x3 = 1;
                        }
                        else
                        {
                            x3 = 0;
                        }
                        break;
                }
                DisplayRow(x0, x1, x2, x3, finalOr.Result(x0, x1, x2, x3));
            }
        }
        //(int x0, int x1, int x2, int x3) = Generate();
    }
    
    public static (int x0, int x1, int x2, int x3) Generate()
    {
        return (0, 1, 0, 1);
    }

    public static void DisplayRow(int x0, int x1, int x2, int x3, int y)
    {
        Console.WriteLine($"| {x0}  | {x1}  | {x2}  | {x3}  | {y} |");
    }
}