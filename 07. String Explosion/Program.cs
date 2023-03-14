using System;
using System.Text;
namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            int explosionStrenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '>')
                {
                    output.Append(">");
                    
                    int explosionNumber = int.Parse(input[i + 1].ToString());
                    explosionStrenght += explosionNumber;
                }
                else if (explosionStrenght > 0)
                {
                    explosionStrenght--;
                }
                else
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}
