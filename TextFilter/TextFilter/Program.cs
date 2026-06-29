using System.IO.Pipelines;
using System.Reflection;
using System.Reflection.Metadata;

public class Program
{
    static void Main(string[] args)
    {
        //System.Console.WriteLine("Hello World!");

        var path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "..\\..");

        string text = File.ReadAllText("Document.txt");

        Console.WriteLine(text);
    }
}

