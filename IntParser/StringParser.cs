using System;
using System.Linq;

namespace StringParser
{
    public static class StringParser
    {
        public static int ParseStringToInt(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Any(c => c < 48 || c > 57))
                throw new ArgumentException("Provided string is invalid, try to enter valid one", nameof(value));

            var result = 0;

            foreach (var character in value)
            {
                result = 10 * result + (character - 48);
            }

            return result;
        }
    }
}
