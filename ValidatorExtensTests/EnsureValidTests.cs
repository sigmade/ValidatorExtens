using ValidatorExtens.Exceptions;
using ValidatorExtens.Extensions;
using ValidatorExtensTests.FakeData;
using Xunit;

namespace ValidatorExtensTests
{
    public class EnsureValidTests
    {
        private readonly Person Person = new () { Id = 2, Name = "Tom"};

        [Fact]
        public void Success_Ensure_Valid_Class()
        {
            // Act
            var exception = Record.Exception(() => Person.EnsureValid(p => p.Id > 0 && p.Name != "admin"));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void Throw_Exception_When_Class_Null()
        {
            // Arrange
            var person = Person;
            person = null;

            // Act Assert
            Assert.Throws<ValidateException>(() => person.EnsureValid(p => p.Id > 0 && p.Name != "admin"));
        }

        [Fact]
        public void Success_Ensure_Valid_Num()
        {
            // Arrange
            var num = Person.Id;

            // Act
            var exception = Record.Exception(() => num.EnsureValid(p => p > 1));

            // Assert
            Assert.Null(exception);
        }
    }
}
