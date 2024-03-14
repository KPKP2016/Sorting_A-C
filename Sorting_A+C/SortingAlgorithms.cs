using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class SortingAlgorithms
{
    public int[] Values { get; set; }

    // Bubble sort
    public int[] Bubble()
    {
        var n = Values.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (Values[j] > Values[j + 1])
                {
                    var tempVar = Values[j];
                    Values[j] = Values[j + 1];
                    Values[j + 1] = tempVar;
                }
        return Values;
    }

    // Insertion sort
    public int[] Insertion()
    {
        for (int i = 1; i < Values.Length; i++)
        {
            int current = Values[i];
            int j = i - 1;

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
                    (Values[i], Values[j]) = (Values[j], Values[i]);
                }
            }

            (Values[i + 1], Values[high]) = (Values[high], Values[i + 1]);

            Quick(low, i);
            Quick(i + 1, high);
        }
        return Values;
    }
}