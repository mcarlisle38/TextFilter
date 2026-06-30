using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace TextFilter.Service.WordFinders
{
    public class WordFinder : IWordFinder
    {
        /// <summary>
        /// Finds the next occurrence of a word in a text starting from a given index.
        /// </summary>
        /// <param name="word">Next word found.</param>
        /// <param name="index">Character position of delimiter from last word found.</param>
        /// <returns>Word found, first index position, last index psotion of word</returns>
        /// <exception cref="NotImplementedException"></exception>
        public (string word, int wordStart, int wordEnd) Next(string text, int index)
        {
            string word = string.Empty;
            int wordStart = 0;
            int wordEnd = 0;

            // 1. Skip non-letters to find the beginning of the next word
            while (index < text.Length && !char.IsLetter(text[index]))
            {
                index++;
            }

            wordStart = index;

            // 2. Consume letters until the word ends
            while (index < text.Length && char.IsLetter(text[index]))
            {
                wordEnd = index;
                index++;
            }

            // 3. Return the extracted word string if found
            if (wordEnd >= wordStart)
            {
                word = text.Substring(wordStart, wordEnd - wordStart + 1);
            }

            return (word, wordStart, wordEnd);

        }
    }
}
