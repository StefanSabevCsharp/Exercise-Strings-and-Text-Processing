using System;

namespace Exercise_Strings_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < names.Length; i++)
            {
                if (isValidName(names[i]))
                {
                    Console.WriteLine(names[i]);
                }

            }
        }
        static bool isValidName(string name)
        {
            if (name.Length < 3 || name.Length > 16)
            {
                return false;
            }
            foreach (char c in name)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_' && c != '-')
                {
                    return false;
                    
                }
            }
            return true;
        }
    }
}
