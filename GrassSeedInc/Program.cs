using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrassSeedInc
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal output = 0;
            decimal c = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int l = int.Parse(Console.ReadLine());

            string[] inputs = new string[l];

            for (int i = 0; i < l; i++)
            {
                inputs[i] = Console.ReadLine();
            }

            foreach (var s in inputs)
            {
                string[] widthAndHeight = s.Split(' ');
                                
                output += (decimal.Parse(widthAndHeight[0], CultureInfo.InvariantCulture) * decimal.Parse(widthAndHeight[1], CultureInfo.InvariantCulture)) * c;
            }

            Console.WriteLine(output.ToString("0.0000000",CultureInfo.InvariantCulture));
        }
    }
}
