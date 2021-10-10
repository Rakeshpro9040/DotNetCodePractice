using System.Reflection;
using System;
using Xunit;
using Xunit.Abstractions;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    
    public class TypeTests
    {
        private readonly ITestOutputHelper output;

        public TypeTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        // Delegate Type - Example  
        int count;
        [Fact] 
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage; // ReturnMessage will be invoked twice
            log += IncrementCount; // IncrementCount will be invoked once

            // This is same as new WriteLogDelegate(ReturnMessage)
            var result = log("Hello!");
            // Assert.Equal("Hello!", result);
            Assert.Equal(3, count);
        }

        private string IncrementCount(string message)
        {
            count++;
            return message.ToLower();

        }

        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        // String - As Reference Type
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUppercase(name);
            output.WriteLine($"name= {name}");
            output.WriteLine($"upper= {upper}");

            // name.ToUpper();
            // output.WriteLine($"name= {name}");

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            output.WriteLine($"parameter.ToUpper= {parameter.ToUpper()}");
            return parameter.ToUpper();
        }

        // Value Type - Pass Parameter as Value
        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            output.WriteLine($"x= {x}");
            SetInt(ref x);
            output.WriteLine($"x= {x}");

            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
            output.WriteLine($"z= {z}");
        }

        private int GetInt()
        {
            return 3;
        }

        // Pass Parameter as Reference
        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            output.WriteLine($"Book Name: {book1.Name}");
            GetBookSetName(out book1, "New Name");
            output.WriteLine($"Book Name: {book1.Name}");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(out InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
            output.WriteLine($"Book Name - Local: {book.Name}");
        }

        // Reference Type - Pass Parameter as Value
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            output.WriteLine($"Book Name: {book1.Name}");
            GetBookSetName(book1, "New Name");
            output.WriteLine($"Book Name: {book1.Name}");

            Assert.NotEqual("New Name", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
            output.WriteLine($"Book Name - Local: {book.Name}");
        }

        // Reference Type - Pass Parameter as Value
        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            output.WriteLine($"Book Name: {book1.Name}");
            SetName(book1, "New Name");
            output.WriteLine($"Book Name: {book1.Name}");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
            output.WriteLine($"Book Name - Local: {book.Name}");
        }        

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        InMemoryBook GetBook(string name) // Instead of void we want to return Book object
        {
            return new InMemoryBook(name);
        }
    }
}
