using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 100;
            var fractions = new List<SimpleFraction>(count);
            var random = new Random();
            for (var i = 0; i < count; i++)
                fractions.Add(new SimpleFraction(random.Next(-100, 100), random.Next(1, 100)));
            foreach (var fraction in fractions.Where(fract => fract.Denominator == 1).Select(fract => fract.Numerator).ToArray())
                Console.WriteLine("{0:d3}", fraction);
        }
    }
}
