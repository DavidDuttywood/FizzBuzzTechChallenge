namespace FizzBuzzTechChallenge.Resolvers

{
    public class BuzzResolver : IResolver
    {
        public string Resolve(int val)
        {
            return val % 5 == 0 ? "Buzz" : null;
        }
    }
}
