using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathOFFile = Console.ReadLine();
            int firstindex = pathOFFile.LastIndexOf("\\") + 1;
            int lastindex = pathOFFile.LastIndexOf(".");
            string fileName = pathOFFile.Substring(firstindex, lastindex - firstindex);
            string fileType = pathOFFile.Substring(lastindex + 1);
            Console.WriteLine("File name: {0}",fileName);
            Console.WriteLine("File extension: {0}",fileType);
        }
    }
}
