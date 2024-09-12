namespace Task_1
{
    public class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        {
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil reading.");
            
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil writting");
            
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil relaxing.");
        }

        public override void Study()
        {
            Console.WriteLine("Bad pupil studying.");
            
        }
    }
}