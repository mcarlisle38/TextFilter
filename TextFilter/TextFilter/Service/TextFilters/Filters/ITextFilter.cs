using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilter.Service.TextFilters.Filters
{
    internal interface ITextFilter
    {
        string Apply(string text);
    }
}
