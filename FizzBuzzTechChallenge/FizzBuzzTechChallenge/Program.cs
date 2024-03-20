using FizzBuzzTechChallenge;
var fizzBuzzService = new FizzBuzzService();

for (var i = 1; i <= 100; i++)
{
    Console.WriteLine(fizzBuzzService.ResolveValue(i));
}