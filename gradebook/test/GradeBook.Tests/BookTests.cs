using System.Reflection;
using System;
using Xunit;
using Xunit.Abstractions;

namespace GradeBook.Tests
{
    public class BookTests
    {
        private readonly ITestOutputHelper output;

        public BookTests(ITestOutputHelper output)
        {
            this.output = output;
        }
                
        [Fact]
        public void BookCalculateAnAverageGrade()
        {
            // arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();
            output.WriteLine($"Average: {result.Average}");
            output.WriteLine($"High: {result.High}");
            output.WriteLine($"Low: {result.Low}");
            output.WriteLine($"Garde: {result.Letter}");

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);

        }
    }
}
