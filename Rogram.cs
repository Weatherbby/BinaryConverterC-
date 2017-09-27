using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a decimal number: ");
                string dec = Console.ReadLine();
                Console.WriteLine(toBinaryValue(dec));
                if (dec == "exit")
                {
                    break;
                }
                Console.WriteLine(toDecimalValue(toBinaryValue(dec)));

            }
        }
        static int toDecimalValue(string binary)
        {
            var dec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
            }
            return dec;
        }
        static string toBinaryValue(string dec)
        {
            int num = Convert.ToInt32(dec);
            string binary = Convert.ToString(num, 2);
            return binary;
        }
    }
}
