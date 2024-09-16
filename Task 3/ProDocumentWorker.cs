namespace Task_3
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредагований");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у старому форматі, збереження в інших форматах доступне у версії Експерт");
        }
    }
}
