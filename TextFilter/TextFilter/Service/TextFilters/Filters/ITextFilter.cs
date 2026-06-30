using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilter.Service.TextFilters.Filters
{
    public interface ITextFilter
    {
        string Apply(string text);
    }
}
