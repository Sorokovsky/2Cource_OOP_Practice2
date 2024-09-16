namespace Task_3
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {

            Console.WriteLine("Документ відкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документу доступне у версії Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документу доступне у версії Про");
        }
    }
}
