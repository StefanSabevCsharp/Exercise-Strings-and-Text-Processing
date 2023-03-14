using System;
using System.Text;
namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < sequence.Length; i++)
            {
                output.Append(sequence[i]);
                char current = sequence[i];
                while (i < sequence.Length - 1 && current == sequence[i + 1])
                {
                    i++;
                }

            }
            Console.WriteLine(output.ToString());
        }
    }
}
