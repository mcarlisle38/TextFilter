using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilter.Service.WordFinders
{
    public interface IWordFinder
    {
        (string word, int wordStart, int wordEnd) Next(string text, int index);
    }
}
