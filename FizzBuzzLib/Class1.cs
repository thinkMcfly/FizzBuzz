using System;
using System.Collections.Generic;
using System.IO;

namespace FizzBuzzLib
{
    public class Solution
    {
        private Dictionary<int, string> _mappings;

        public Solution()
        {
            // create the default mappings dictionary
            _mappings = new Dictionary<int, string>();
            _mappings.Add(3, "Fizz");
            _mappings.Add(5, "Buzz");
        }

        public Solution(Dictionary<int, string> mappings)
        {
            _mappings = mappings;
        }

        public IEnumerable<MemoryStream> PrintFizzBuzz(int upperBound)
        {
            if (upperBound < 1)
            {
                Console.WriteLine("The upper bound must be greater than 0.");
                yield break;
            }

            if (_mappings == null || _mappings.Count == 0)
            {
                Console.WriteLine("The mappings collection is empty.");
                yield break;
            }
            else
            {
                var ms = new MemoryStream();
                using (StreamWriter sw = new StreamWriter(ms))
                {
                    for (int index = 1; index <= upperBound; index++)
                    {
                        sw.WriteLine(FizzBuzz(index));
                        sw.Flush();
                        ms.Position = 0;
                        yield return ms;
                        ms.SetLength(0);
                    }
                }
            }
        }

        public string FizzBuzz(int number)
        {
            var output = "";

            foreach (var item in _mappings)
            {
                if (number % item.Key == 0)
                {
                    output += item.Value;
                }
            }

            return string.IsNullOrEmpty(output) ? number.ToString() : output;
        }
    }
}
