using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //example1();
            //example2();
            example4();
            
        }
        static void example1()
        {
            int[] numbers = { 4, 5, 6, 7, 8, 12, 3, -1 };
            foreach (int i in numbers)
            {
                Console.WriteLine($"{i}");
            }
        }

        static void example2()
        {
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 32 }, { 5, 55 } };
            
            foreach (int i in numbers2D)
            {
                Console.WriteLine($"{i}");
            }
        }

        private static void ChangeArrayElements(string[] weekDays)
        {
            weekDays[0] = "Sat";
            weekDays[1] = "Fri";
            weekDays[2] = "Thu";
            Console.WriteLine($"arr[0] is {weekDays[0]} in ChangeArray");
        }
        private static void ChangeArray(string[] weekDays)
        {
            weekDays = (weekDays.Reverse()).ToArray();
        }

        public static void printArray(string[] weekDays)
        {
            for(int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i] + "{0}", i < weekDays.Length - 1 ? " " : "");
            }
            Console.WriteLine();
        }

        public static void example4()
        {
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            printArray(weekDays);

            ChangeArray(weekDays);
            Console.WriteLine("Array weekdays after changeArray function: ");
            printArray(weekDays);
            Console.WriteLine();

            ChangeArrayElements(weekDays);
            Console.WriteLine("Array weekdays after changeArrayElements function: ");
            printArray(weekDays);
        }

    }

}
