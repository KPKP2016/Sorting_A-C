using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Sorting_A_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialise an empty array
            int[] finalArray = { };
            
            // offered choice of file: Net_1, Net_2, Net_3
            Console.WriteLine("Please select a file. (1,2,3): ");
            String fileChoice = Console.ReadLine(); 

            // Offered choice of large or small file
            Console.WriteLine("256 or 2048. (1,2): ");
            String largeFileChoice = Console.ReadLine();


            // Net_1 files
            if (fileChoice == "1")
            {                
                // reads 256 text file
                if (largeFileChoice == "1")
                {
                    Net_1 data = new Net_1();
                    finalArray = data.SmallFile();
                }

                // reads 2048 text file
                else if (largeFileChoice == "2")
                { 
                    Net_1 data = new Net_1();
                    finalArray = data.LargeFile();
                }
            }

            // Net_2 files
            else if (fileChoice == "2")
            {
                // reads  256 text file
                if (largeFileChoice == "1")
                {
                    Net_2 data = new Net_2();
                    finalArray = data.SmallFile();
                }

                // reads 2048 text file
                else if (largeFileChoice == "2")
                {
                    Net_2 data = new Net_2();
                    finalArray = data.LargeFile();
                }
            }

            // Net_3 files
            else if (fileChoice == "3")
            {
                // reads 256 text file
                if (largeFileChoice == "1")
                {
                    Net_3 data = new Net_3();
                    finalArray = data.SmallFile();
                }

                // reads 2048 text file
                else if (largeFileChoice == "2")
                {
                    Net_3 data = new Net_3();
                    finalArray = data.LargeFile();
                }
            }


            // sorting algorithm choice between 
            Console.WriteLine("Bubble sort, Insertion sort, Quick sort or Selection sort. (1,2,3,4): ");
            String sortChoice = Console.ReadLine();

            // runs bubble sort algorithm
            if (sortChoice == "1")
            {
                SortingAlgorithms sorting = new SortingAlgorithms();
                sorting.Values = finalArray;
                sorting.Bubble();
            }

            // runs insertion sort algorithm
            else if (sortChoice == "2")
            {
                SortingAlgorithms sorting = new SortingAlgorithms();
                sorting.Values = finalArray;
                sorting.Insertion();
            }

            // runs quick sort algorithm
            else if (sortChoice == "3")
            { 
                SortingAlgorithms sorting = new SortingAlgorithms();
                sorting.Values = finalArray;
                sorting.Quick(0, finalArray.Length-1); // takes 2 parameters: first index and last index

            }

            // runs selection sort algorithm
            else if (sortChoice == "4")
            {
                SortingAlgorithms sorting = new SortingAlgorithms();
                sorting.Values = finalArray;
                sorting.Selection(); 

            }


            // option for ascending order or descending order
            Console.WriteLine("Ascending or Decending? (1,2): ");
            String outputChoice = Console.ReadLine();

            // ascending order
            if (outputChoice == "1")
            {
                if (largeFileChoice == "1") // this is a 256 text file, so it outputs every 10 values
                {
                    for (int i = 0; i < finalArray.Length; i += 10)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }

                else if (largeFileChoice == "2") // this is a 2048 text file, so it outputs every 50 values
                {
                    for (int i = 0; i < finalArray.Length; i += 50)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }
            }


            // descending order
            if (outputChoice == "2")
            {
                // reverses the ordered array
                Array.Reverse(finalArray);

                if (largeFileChoice == "1") // this is a 256 text file, so it outputs every 10 values
                {
                    for (int i = 0; i < finalArray.Length; i += 10)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }

                else if (largeFileChoice == "2") // this is a 2048 text file, so it outputs every 10 values
                {
                    for (int i = 0; i < finalArray.Length; i += 50)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }
                
                // reverses the changes after valuse outputted
                Array.Reverse(finalArray);
            }


            // asks user to choose number to find inside list
            Console.WriteLine("What number do you want to find in this list: ");
            int targetNum = int.Parse(Console.ReadLine());

            // checks if number is inside the list
            if (!finalArray.Contains(targetNum))
            {
                Console.WriteLine("Not in Array");

                // chooses the nearest value next to the input number
                SearchingAlgorithms search = new SearchingAlgorithms();
                search.Values = finalArray;
                targetNum = search.NearestValue(targetNum);
                Console.WriteLine("Nearest number is: " + targetNum);
            }


            // choice to use binary or linear search.
            Console.WriteLine("Binary search, linear search. (1,2): ");
            String SearchChoice = Console.ReadLine();

            // binary search
            if (SearchChoice == "1")
            {
                SearchingAlgorithms search = new SearchingAlgorithms();
                search.Values = finalArray;
                search.Binary(targetNum);
            }

            // lienar search
            else if (SearchChoice == "2")
            {
                SearchingAlgorithms search = new SearchingAlgorithms();
                search.Values = finalArray;
                search.Linear(targetNum);
            }
        }
    }
}
