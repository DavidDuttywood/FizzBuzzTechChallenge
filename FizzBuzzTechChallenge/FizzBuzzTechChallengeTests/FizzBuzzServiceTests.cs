using FizzBuzzTechChallenge;

namespace FizzBuzzTechChallengeTests
{
    public class FizzBuzzServiceTests
    {
        public readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void FizzBuzzService_NonFizzBuzzableNumbersShouldReturnAsString()
        {
            var result = _fizzBuzzService.ResolveValue(1);
            Assert.Equal("1", result);
        }
    }
}