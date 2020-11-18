using System;

namespace FizzBuzz
{
    public class Dependency
    {
        public virtual string Say(int count)
        {
            if (count % 3 == 0)
            {
                return "Fizz";
            }

            return "1";
        }
    }
}
