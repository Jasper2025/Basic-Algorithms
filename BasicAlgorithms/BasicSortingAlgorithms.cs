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
    }

    public partial class BasicSortingAlgorithms
    {
        /* https://en.wikipedia.org/wiki/Merge_sort */
        private static void Merge(int[] left, int[] right, int[] result)
        {
            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    result[resultIndex++] = left[leftIndex++];
                }//if
                else
                {
                    result[resultIndex++] = right[rightIndex++];
                }//else
            }//while

            while (leftIndex < left.Length)
            {
                result[resultIndex++] = left[leftIndex++];
            }//while

            while (rightIndex < right.Length)
            {
                result[resultIndex++] = right[rightIndex++];
            }//while
        }//Merge

        public static void MergeSort(int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }//if

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }//for

            int index = 0;

            for (int j = mid; j < array.Length; j++)
            {
                right[index++] = array[j];
            }//for

            MergeSort(left);
            MergeSort(right);
            Merge(left, right, array);
        }//MergeSort
    }

    public partial class BasicSortingAlgorithms
    {
        /* https://en.wikipedia.org/wiki/Quicksort */

        public static void QuickSort(int[] A, int start, int end)
        {
            if (end > start)
            {
                int pIndex = Partition(A, start, end);
                QuickSort(A, start, pIndex - 1);
                QuickSort(A, pIndex + 1, end);
            }//if
        }//QuickSort

        private static int Partition(int[] A, int start, int end) // moves elements smaller than pivot to left and elements larger to right
        {
            int partitionIndex = start;
            int pivot = A[end];
            int temp = 0;

            for (int i = start; i < end; i++)
            {
                if (A[i] <= pivot)
                {
                    temp = A[i];
                    A[i] = A[partitionIndex];
                    A[partitionIndex] = temp;
                    partitionIndex++;
                }//if
            }//for
            temp = A[partitionIndex];
            A[partitionIndex] = A[end];
            A[end] = temp;

            return partitionIndex;
        }//Partition
    }
}