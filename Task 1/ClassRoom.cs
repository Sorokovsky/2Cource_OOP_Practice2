namespace Task_1
{
    public class ClassRoom
    {
        private LinkedList<Pupil> _pupils = new();

        public ClassRoom(Pupil first = null, Pupil second = null, Pupil third = null, Pupil forth = null)
        {
            if(first != null) {
                _pupils.AddLast(first);
            }
            if(second != null) {
                _pupils.AddLast(second);
            }
            if(third != null) {
                _pupils.AddLast(third);
            }
            if(forth != null) {
                _pupils.AddLast(forth);
            }
        }

        public void Show()
        {
            for(int i = 0; i < _pupils.Count; i++)
            {
                Pupil pupil = _pupils.ElementAt(i);
                Console.WriteLine("#{0}.", i + 1);
                Console.WriteLine("Name: {0}.", pupil.Name);                
                pupil.Relax();
                pupil.Study();
                pupil.Write();
                pupil.Read();
            }
        }    
    }
}