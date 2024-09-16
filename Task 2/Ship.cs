namespace Task_2
{
    public class Ship : Vehicle
    {
        private int _passengersCount;

        public string CallPort { get; set; } = string.Empty;
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

        public Ship(
            int x, 
            int y, 
            int price, 
            double speed, 
            int createdAtYear,
            int passengersCount,
            string callPort
            ) : base(x, y, price, speed, createdAtYear)
        {
            PassengersCount = passengersCount;
            CallPort = callPort;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Port of call: {0}.", CallPort);
            Console.WriteLine("Count of passengers: {0}.", PassengersCount);
        }
    }
}
