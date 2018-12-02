using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина на думата: ");
            length = Int32.Parse(Console.ReadLine());

            strings = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете дума {0}: ", i + 1);
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i <= length; i++)
            {
                str = new string[length];
                cycle(0, 0, i);
            }
        }
        static string[] strings, str;
        static int length;

        static void cycle(int iter, int index, int k)
        {
            if (iter == k)
            {
                for (int i = 0; i < length; i++)
                    Console.WriteLine("({0})", str[i]);
                return;
            }

            for (int i = index; i < strings.Length; i++)
            {
                str[iter] = strings[i];
                cycle(iter + 1, i + 1, k);
            }
        }
    }
}

