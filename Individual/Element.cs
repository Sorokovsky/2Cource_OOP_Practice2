namespace Individual
{
    public class Element
    {
        private string _name;
        private int _inCount;
        private int _outCount;

        public string Name { get { return _name; } }
        public int InCount
        {
            get
            {
                return _inCount;
            }
            set
            {
                if(value < 0)
                {
                    _inCount = 0;
                }
                else
                {
                    _inCount = value;
                }
            }
        }
        public int OutCount
        {
            get
            {
                return _outCount;
            }
            set
            {
                if(value < 0)
                {
                    _outCount = 0;
                }
                else
                {
                    _outCount = value;
                }
            }
        }


        public Element()
        {
            _name = string.Empty;
            InCount = 1;
            OutCount = 1;
        }

        public Element(string name) : this()
        {
            _name = name;
        }

        public Element(string name, int inCount, int outCount)
        {
            _name = name;
            InCount = inCount;
            OutCount = outCount;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: {0}.", Name);
            Console.WriteLine("Count of inners: {0}.", InCount);
            Console.WriteLine("Count of outers: {0}.", OutCount);
        }
    }
}
