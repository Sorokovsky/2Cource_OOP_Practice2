namespace Task_3;
public static class Program
{
    public static void Main()
    {
        Console.Write("Enter a license key: "); string key = Console.ReadLine();
        DocumentWorker document = key switch
        {
            "pro" => new ProDocumentWorker(),
            "exp" => new ExpertDocumentWorker(),
            _ => new DocumentWorker(),
        };
        document.OpenDocument();
        document.EditDocument();
        document.SaveDocument();
    }
}