using FizzBuzzTechChallenge.Resolvers;
using System.Reflection;

namespace FizzBuzzTechChallenge
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public IEnumerable<IResolver> resolvers;

        public FizzBuzzService() {
            Type resolverType = typeof(IResolver);

            Assembly assembly = Assembly.GetExecutingAssembly();
            resolvers = assembly.GetTypes()
                .Where(t => resolverType.IsAssignableFrom(t) && t.IsClass)
                .Select(x => Activator.CreateInstance(x)).Cast<IResolver>()
                .OrderBy(x => x.Priority); // this feels wrong
        }

        public string ResolveValue(int i)
        {
            var resolver = resolvers.First(x => x.Resolve(i) != null);
            return resolver.Resolve(i);
        }
    }
}