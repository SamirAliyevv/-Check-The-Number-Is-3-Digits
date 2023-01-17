using System;

namespace check_the_number_is_3_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 99, 151, 999, 45, 354, 234 };
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>99 && numbers[i]<1000)
                {
                    count++;
                }

            }
            Console.WriteLine(count);



        }
    }
}
