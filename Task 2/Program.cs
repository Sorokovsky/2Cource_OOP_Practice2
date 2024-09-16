namespace Task_2;
public static class Program
{
    public static void Main()
    {
        while(true)
        {
            int operation = ChooseOperation();
            switch(operation)
            {
                case 0:
                    {
                        return;
                    }
                case 1:
                    {
                        Vehicle vehicle = EnterVehicle();
                        vehicle.Show();
                        break;
                    }
                case 2:
                    {
                        Vehicle vehicle = EnterPlane();
                        vehicle.Show();
                        break;
                    }
                case 3:
                    {
                        Vehicle vehicle = EnterCar();
                        vehicle.Show();
                        break;
                    }
                case 4:
                    {
                        Vehicle vehicle = EnterShip();
                        vehicle.Show();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unknown operation. Try again.");
                        break;
                    }
            }
        }
    }

    public static Vehicle EnterVehicle()
    {
        Console.Write("Enter a X: "); int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a Y: "); int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a price in uah: "); int price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a speed in km/h: "); double speed = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a created at year: "); int createdAtYear = Convert.ToInt32(Console.ReadLine());
        return new Vehicle(x, y, price, speed, createdAtYear);
    }

    public static Plane EnterPlane()
    {
        Vehicle vehicle = EnterVehicle();
        Console.Write("Enter a count of passengers: "); int passengersCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a height in km: "); double height = Convert.ToDouble(Console.ReadLine());
        return new Plane(vehicle.X, vehicle.Y, vehicle.Price, vehicle.Speed, vehicle.CreatedAtYear, passengersCount, height);
    }

    public static Car EnterCar()
    {
        Vehicle vehicle = EnterVehicle();
        Console.Write("Enter a brand: "); string brand = Console.ReadLine();
        return new Car(vehicle.X, vehicle.Y, vehicle.Price, vehicle.Speed, vehicle.CreatedAtYear, brand);
    }

    public static Ship EnterShip()
    {
        Vehicle vehicle = EnterVehicle();
        Console.Write("Enter a count of passengers: "); int passengersCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a port of call: "); string callPort = Console.ReadLine();
        return new Ship(vehicle.X, vehicle.Y, vehicle.Price, vehicle.Speed, vehicle.CreatedAtYear, passengersCount, callPort);
    }

    public static int ChooseOperation()
    {
        Console.WriteLine("Choose operation.");
        Console.WriteLine("0-Exit.");
        Console.WriteLine("1-Enter vehicle.");
        Console.WriteLine("2-Enter plane.");
        Console.WriteLine("3-Enter car.");
        Console.WriteLine("4-Enter ship.");
        Console.WriteLine(">>> "); int operation = Convert.ToInt32(Console.ReadLine());
        return operation;
    }
}