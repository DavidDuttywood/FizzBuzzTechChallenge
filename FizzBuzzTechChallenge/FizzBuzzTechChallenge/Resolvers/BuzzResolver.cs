﻿namespace FizzBuzzTechChallenge.Resolvers

{
    public class BuzzResolver : IResolver
    {
        public int Priority => 2;

        public string Resolve(int val)
        {
            return val % 5 == 0 ? "Buzz" : null;
        }
    }
}
