namespace Task_2
{
    public class Vehicle
    {
        private int _price;
        private double _speed;
        private int _createdAtYear;

        public int X { get; set; }
        public int Y { get; set; }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }
        public double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value < 0)
                {
                    _speed = 0;
                }
                else
                {
                    _speed = value;
                }
            }
        }
        public int CreatedAtYear
        {
            get
            {
                return _createdAtYear;
            }
            set
            {
                if(value < 0)
                {
                    _createdAtYear = 0;
                }
                else
                {
                    _createdAtYear = value;
                }
            }
        }

        public Vehicle(int x, int y, int price, double speed, int createdAtYear)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            CreatedAtYear = createdAtYear;
        }

        public virtual void Show()
        {
            Console.WriteLine("Cords: X: {0}, Y: {1}.", X, Y);
            Console.WriteLine("Price: {0}uah.", Price);
            Console.WriteLine("Speed: {0}km/h.", Speed);
            Console.WriteLine("Created at year: {0}.", CreatedAtYear);
        }
    }
}
