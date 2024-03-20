namespace FizzBuzzTechChallenge.Resolvers
{
    public interface IResolver
    {
        int Priority { get; }
        string Resolve(int val);
    }
}