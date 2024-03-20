namespace FizzBuzzTechChallenge.Resolvers
{
    public class FizzbuzzResolver : IResolver
    {
        public string Resolve(int val)
        {
            return val % 15 == 0 ? "Fizzbuzz" : null;
        }
    }
}
