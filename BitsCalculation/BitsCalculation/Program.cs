using System;
using System.Collections.Generic;

namespace BitsCalculation
{
    class Program
    {
        static void BitToDecimal()
        {
            Console.Write("Choose size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] bits = new int[size];
            int bit;

            for(int i = 0; i < bits.Length; i++)
            {
                do
                {
                    Console.WriteLine();
                    Console.Write("Put bit 0/1: ");
                    bit = Convert.ToInt32(Console.ReadLine());

                    if(bit is (<0) || bit is (> 1))
                    {
                        Console.WriteLine("Wrong number! Try again");
                    }

                } while (bit is (<0) || bit is (>1));

                bits[i] = bit;
            }

            int x = 1;
            int sum = 0;

            for(int i = bits.Length - 1; i >= 0; i--)
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
