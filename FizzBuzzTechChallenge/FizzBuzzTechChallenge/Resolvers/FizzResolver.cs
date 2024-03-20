namespace FizzBuzzTechChallenge.Resolvers

{
    public class FizzResolver : IResolver
    {
        public string Resolve(int val)
        {
            return val % 3 == 0 ? "Fizz" : null;
        }
    }
}
