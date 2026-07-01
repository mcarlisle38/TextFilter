using System;
using System.Collections.Generic;
using System.Text;
using TextFilter.Service.WordFinders;

namespace TextFilter.Service.TextFilters.Filters
{
    public class VowelInMiddleFilter : IFilterable
    {
        private IWordFindable wordFinder;
        public VowelInMiddleFilter(IWordFindable wordFinder)
        {
            this.wordFinder = wordFinder;
        }
        public string Apply(string text)
        {
            int index = 0;
            while(index < text.Length)
            {
                (string word, int wordStart, int wordEnd) = wordFinder.Next(text, index);

                if (HasVowelInMiddle(word))
                {
                    text = text.Remove(wordStart, wordEnd - wordStart + 1);
                }
                else if(String.IsNullOrEmpty(word))
                {
                    index = wordStart + 1;
                }
                else
                {
                    index = wordEnd + 1;
                }
            }

            return text;
        }

        /// <summary>
        /// Check if word has vowel in the middle chacter(s).
        /// If word is even number of characters, check the two middle characters.
        /// </summary>
        /// <param name="word">Word to check for vowel.</param>
        /// <returns>True/False if has vowel.</returns>
        private bool HasVowelInMiddle(string word)
        {
            if (string.IsNullOrWhiteSpace(word) || word.Length < 3)
            {
                return false;
            }
                
            var vowels = "aeiou";
            int len = word.Length;
            if (len % 2 == 1)
            {
                // Odd length, single middle char
                char mid = word[len / 2];
                return vowels.Contains(Char.ToLower(mid));
            }
            else
            {
                // Even length, two middle chars
                string mid = word.Substring(len / 2 - 1, 2);
                return mid.Any(c => vowels.Contains(Char.ToLower(c)));
            }
        }
    }
}
