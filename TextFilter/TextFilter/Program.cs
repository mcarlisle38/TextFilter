using System.IO.Pipelines;
using System.Reflection;
using System.Reflection.Metadata;
using TextFilter.DataAccess.Repositories;
using TextFilter.Service;
using TextFilter.Service.TextFilters.Filters;
using TextFilter.Service.WordFinders;

public class Program
{
    static void Main(string[] args)
    {
        string filename = "Document.txt";
        IRepository repository = new TextFileConsoleRepository(filename);
        IWordFinder wordFinder = new WordFinder();
        ITextFilter filter = new VowelInMiddleFilter(wordFinder);
        ITextFilterable textFilter = new TextFilterService(repository, filter);

        textFilter.PerformFilters();
    }
}

