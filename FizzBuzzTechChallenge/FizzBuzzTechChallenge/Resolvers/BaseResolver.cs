namespace FizzBuzzTechChallenge.Resolvers
{
    public class BaseResolver : IResolver
    {
        public string Resolve(int val)
        {
            return val.ToString();
        }
    }
}