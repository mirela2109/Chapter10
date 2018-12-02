using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете елемент {0}: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведете сума: ");
            int sum = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int second = arr[j];

                    if ((first + second) == sum)
                        Console.WriteLine("({0}, {1}) ", first, second);
                }
            }
        }
    }
}
