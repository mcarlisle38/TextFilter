using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilter.Service.WordFinders
{
    public interface IWordFindable
    {
        (string word, int wordStart, int wordEnd) Next(string text, int index);
    }
}
