namespace FizzBuzzTechChallenge
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string ResolveValue(int i)
        {
            if (i % 15 == 0)
            {
                return("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return i.ToString();
            }
        }
    }
}