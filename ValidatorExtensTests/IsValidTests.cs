using ValidatorExtensTests.FakeData;
using ValidatorExtens.Extensions;
using Xunit;

namespace ValidatorExtensTests
{
    public class IsValidTests
    {
        private readonly Person Person = new() { Id = 2, Name = "Tom" };

        [Fact]
        public void Correct_IsValid()
        {
            var res = Person.Id.IsValid(p => p > 0);

            Assert.True(res);
        }
    }
}
