namespace FizzBuzzTechChallenge.Resolvers
{
    public class BaseResolver : IResolver
    {
        public int Priority => 4;

        public string Resolve(int val)
        {
            return val.ToString();
        }
    }
}