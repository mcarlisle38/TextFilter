using System.IO.Pipelines;
using System.Reflection;
using System.Reflection.Metadata;
using TextFilter.DataAccess;
using TextFilter.DataAccess.Repositories;

public class Program
{
    static void Main(string[] args)
    {
        IRepository repository = new TextFileConsoleRepository("Document.txt");
        string text = repository.Read();
        repository.Update(text);
    }
}

