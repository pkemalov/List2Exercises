using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.integerInsertion
{
    public class IntegerInsertion
    {
        public static void Main()
        {
            var initialString = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var entry = Console.ReadLine();
            

            while (entry != "end")
            {
                int num = int.Parse(entry);
                int firstDigit = FirstDigit(num);
                initialString.Insert(firstDigit, num);

                entry = Console.ReadLine();
            }
            

            Console.WriteLine(string.Join(" ", initialString));
        }

        private static int FirstDigit(int num)
        {
            int firstDigit = num;
            while (firstDigit>9)
            {
                firstDigit = firstDigit / 10;
            }
            return firstDigit;
        }
    }
}
