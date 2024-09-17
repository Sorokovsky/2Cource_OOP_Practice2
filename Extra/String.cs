namespace Extra
{
    public class String
    {
        protected char[] _characters;

        public String()
        {
            _characters = string.Empty.ToCharArray();
        }

        public String(string literal)
        {
            _characters = literal.ToCharArray();
        }

        public String(char symbol)
        {
            _characters = new char[] { symbol };
        }

        public int GetLength()
        {
            return _characters.Length;
        }

        public void Clear()
        {
            _characters = string.Empty.ToCharArray();
        }
    }
}
