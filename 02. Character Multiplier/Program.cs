using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string first = input[0];
            string second = input[1];

            int sum = CharacterMultiplier(first, second);
            Console.WriteLine(sum);
        }
        static int CharacterMultiplier(string first,string second)
        {
            int sum = 0;
            int lenght = Math.Min(first.Length, second.Length);
            for (int i = 0; i < lenght; i++)
            {
                sum += first[i] * second[i];
            }
            if (first.Length > lenght)
            {
                for (int i = lenght; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else if (second.Length > lenght)
            {
                for (int i = lenght; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }



            return sum;
        }
    }
}
