using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Bubble Sort Algorithm 
 * 
 * Time Complexities:
 * Best-Case: O(n) ----- Already Sorted
 * Average-Case: O(n^2) ----- Not Sorted
 * Worst-Case: O(n^2) ----- Not Sorted
 * 
 * Space Complexity:
 * Worst-Case: O(1) 
 */


namespace Bubble
{
    class Bubble
    {
        private static readonly Random random = new Random();
        private static void Main(string[] args)
        {
            int randomArraySize = random.Next(6) + 5; /* random array size between 5 and 10 */ 
            int[] randomArray = GenerateRandomArray(randomArraySize);

            Console.WriteLine($"Random Array Size (5 - 10): {randomArraySize}");

            Console.WriteLine("\nBefore bubble sort:");
            PrintArray(randomArray);

            BubbleSort(randomArray);

            Console.WriteLine("\n\nAfter bubble sort:");
            PrintArray(randomArray);

            if (IsArraySorted(randomArray) == true)
            {
                Console.WriteLine("\n\nBubble Sorted Succeeded!");
            }//if
        }//Main

        private static void PrintArray(int[] randomArray)
        {
            foreach (var integer in randomArray)
            {
                Console.Write($"{integer} ");
            }//foreach
        }//PrintArray

        private static void BubbleSort(int[] randomArray)
        {
            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = 0; j < randomArray.Length - 1 - i; j++)
                {
                    if (randomArray[j] > randomArray[j + 1])
                    {
                        int temp = randomArray[j];
                        randomArray[j] = randomArray[j + 1];
                        randomArray[j + 1] = temp; 
                    }//if
                }//for
            }//for
        }//BubbleSort

        private static int[] GenerateRandomArray(int arraySize)
        {
            var randomArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                randomArray[i] = random.Next(100) + 1; /* array contains random number between 1 and 100 */ 
            }//for
            return randomArray;
        }//GenerateRandomArray

        private static bool IsArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false; 
                }//if
            }//for
            return true; 
        }//IsArraySorted
    }
}
