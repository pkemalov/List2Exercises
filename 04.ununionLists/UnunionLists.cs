using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ununionLists
{
    public class UnunionLists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var nextList = new List<int>();

            var num = int.Parse(Console.ReadLine());

            while (num>0)
            {
                nextList = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                //da направя с foearch в Nextlist и да проверя дали първия list contain която и да е от цифрите, съотвтно да добавям и трия
                foreach (var number in nextList)
                {
                    if (primalList.Contains(number))
                    {
                        primalList.Remove(number);
                        if (primalList.Contains(number))
                        {
                            primalList.Remove(number);
                        }
                    }
                    else
                    {
                        primalList.Add(number);
                    }
                }
                num--;

            }
            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
