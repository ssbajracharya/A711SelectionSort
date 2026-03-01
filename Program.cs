using System;

namespace A711SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 72, 95, 61, 88, 54, 79, 91, 67, 83, 76 };
            int[] scores2 = new int[] { 99, 77, 55, 88, 66, 100, 61, 64, 87, 60 };

            Console.WriteLine("Unsorted exam scores:");
            PrintArray(scores);
            SelectionSort(scores);
            Console.WriteLine("\nSorted exam scores (ascending):");
            PrintArray(scores);

            Console.WriteLine("Unsorted exam scores:");
            PrintArray(scores2);
            SelectionSort(scores2);
            Console.WriteLine("\nSorted exam scores (ascending):");
            PrintArray(scores2);

            Console.WriteLine(new string('*', 100));
            Console.WriteLine(MergeAlternate("abc", "pqer"));
            Console.WriteLine();
            Console.WriteLine(MergeAlternate("aceg", "bdfhijklmnopqrstuvwxyz"));
        }

        static void SelectionSort(int[] arr)
        {
            int arrLen = arr.Length;
            for (int i = 0; i < arrLen - 1; i++)
            {
                int minIdx = i;

                for (int j = i + 1; j < arrLen; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }

                (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
            }
        }

        static string MergeAlternate(string word1, string word2)
        {
            int maxLen = Math.Max(word1.Length, word2.Length);
            char[] charArr = new char[word1.Length + word2.Length];
            int currIdx = 0;

            for (int i = 0; i < maxLen; i++)
            {
                if (i < word1.Length)
                {
                    charArr[currIdx] = word1[i];
                    currIdx++;
                }
                if (i < word2.Length)
                {
                    charArr[currIdx] = word2[i];
                    currIdx++;
                }
            }

            return new string(charArr);
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }
}
