namespace Task_2
{
    public class Car : Vehicle
    {
        public string Brand { get; set; } = string.Empty;

        public Car(
            int x, 
            int y, 
            int price, 
            double speed, 
            int createdAtYear,
            string brand
            ) : base(x, y, price, speed, createdAtYear)
        {
            Brand = brand;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Brand: {0}.", Brand);
        }
    }
}
