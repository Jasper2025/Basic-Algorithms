namespace BasicAlgorithms
{
    public partial class BasicSortingAlgorithms
    {
        /* https://en.wikipedia.org/wiki/Bubble_sort */
        public static void BubbleSort(int[] randomArray)
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

        /* https://en.wikipedia.org/wiki/Insertion_sort */
        public static void InsertionSort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                int j = i;
                int toInsert = unsortedArray[j];
                while (j > 0 && unsortedArray[j - 1] > toInsert)
                {
                    unsortedArray[j] = unsortedArray[j - 1];
                    j--;
                }//while
                unsortedArray[j] = toInsert;
            }//for
        }//InsertionSort

        /* https://en.wikipedia.org/wiki/Selection_sort */
        public static void SelectionSort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                int startIndex = i;
                for (int j = i; j < unsortedArray.Length; j++)
                {
                    if (unsortedArray[startIndex] > unsortedArray[j])
                    {
                        startIndex = j;
                    }//if
                }//for
                int temp = unsortedArray[i];
                unsortedArray[i] = unsortedArray[startIndex];
                unsortedArray[startIndex] = temp;
            }//for
        }//SelectionSort
    }//Partial Class - BasicSortingAlgorithms

    public partial class BasicSortingAlgorithms
    {
        /* https://en.wikipedia.org/wiki/Merge_sort */
        private static void Merge(int[] leftArray, int[] rightArray, int[] combinedArray)
        {
            int leftArrIndex = 0, rightArrIndex = 0, combinedArrIndex = 0;

            while (leftArrIndex < leftArray.Length && rightArrIndex < rightArray.Length)
            {
                if (leftArray[leftArrIndex] <= rightArray[rightArrIndex])
                {
                    combinedArray[combinedArrIndex++] = leftArray[leftArrIndex++];
                } //if
                else
                {
                    combinedArray[combinedArrIndex++] = rightArray[rightArrIndex++];
                }//else
            }//while

            while (leftArrIndex < leftArray.Length)
            {
                combinedArray[combinedArrIndex++] = leftArray[leftArrIndex++];
            }//while

            while (rightArrIndex < rightArray.Length)
            {
                combinedArray[combinedArrIndex++] = rightArray[rightArrIndex++];
            }//while
        }//Merge

        public static void MergeSort(int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }//if

            int midArr = array.Length / 2;
            int[] leftArray = new int[midArr];
            int[] rightArray = new int[array.Length - midArr];

            for (int i = 0; i < midArr; i++)
            {
                leftArray[i] = array[i];
            }//for

            int index = 0;

            for (int j = midArr; j < array.Length; j++)
            {
                rightArray[index++] = array[j];
            }//for

            MergeSort(leftArray);
            MergeSort(rightArray);
            Merge(leftArray, rightArray, array);
        }//MergeSort
    }//Partial Class - BasicSortingAlgorithms


public partial class BasicSortingAlgorithms
    {
        /* https://en.wikipedia.org/wiki/Quicksort */

        public static void QuickSort(int[] array, int startIndex, int endIndex)
        {
            if (endIndex > startIndex)
            {
                int partitionIndex = Partition(array, startIndex, endIndex);
                QuickSort(array, startIndex, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, endIndex);
            }//if
        }//QuickSort

        private static int Partition(int[] array, int startIndex, int endIndex) // moves elements smaller than pivot to leftArray and elements larger to rightArray
        {
            int partitionIndex = startIndex;
            int pivot = array[endIndex];
            int temp = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                if (array[i] <= pivot)
                {
                    temp = array[i];
                    array[i] = array[partitionIndex];
                    array[partitionIndex] = temp;
                    partitionIndex++;
                }//if
            }//for

            temp = array[partitionIndex];
            array[partitionIndex] = array[endIndex];
            array[endIndex] = temp;

            return partitionIndex;
        }//Partition
    }//Partial Class - BasicSortingAlgorithms
}