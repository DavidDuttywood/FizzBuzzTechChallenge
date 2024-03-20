namespace FizzBuzzTechChallenge.Resolvers

{
    public class FizzResolver : IResolver
    {
        public int Priority => 3;

        public string Resolve(int val)
        {
            return val % 3 == 0 ? "Fizz" : null;
        }
    }
}
