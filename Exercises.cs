using System;
namespace Basics
{
    class Exercises
    {
        static void Main(string[] args)
        {
            //example1();
            //example2();
            //example3();
            //example4();
            //example5();
            //example6();
            //example7();
        }

        static void example6()
        {
            int[,] testMarks = new int[5, 10];
            InitializeTestMarks(testMarks);
            DisplayTestMarks(testMarks);
        }

        static void InitializeTestMarks(int[,] marks)
        {
            for (int course = 0; course < 5; course++)
                for (int student = 0; student < 10; student++)
                    marks[course, student] = course * 10 + student + 1;
        }

        static void DisplayTestMarks(int[,] marks)
        {
            for (int course = 0; course < 5; course++)
            {
                Console.WriteLine($"Course {course + 1}:");
                for (int student = 0; student < 10; student++)
                    Console.WriteLine($"  Student {student + 1}: {marks[course, student]}");
            }
        }

        static void example5()
        {
            int choice;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Convert Decimal to Binary");
                Console.WriteLine("2. Convert Binary to Decimal");
                Console.WriteLine("3. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a decimal number: ");
                        int decimalNumber = int.Parse(Console.ReadLine());
                        string binary = DecimalToBinary(decimalNumber);
                        Console.WriteLine($"Binary representation: {binary}");
                        break;
                    case 2:
                        Console.Write("Enter a binary number: ");
                        string binaryNumber = Console.ReadLine();
                        int decimalValue = BinaryToDecimal(binaryNumber);
                        Console.WriteLine($"Decimal value: {decimalValue}");
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            } while (choice != 3);
        }

        static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        static int BinaryToDecimal(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        static void example4()
        {
            int[] responses = { 3, 2, 4, 3, 5, 4, 3, 2, 3, 4, 5, 2, 1, 4, 4, 5, 3, 2, 4, 3, 4, 5, 5, 4, 2, 3, 3, 4, 5, 1, 4, 2, 3, 3, 4, 5, 2, 4, 3 };

            int[] frequency = new int[5];

            foreach (int response in responses)
            {
                // Increment the count for the corresponding rating in the frequency array
                frequency[response - 1]++;
            }

            for (int i = 0; i < 5; i++)
            {
                int rating = i + 1;
                Console.WriteLine($"Response {rating} given by: {frequency[i]} people");
            }
        }

        static void example3()
        {
            string inputString = "This is a string, my name is sikandar and i am from aumc";
            string[] result = ExtractWordsWithCriteria(inputString);

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }

        static string[] ExtractWordsWithCriteria(string input)
        {
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string validWords = "";

            foreach (string word in words)
            {
                if (word.Length >= 4 && word.Length <= 5 && ContainsVowels(word))
                {
                    validWords += word + " ";
                }
            }

            return validWords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        static bool ContainsVowels(string word)
        {
            foreach (char c in word)
            {
                if ("AEIOUaeiou".Contains(c))
                {
                    return true;
                }
            }
            return false;
        }

        static void example2()
        {
            string[] s = { "hello", "and", "welcome" };
            string mergedString = merger(s);
            Console.WriteLine(mergedString);

        }
        
        static string merger(string[] s)
        {
            string mergedString = "";

            foreach (string s2 in s)
            {
                mergedString = mergedString + " " + s2;
            }

            return mergedString;
        }

        static void example1()
        {
            int[,] array2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            print2DArrays(array2d);
        }

        static void print2DArrays(int[,] array2d)
        {
            foreach (int i in array2d)
            {
                Console.WriteLine($"{i}");
            }
        }

        static void example7()
        {
            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            int[,] resultMatrix = new int[3, 3];

            Console.WriteLine("Enter values for Matrix A (3x3):");
            ReadMatrix(matrixA);

            Console.WriteLine("Enter values for Matrix B (3x3):");
            ReadMatrix(matrixB);

            MultiplyMatrices(matrixA, matrixB, resultMatrix);

            Console.WriteLine("Resultant Matrix (A x B):");
            PrintMatrix(resultMatrix);
        }

        static void ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] rowValues = Console.ReadLine().Split(' '); 1

                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(rowValues[j]);
                }
            }
        }

        static void MultiplyMatrices(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}