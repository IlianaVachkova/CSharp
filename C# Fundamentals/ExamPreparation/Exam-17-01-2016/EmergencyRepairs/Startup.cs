using System;

namespace EmergencyRepairs
{
    public class Startup
    {
        public static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            byte emergencyKit = byte.Parse(Console.ReadLine());
            byte attacks = byte.Parse(Console.ReadLine());

            ulong oneForBinary = 1;
            ulong mask, maskNeighbour, turnedMask, numberAndMask, numberAndMaskNeighbour, bit, bitNext, result;

            for (int i = 0; i < attacks; i++)
            {
                byte attackNumber = byte.Parse(Console.ReadLine());

                mask = oneForBinary << attackNumber;
                numberAndMask = number & mask;
                bit = numberAndMask >> attackNumber;

                if (bit == 1)
                {
                    turnedMask = ~mask;
                    result = number & turnedMask;
                    number = result;
                }
            }

            byte counterKits = 0;
            bool flag = false;

            for (byte i = 0; i < 64; i++)
            {
                if (counterKits == emergencyKit)
                {
                    break;
                }

                mask = oneForBinary << i;
                numberAndMask = number & mask;
                bit = numberAndMask >> i;

                maskNeighbour = oneForBinary << (i + 1);
                numberAndMaskNeighbour = number & maskNeighbour;
                bitNext = numberAndMaskNeighbour >> (i + 1);


                if (bit == 0 && bitNext != 1 || bit == 0 && flag)
                {
                    mask = oneForBinary << i;
                    result = number | mask;
                    number = result;
                    flag = true;
                    counterKits += 1;
                }
                else
                {
                    flag = false;
                }
            }

            Console.WriteLine(number);
        }
    }
}
