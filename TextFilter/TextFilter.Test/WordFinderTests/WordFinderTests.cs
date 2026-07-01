using System;
using System.Collections.Generic;
using System.Text;
using TextFilter.Service.WordFinders;

namespace TextFilter.Test.WordFinderTests
{
    internal class WordFinderTests
    {
        IWordFindable wordFinder;

        [SetUp]
        public void Setup()
        {
            this.wordFinder = new WordFinder();
        }

        [Test]
        [TestCase("This is a test string", 4, "is")]
        [TestCase("This is a test string", 7, "a")]
        [TestCase("This is a test string", 8, "a")]
        [TestCase("This is a test string", 9, "test")]
        [TestCase("This is a test string", 10, "test")]
        [TestCase("This is a test string", 12, "st")]
        [TestCase("This is a test string", 20, "g")]
        public void Next_WordsToFind_WordIdentifiedCorrectly(string testText, int index, string result)
        {
            //Arrange

            //Act
            (string word, int wordStart, int wordEnd) = wordFinder.Next(testText, index);

            //Assert
            Assert.That(word, Is.EqualTo(result));
        }

        [Test]
        [TestCase("123456 7890", 0, "")]
        [TestCase("123456 7890", 4, "")]
        [TestCase("12+=='@@456 78£$£%90", 0, "")]
        [TestCase("12+=='@@456 78£$£%90", 11, "")]
        public void Next_NoWordToFind_NoWordIdentified(string testText, int index, string result)
        {
            //Arrange

            //Act
            (string word, int wordStart, int wordEnd) = wordFinder.Next(testText, index);

            //Assert
            Assert.That(word, Is.EqualTo(result));
        }

        //TODO: Add tests for the Next method to check for the wordStart and wordEnd values returned.
    }
}
