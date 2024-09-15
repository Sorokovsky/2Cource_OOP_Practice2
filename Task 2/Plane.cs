namespace Task_2
{
    public class Plane : Vehicle
    {
        private int _passengersCount;
        private double _height;

        public int PassengersCount
        {
            get
            {
                return _passengersCount;
            }
            set
            {
                if(value < 0)
                {
                    _passengersCount = 0;
                }
                else
                {
                    _passengersCount = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    _height = 0;
                }
                else
                {
                    _height = value;
                }
            }
        }

        public Plane(
            int x, 
            int y, 
            int price, 
            double speed, 
            int createdAtYear,
            int passengersCount,
            double height) : base(x, y, price, speed, createdAtYear)
        {
            PassengersCount = passengersCount;
            Height = height;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Count of passengers: {0}.", PassengersCount);
            Console.WriteLine("Height: {0}km.", Height);
        }
    }
}
