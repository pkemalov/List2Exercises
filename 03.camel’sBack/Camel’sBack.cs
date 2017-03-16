using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.camel_sBack
{
    public class Program
    {
        public static void Main()
        {
            var initialStructure = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var camelSize = int.Parse(Console.ReadLine());
            var initialStructureSize = initialStructure.Count;
            var round = 0;

            while (!(initialStructure.Count==camelSize))
            {
                initialStructure.RemoveAt(0);
                initialStructure.RemoveAt(initialStructure.Count-1);
                round += 1;
            }

            if (round==0)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", initialStructure));
            }
            else
            {
                Console.WriteLine("{0} rounds", round);
                Console.WriteLine("remaining: {0}", string.Join(" ", initialStructure));
            }
        }
    }
}
