using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesList2
{
    public class DistinctList
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Distinct()
                .ToList();

            
            Console.WriteLine(string.Join(" ", firstList));
        }
    }
}
