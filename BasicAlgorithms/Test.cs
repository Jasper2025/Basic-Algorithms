using System;

namespace BasicAlgorithms
{
    class Test
    {
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            var randomArray = GenerateRandomArray(10);

            Console.WriteLine("Random 10 Integer Array Generated...");

            Console.Write("Random Array: ");
            PrintArray(randomArray);

            SortingAlgorithmConsole();

            int userSortingAlgorithmSelection = Convert.ToInt32(Console.ReadLine());

            ExecuteSelectedAlgorithm(randomArray, userSortingAlgorithmSelection);

            PrintArray(randomArray);

            if (IsArraySorted(randomArray))
                Console.WriteLine("\n\nArray has been successfully sorted!");
            else
                Console.WriteLine("\n\nArray was not successfully sorted...");
        }//Main

        private static void ExecuteSelectedAlgorithm(int[] randomArray, int userSortingAlgorithmSelection)
        {
            switch (userSortingAlgorithmSelection)
            {
                case 1:
                    {
                        Console.WriteLine("Bubble Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.BubbleSort(randomArray);
                        break;
                    }//case1 - BubbleSort
                case 2:
                    {
                        Console.WriteLine("Insertion Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.InsertionSort(randomArray);
                        break;
                    }//case2 - InsertionSort
                case 3:
                    {
                        Console.WriteLine("Selection Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.SelectionSort(randomArray);
                        break;
                    }//case3 - SelectionSort
                case 4:
                    {
                        Console.WriteLine("Merge Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.MergeSort(randomArray);
                        break;
                    }//case4 - MergeSort
                case 5:
                    {
                        Console.WriteLine("Quick Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.QuickSort(randomArray, 0, randomArray.Length);
                        break;
                    }//case5 - QuickSort
            }//switch
        }

        private static void SortingAlgorithmConsole()
        {
            Console.WriteLine("\n\nAlgorithm Tester...\n");
            Console.WriteLine("1 --> BubbleSort");
            Console.WriteLine("2 --> InsertionSort");
            Console.WriteLine("3 --> SelectionSort");
            Console.WriteLine("4 --> MergeSort");
            Console.WriteLine("5 --> QuickSort\n");
            Console.Write("Selection Basic Algorithm to Preform... ");
        }//SortingAlgorithmConsole

        private static void PrintArray(int[] randomArray)
        {
            foreach (var integer in randomArray)
                Console.Write($"{integer} ");
        }//PrintArray

        private static int[] GenerateRandomArray(int arraySize)
        {
            var randomArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
                randomArray[i] = Random.Next(100) + 1; /* array contains random numbers between 1 and 100 */

            return randomArray;
        }//GenerateRandomArray

        private static bool IsArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }//for

            return true;
        }//IsArraySorted
    }
}
using System;

namespace BasicAlgorithms
{
    class Test
    {
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            var randomArray = GenerateRandomArray(10);

            Console.WriteLine("Random 10 Integer Array Generated...");

            Console.Write("Random Array: ");
            PrintArray(randomArray);

            SortingAlgorithmConsole();

            int userSortingAlgorithmSelection = Convert.ToInt32(Console.ReadLine());

            ExecuteSelectedAlgorithm(randomArray, userSortingAlgorithmSelection);

            PrintArray(randomArray);

            if (IsArraySorted(randomArray))
                Console.WriteLine("\n\nArray has been successfully sorted!");
            else
                Console.WriteLine("\n\nArray was not successfully sorted...");
        }//Main

        private static void ExecuteSelectedAlgorithm(int[] randomArray, int userSortingAlgorithmSelection)
        {
            switch (userSortingAlgorithmSelection)
            {
                case 1:
                    {
                        Console.WriteLine("Bubble Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.BubbleSort(randomArray);
                        break;
                    }//case1 - BubbleSort
                case 2:
                    {
                        Console.WriteLine("Insertion Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.InsertionSort(randomArray);
                        break;
                    }//case2 - InsertionSort
                case 3:
                    {
                        Console.WriteLine("Selection Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.SelectionSort(randomArray);
                        break;
                    }//case3 - SelectionSort
                case 4:
                    {
                        Console.WriteLine("Merge Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.MergeSort(randomArray);
                        break;
                    }//case4 - MergeSort
                case 5:
                    {
                        Console.WriteLine("Quick Sort Algorithm Preformed...\n");
                        BasicSortingAlgorithms.QuickSort(randomArray, 0, randomArray.Length);
                        break;
                    }//case5 - QuickSort
            }//switch
        }

        private static void SortingAlgorithmConsole()
        {
            Console.WriteLine("\n\nAlgorithm Tester...\n");
            Console.WriteLine("1 --> BubbleSort");
            Console.WriteLine("2 --> InsertionSort");
            Console.WriteLine("3 --> SelectionSort");
            Console.WriteLine("4 --> MergeSort");
            Console.WriteLine("5 --> QuickSort\n");
            Console.Write("Selection Basic Algorithm to Preform... ");
        }//SortingAlgorithmConsole

        private static void PrintArray(int[] randomArray)
        {
            foreach (var integer in randomArray)
                Console.Write($"{integer} ");
        }//PrintArray

        private static int[] GenerateRandomArray(int arraySize)
        {
            var randomArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
                randomArray[i] = Random.Next(100) + 1; /* array contains random numbers between 1 and 100 */

            return randomArray;
        }//GenerateRandomArray

        private static bool IsArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }//for

            return true;
        }//IsArraySorted
    }
}
