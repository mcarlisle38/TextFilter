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
        IWordFindable wordFinder = new WordFinder();
        TextFilter.Service.TextFilters.Filters.IFilterable filter = new VowelInMiddleFilter(wordFinder);
        TextFilter.Service.ITextFilterable textFilter = new TextFilterService(repository, filter);

        textFilter.PerformFilters();
    }
}

