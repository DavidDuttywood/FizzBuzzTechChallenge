using FizzBuzzTechChallenge.Resolvers;

namespace FizzBuzzTechChallengeTests
{
    public class FizzBuzzResolverTests
    {

        [Fact]
        public void FizzBuzzResolverTests_BaseResolverShouldStringifyInteger()
        {
            var _fizzBuzzResolver = new FizzBuzzBaseResolver();
            var result = _fizzBuzzResolver.Resolve(1);

            Assert.Equal("1", result);
        }
    }
}
