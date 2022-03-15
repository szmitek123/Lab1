using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Generator
    {
        public List<int> numbers;

        public Generator(int n, int seed)
        {
            numbers = new List<int>();
            Random random = new Random(seed);

            for (int i = 0; i < n; i++)
                numbers.Add(random.Next(30));
        }

        public override string ToString()
        {
            string str = string.Join(" ", numbers.ToArray());
            return str;
        }
    }
}
