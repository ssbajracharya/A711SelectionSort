namespace A711SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = [72, 95, 61, 88, 54, 79, 91, 67, 83, 76];

            Console.WriteLine("Unsorted exam scores:");
            PrintArray(scores);

            SelectionSort(scores);

            Console.WriteLine("\nSorted exam scores (ascending):");
            PrintArray(scores);
        }

        static void SelectionSort(int[] arr)
        {
            int arrLen = arr.Length;
            for(int i = 0; i < arrLen - 1; i++)
            {
                int minIdx = i;

                for(int j = i + 1; j < arrLen; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }    
                }

                (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }
}
