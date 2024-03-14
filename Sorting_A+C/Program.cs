using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting_A_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> tempArray = new List<int>();
            
            Console.WriteLine("Please select a file. (1,2,3): ");
            String fileChoice = Console.ReadLine(); 

            if (fileChoice == "1")
            {
                Console.WriteLine("256 or 2048. (1,2): ");
                String largeFileChoice = Console.ReadLine();

                String[] lines = File.ReadAllLines("Net_1_256.txt");

                // reads text file
                if (largeFileChoice == "1")
                {
                    lines = File.ReadAllLines("Net_1_256.txt");
                }

                if (largeFileChoice == "2")
                {
                    lines = File.ReadAllLines("Net_1_2048.txt");
                }

                foreach (string value in lines)
                {
                    // converts from string to integer and stores it in array
                    if (int.TryParse(value, out int number))
                    {
                        tempArray.Add(number);
                    }
                }

                int[] finalArray = tempArray.ToArray();


                // sorting algorithm choice between 

                Console.WriteLine("Bubble sort, Insertion sort, Quick sort. (1,2,3): ");

                String sortChoice = Console.ReadLine();

                if (sortChoice == "1")
                {
                    SortingAlgorithms sorting = new SortingAlgorithms();
                    sorting.Values = finalArray;
                    sorting.Bubble();
                }

                if (sortChoice == "2")
                {
                    SortingAlgorithms sorting = new SortingAlgorithms();
                    sorting.Values = finalArray;
                    sorting.Insertion();
                }

                if (sortChoice == "3")
                {
                    int low = Array.IndexOf(finalArray, finalArray.Min());
                    int high = Array.IndexOf(finalArray, finalArray.Max());

                    SortingAlgorithms sorting = new SortingAlgorithms();
                    sorting.Values = finalArray;
                    sorting.Quick(low,high);
                }


                // put in option for ascending order or descending order

                Console.WriteLine("Ascending or Decending? (1,2): ");
                String outputChoice = Console.ReadLine();

                if (outputChoice == "1")
                {
                    for (int i = 1; i < finalArray.Length; i += 10)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }

                // descending order
                if (outputChoice == "2")
                {
                    Array.Reverse(finalArray);

                    for (int i = 1; i < finalArray.Length; i += 10)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }






            }
        }
    }
}
