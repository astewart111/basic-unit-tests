using System;
public class CalculatorOther
{
    // Method to check if a number is odd
    public bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    public bool IsPrime(int number)
    {
        // Handle edge cases for numbers less than 2
        if (number <= 1)
        {
            return false;
        }

        // Check divisibility from 2 to the square root of the number
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)  // If divisible by any number, it's not prime
            {
                return false;
            }
        }

        return true;  // If no divisors were found, it is prime
    }

    public void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        // Outer loop: iterate through all elements
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            // Inner loop: compare adjacent elements
            for (int j = 0; j < n - i - 1; j++)
            {
                // If the current element is greater than the next, swap them
                if (array[j] > array[j + 1])
                {
                    // Swap the elements
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true; // Indicate that a swap occurred
                }
            }

            // If no elements were swapped, the array is already sorted
            if (!swapped)
                break;
        }
    }

    // Quick Sort Method
    public void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Partitioning index
            int pi = Partition(array, low, high);

            // Recursively sort the left and right subarrays
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    // Partition method to find the pivot element and arrange the elements around it
    public int Partition(int[] array, int low, int high)
    {
        // Choosing the last element as the pivot
        int pivot = array[high];
        int i = low - 1;

        // Rearranging elements so that all elements smaller than pivot are on the left
        // and all elements greater than pivot are on the right
        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        // Swap the pivot element to its correct position
        Swap(ref array[i + 1], ref array[high]);

        return i + 1; // Return the index of the pivot
    }

    // Helper method to swap two elements
    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}