using System;

namespace BeatifuldaysattheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            int j = 23;
            int k = 6;
            int count = 0;
            int reverse = 0;
            int Result = 0;

            for (int a = i; a <= j; a++)
            {
                int digits = 0;
                int temp = a;
                do
                {
                    digits = temp % 10;
                    temp = temp / 10;

                    if (reverse == 0)
                    {
                        reverse = digits;
                    }
                    else
                    {
                        reverse *= 10;
                        reverse += digits;
                    }
                } while (temp != 0);


                Result = Math.Abs(a - reverse) % k;
                reverse = 0;
                if (Result == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Result!" + count);
        }
    }
}
