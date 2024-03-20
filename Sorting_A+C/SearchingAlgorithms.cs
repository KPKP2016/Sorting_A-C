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
    // Constructor array assigned as Values
    public int[] Values { get; set; }

    // binary search method
    public int Binary(int target)
    {
        int left = 0;
        int right = Values.Length - 1;

        while (left <= right)
        {
            // starts from middle of array
            int location = left + (right - left) / 2;
            if (Values[location] == target)
            {
                // checks if locaiton is larger than array size
                if (location >= Values.Length)
                {
                    location--;
                    return location;
                }
                else
                {
                    Console.WriteLine("In position: " + location); // number found
                    return location;
                }
            }
            // shifts to the left
            else if (Values[location] < target)
            {
                left = location + 1;
            }
            // shifts to the right
            else
            {
                right = location - 1;
            }
        }

        return -1; // Target not found
    }

    // linear search method
    public int Linear(int target)
    {
        List<int> duplicateIndexes = new List<int>();

        for (int location = 0; location < Values.Length; location++)
        {
            // goes through every value in the array to see if it is the value wanted
            if (Values[location] == target)
            {

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

                    // returns location of target number
                    Console.WriteLine("In position: " + location);
                    return location;
                }
            }
        }
        // returns if value not found in list
        return -1;
    }


    // nearest value method 
    public int NearestValue(int target)
    {
        int nearestValue = Values[0]; // nearest number to value wanted
        int minDiff = Math.Abs(target - Values[0]); // distance between the number and the value wanted

        foreach (int num in Values)
        {
            // goes through each number in array and finds distance between
            int diff = Math.Abs(target - num);
            // Compares between new distance and old distance
            if (diff < minDiff)
            {
                // assigned shorter and shorter distance each iteration until diff is larger
                minDiff = diff;
                nearestValue = num;
            }
        }
        return nearestValue;

    }
}



