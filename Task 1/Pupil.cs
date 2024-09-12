namespace Task_1
{
    public class Pupil
    {
        public string Name { get; init; } = string.Empty;

        public Pupil(string name)
        {
            Name = name;           
        }

        public virtual void Study()
        {
            Console.WriteLine("Pupil studying.");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil writing.");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil reading.");
            
        }

        public virtual void Relax() 
        {
            Console.WriteLine("Pupil relaxing.");
            
        }
    }
}