namespace FizzBuzzTechChallenge.Resolvers
{
    public class FizzbuzzResolver : IResolver
    {
        public int Priority => 1;

        public string Resolve(int val)
        {
            return val % 15 == 0 ? "FizzBuzz" : null;
        }
    }
}
