namespace Task_1
{
    public class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        {
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil reading.");
            
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil writting");
            
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil relaxing.");
        }

        public override void Study()
        {
            Console.WriteLine("Good pupil studying.");
            
        }
    }
}