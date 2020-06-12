using System;

namespace BeatifuldaysattheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1234;
            int j = 1237;
            int k = 6;
            int count = 0;
            int one = 0, two = 0, three = 0, four = 0;
            int reverse = 0;
            int Result = 0;

            for (int a = i; a <= j; a++)
            {
                if (a < 100)
                {
                    one = a % 10;
                    two = a / 10;
                    reverse = (one * 10) + two;
                }
                else if (a < 1000)
                {
                    one = a % 10;
                    two = (a % 100) - one;
                    three = a / 100;
                    reverse = (one * 100) + two + three;
                }
                else
                {
                    one = a % 10;
                    two = (a % 100) - one;
                    three = (a % 1000) - one - two;
                    four = a / 1000;
                    reverse = (one * 1000) + (two * 10) + (three / 10) + four;
                }


                Result = Math.Abs(a - reverse) % k;

                if (Result == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Result!" + count);
        }
    }
}
