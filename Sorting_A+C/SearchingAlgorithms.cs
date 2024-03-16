using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class SearchingAlgorithms
{
    public int[] Values { get; set; }

    public int Binary(int target)
    {
        int left = 0;
        int right = Values.Length - 1;

        while (left <= right)
        {
            int location = left + (right - left) / 2;

            if (Values[location] == target)
            {
                Console.WriteLine("In position: " + location);// Target found

                if (location >= Values.Length)
                {
                    location--;
                    return location;
                }
            }
            else if (Values[location] < target)
            {
                left = location + 1;
            }
            else
            {
                right = location - 1;
            }
        }

        return -1; // Target not found
    }

    public int Linear(int target)
    {
        List<int> duplicateIndexes = new List<int>();

        for (int location = 0; location < Values.Length; location++)
        {
            if (Values[location] == target)
            {
                // returns location of target number
                Console.WriteLine("In position: " + location);
                return location;

                // if the number is already in the list, then it will print the new location of the number too.
                if (duplicateIndexes.Contains(location))
                {
                    Console.WriteLine("And in position: " + location);
                    return location;
                }
                // adds number to list to check if number is duplicated.
                else
                {
                    duplicateIndexes.Add(location);
                }
            }
        }

        return -1;
    }


    public int NearestValue(int target)
    {
        int nearestValue = Values[0];
        int minDiff = Math.Abs(target - Values[0]);

        foreach (int num in Values)
        {
            int diff = Math.Abs(target - num);
            if (diff < minDiff)
            {
                minDiff = diff;
                nearestValue = num;
            }
        }

        return nearestValue;

    }
}



