using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class SortingAlgorithms
{
    // Constructor array assigned as Values
    public int[] Values { get; set; }

    // Bubble sort
    public int[] Bubble()
    {
        var n = Values.Length;
        // iterates from start to end of array
        for (int i = 0; i < n - 1; i++)
            // compares adjacent values and swaps if necessary
            for (int j = 0; j < n - i - 1; j++)
                if (Values[j] > Values[j + 1])
                {
                    // swap
                    var tempVar = Values[j];
                    Values[j] = Values[j + 1];
                    Values[j + 1] = tempVar;
                }
        return Values;
    }

    // Insertion sort
    public int[] Insertion()
    {
        // Iterates from the second to end of array
        for (int i = 1; i < Values.Length; i++)
        {
            int current = Values[i];
            int j = i - 1;

            // shifts elements greater than current to the right
            while (j >= 0 && Values[j] > current)
            {
                Values[j + 1] = Values[j];
                j--;
            }
            Values[j + 1] = current;
        }
        return Values;
    }

    // Quick sort
    public int[] Quick(int low, int high)
    {
        if (low < high)
        {
            int pivot = Values[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (Values[j] < pivot)
                {
                    i++;
                    // swap
                    (Values[i], Values[j]) = (Values[j], Values[i]);
                }
            }

            (Values[i + 1], Values[high]) = (Values[high], Values[i + 1]);

            // recursed with updated parameters
            Quick(low, i);
            Quick(i + 2, high);
        }
        return Values;
    }

    // Selection Sort Algorithm
    public int[] Selection()
    {
        var n = Values.Length;
        // iterates through every value in array
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                // if current value is smaller than current min value, then swap.
                if (Values[j] < Values[minIndex])
                {
                    // updated min index
                    minIndex = j;
                }
            }
            // swap
            int temp = Values[minIndex];
            Values[minIndex] = Values[i];
            Values[i] = temp;
        }
        return Values;
    }





}