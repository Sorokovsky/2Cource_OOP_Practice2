namespace Task_1
{
    public class ExelentPupil : Pupil
    {
        public ExelentPupil(string name) : base(name)
        {
        }

        public override void Read()
        {
            Console.WriteLine("Exelent pupil reading.");
            
        }

        public override void Write()
        {
            Console.WriteLine("Exelent pupil writting");
            
        }

        public override void Relax()
        {
            Console.WriteLine("Exelent pupil relaxing.");
        }

        public override void Study()
        {
            Console.WriteLine("Exelent pupil studying.");
            
        }
    }
}