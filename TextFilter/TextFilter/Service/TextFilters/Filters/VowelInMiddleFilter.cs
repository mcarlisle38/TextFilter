using System;
using System.Collections.Generic;
using System.Text;
using TextFilter.Service.WordFinders;

namespace TextFilter.Service.TextFilters.Filters
{
    internal class VowelInMiddleFilter : ITextFilter
    {
        public VowelInMiddleFilter(IWordFinder wordFinder)
        {

        }
        public string Apply(string text)
        {
            throw new NotImplementedException();
        }
    }
}
