using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("12345");
            Console.WriteLine();
            
            Console.ReadKey();
        }

        static void DigitalRoot(string rootThis)
        {
           
            //final number needed
            int final = 0;

            Console.WriteLine("Original String : " + rootThis);

            //converting rootThis to a number
            int input = int.Parse(rootThis);

            while (rootThis.Length > 1)
            {
                //total for the string
                int total = 0;

                foreach (char num in rootThis)
                {
                    //converting each char into a string
                    string numString = num.ToString();
                    //converting that string to a number
                    int trueNum = int.Parse(numString);
                    //adding that number to the total
                    total += trueNum;
                    //equating that total to the int input
                    input = total;
                    //final int = input
                    final = input;
                    //converting that input back to a string
                    rootThis = input.ToString();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Digital Root: " + final);
        }
    }
}
