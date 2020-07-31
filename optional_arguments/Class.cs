using Microsoft.SqlServer.Server;
using System;

namespace optional_arguments
{
    internal class Class
    {
        public void Display(string input, int start = 0, int stop = -1)
        {
            if (stop < 0) { stop = input.Length; }
            if(start>stop|| start < 0 || stop > input.Length) { return; }
            for(int i = start; i < stop; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}