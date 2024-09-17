namespace Extra
{
    public class DecimalString : String
    {
        public DecimalString(string literal) : base(literal)
        {
            Exception exception = new ArgumentException("Must be a digit with + or -");
            for (int i = 0; i < GetLength(); i++)
            { 
                var item = literal.ElementAt(i);
                if ((item == '+' || item == '-') && i != 0)
                {
                    throw exception;
                }
                if(item != '+' && item != '-' && !Char.IsNumber(item))
                {
                    throw exception;
                }
            }
        }

        public int GetNumber()
        {
            int result = 0;
            bool isNegative = false;
            foreach (var item in _characters)
            {
                if (item == '-')
                {
                    isNegative = true;
                }
                else
                {
                    int number = item - '0';
                    result = result * 10 + number;
                }
            }
            if (isNegative)
            {
                result *= -1;
            }
            return result;
        }

        public int Subtract(DecimalString other)
        {
            int first = GetNumber();
            int second = other.GetNumber();
            return first - second;
        }

        public bool isMore(DecimalString other)
        {
            int first = GetNumber();
            int second = other.GetNumber();
            return first > second;
        }

        public bool isLess(DecimalString other)
        {
            int first = GetNumber();
            int second = other.GetNumber();
            return first < second;
        }

        public void Show()
        {
            Console.WriteLine("{0}", _characters);
        }

        public string GetString()
        {
            return string.Join("", _characters);
        }
    }
}
