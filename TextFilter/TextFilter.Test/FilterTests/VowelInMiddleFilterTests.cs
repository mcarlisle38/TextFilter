using System;
using System.Collections.Generic;
using System.Text;
using TextFilter.Service.WordFinders;
using TextFilter.Service.TextFilters.Filters;
using Moq;

namespace TextFilter.Tests.FilterTests
{
    internal class VowelInMiddleFilterTests
    {
        IFilterable filter;
        Mock<IWordFindable> wordFinder;

        [SetUp]
        public void Setup()
        {
            wordFinder = new Mock<IWordFindable>();
            this.filter = new VowelInMiddleFilter(wordFinder.Object);
        }

        [Test]
        [TestCase("word", 0, "")]
        public void Apply_WordWithVowelInMiddle_WordRemovedFromText(string testText, int index, string result)
        {
            //Arrange
            wordFinder.Setup(finder => finder.Next(testText, index))
                .Returns((testText, 0, 3));

            //Act
            string text = filter.Apply(testText);

            //Assert
            Assert.That(text, Is.EqualTo(result));
        }
    }
}
