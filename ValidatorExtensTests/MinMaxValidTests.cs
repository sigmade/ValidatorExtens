using System;
using ValidatorExtens.Exceptions;
using ValidatorExtens.Extensions;
using ValidatorExtensTests.FakeData;
using Xunit;

namespace ValidatorExtensTests
{
    public class MinMaxValidTests
    {
        private readonly int Min = 18;
        private readonly int Max = 150;

        [Fact]
        public void Correct_Min_Max_Validation()
        {
            // Act
            var exceptionMin = Record.Exception(() => Min.MinMaxValid(Min, Max));
            var exceptionMax = Record.Exception(() => Max.MinMaxValid(Min, Max));

            // Assert
            Assert.Null(exceptionMin);
            Assert.Null(exceptionMax);
        }

        [Fact]
        public void Throw_Exception_When_Val_Less()
        {
            // Arrange
            var val = 16;
            var expectedException = new ValidateException(ExcMsg.MinValue, Min);

            // Act
            var thrownException = Assert.Throws<ValidateException>(() => val.MinMaxValid(Min, Max));

            // Assert
            Assert.Equal(expectedException.Message, thrownException.Message);
        }

        [Fact]
        public void Throw_Exception_When_Val_More()
        {
            // Arrange
            var val = 151;
            var expectedException = new ValidateException(ExcMsg.MaxValue, Max);

            // Act
            var thrownException = Assert.Throws<ValidateException>(() => val.MinMaxValid(Min, Max));

            // Assert
            Assert.Equal(expectedException.Message, thrownException.Message);
        }
    }
}
