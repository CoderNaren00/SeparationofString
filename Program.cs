using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparationofString
{
    internal class Program
    {
        //Separating each character from string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be printed :");
            string name = Console.ReadLine();

            for(int i=0; i<name.Length; i++)
            {
                Console.Write(name[i]+ " "+i);
            }
            Console.ReadKey();
        }
    }
}
