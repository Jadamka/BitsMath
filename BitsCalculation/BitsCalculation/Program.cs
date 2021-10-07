using System;
using System.Collections.Generic;

namespace BitsCalculation
{
    class Program
    {
        static void BitToDecimal()
        {
            Console.WriteLine("Add bits by typing 1 or 0 and type 2 to stop");
            List<int> bits = new List<int>();
            int bit;

            do
            {
                bit = Convert.ToInt32(Console.ReadLine());
                if(bit != 2)
                {
                    bits.Add(bit);
                }
;            } while (bit != 2);

            int x = 1, sum = 0;

            for(int i = bits.Count - 1; i >= 0; i--)
            {
                if(bits[i] == 1)
                {
                    bits[i] = x;
                }

                x *= 2;
                sum += bits[i];
            }

            Console.WriteLine("Decimal: " + sum);
        }

        static void DecimalToBit()
        {
            int dec;
            Console.Write("Type decimal number: ");
            dec = Convert.ToInt32(Console.ReadLine());

            List<int> bits = new List<int>();

            while(dec > 0)
            {
                if(dec % 2 == 0)
                {
                    bits.Add(0);
                }
                else
                {
                    bits.Add(1);
                }

                dec = dec / 2;
            }

            for(int i = bits.Count-1; i >= 0; i--)
            {
                Console.Write(bits[i] + " ");
            }

        }

        static void Main(string[] args)
        {
            int inp;
            Console.Write("Choose Bit to Decimal(1) or Decimal to Bit(2): ");
            inp = Convert.ToInt32(Console.ReadLine());

            switch (inp)
            {
                case 1:
                    BitToDecimal();
                    break;
                case 2:
                    DecimalToBit();
                    break;
            }
            
        }
    }
}
