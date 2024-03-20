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

        [Fact]
        public void FizzBuzzService_FactorsOf3ShouldReturnFizz()
        {
            var result = _fizzBuzzService.ResolveValue(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void FizzBuzzService_FactorsOf5ShouldReturnBuzz()
        {
            var result = _fizzBuzzService.ResolveValue(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FizzBuzzService_FactorsOf15ShouldReturnFizzBuzz()
        {
            var result = _fizzBuzzService.ResolveValue(15);
            Assert.Equal("FizzBuzz", result);
        }
    }
}