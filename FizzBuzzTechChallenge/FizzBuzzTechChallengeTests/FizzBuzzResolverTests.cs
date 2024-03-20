using FizzBuzzTechChallenge.Resolvers;

namespace FizzBuzzTechChallengeTests
{
    public class FizzBuzzResolverTests
    {

        [Fact]
        public void FizzBuzzResolverTests_BaseResolverShouldStringifyInteger()
        {
            var _fizzBuzzResolver = new BaseResolver();
            var result = _fizzBuzzResolver.Resolve(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void FizzBuzzResolverTests_FizzResolver_FactorOf3ShouldReturnFizz()
        {
            var _fizzBuzzResolver = new FizzResolver();
            var result = _fizzBuzzResolver.Resolve(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void FizzBuzzResolverTests_FizzResolver_NonFactorOf3ShouldReturnNull()
        {
            var _fizzBuzzResolver = new FizzResolver();
            var result = _fizzBuzzResolver.Resolve(4);

            Assert.Null(result);
        }

        [Fact]
        public void FizzBuzzResolverTests_BuzzResolver_FactorOf5ShouldReturnBuzz()
        {
            var _fizzBuzzResolver = new BuzzResolver();
            var result = _fizzBuzzResolver.Resolve(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FizzBuzzResolverTests_BuzzResolver_NonFactorOf5ShouldReturnNull()
        {
            var _fizzBuzzResolver = new BuzzResolver();
            var result = _fizzBuzzResolver.Resolve(6);

            Assert.Null(result);
        }

        [Fact]
        public void FizzBuzzResolverTests_FizzBuzzResolver_FactorOf15ShouldReturnFizz()
        {
            var _fizzBuzzResolver = new FizzbuzzResolver();
            var result = _fizzBuzzResolver.Resolve(15);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void FizzBuzzResolverTests_FizzBuzzResolver_NonFactorOf15ShouldReturnNull()
        {
            var _fizzBuzzResolver = new FizzbuzzResolver();
            var result = _fizzBuzzResolver.Resolve(4);

            Assert.Null(result);
        }
    }
}
