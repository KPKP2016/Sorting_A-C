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
                // reads text file
                if (largeFileChoice == "1")
                {
                    Net_1 data = new Net_1();
                    finalArray = data.SmallFile();
                }

                else if (largeFileChoice == "2")
                { 
                    Net_1 data = new Net_1();
                    finalArray = data.LargeFile();
                }
            }

            // Net_2 files
            else if (fileChoice == "2")
            {
                // reads text file
                if (largeFileChoice == "1")
                {
                    Net_2 data = new Net_2();
                    finalArray = data.SmallFile();
                }

                else if (largeFileChoice == "2")
                {
                    Net_2 data = new Net_2();
                    finalArray = data.LargeFile();
                }
            }

            // Net_3 files
            else if (fileChoice == "3")
            {
                // reads text file
                if (largeFileChoice == "1")
                {
                    Net_3 data = new Net_3();
                    finalArray = data.SmallFile();
                }

                else if (largeFileChoice == "2")
                {
                    Net_3 data = new Net_3();
                    finalArray = data.LargeFile();
                }
            }











            // sorting algorithm choice between 

            Console.WriteLine("Bubble sort, Insertion sort, Quick sort. (1,2,3): ");
            String sortChoice = Console.ReadLine();

            if (sortChoice == "1")
            {
                SortingAlgorithms sorting = new SortingAlgorithms();
                sorting.Values = finalArray;
                sorting.Bubble();
            }

            else if (sortChoice == "2")
            {
                SortingAlgorithms sorting = new SortingAlgorithms();
                sorting.Values = finalArray;
                sorting.Insertion();
            }

            else if (sortChoice == "3")
            {
                // fix quick sort algorithm

                SortingAlgorithms sorting = new SortingAlgorithms();
                sorting.Values = finalArray;
                sorting.Quick(0, finalArray.Length-1);


            }



            // put in option for ascending order or descending order

            Console.WriteLine("Ascending or Decending? (1,2): ");
            String outputChoice = Console.ReadLine();

            if (outputChoice == "1")
            {
                if (largeFileChoice == "1")
                {
                    for (int i = 0; i < finalArray.Length; i += 10)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }

                else if (largeFileChoice == "2")
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
                Array.Reverse(finalArray);

                if (largeFileChoice == "1")
                {
                    for (int i = 0; i < finalArray.Length; i += 10)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }

                else if (largeFileChoice == "2")
                {
                    for (int i = 0; i < finalArray.Length; i += 50)
                    {
                        Console.WriteLine(finalArray[i]);
                    }
                }
                Array.Reverse(finalArray);
            }





            // asks user to find number inside list
            Console.WriteLine("What number do you want to find in this list: ");
            int targetNum = int.Parse(Console.ReadLine());

            // checks if number is inside the list
            if (!finalArray.Contains(targetNum))
            {
                // loops if number selected not in array
                Console.WriteLine("Not in Array");

                SearchingAlgorithms search = new SearchingAlgorithms();
                search.Values = finalArray;
                targetNum = search.NearestValue(targetNum);
                Console.WriteLine("Nearest number is: " + targetNum);
            }





            Console.WriteLine("Binary search, linear search. (1,2): ");
            String SearchChoice = Console.ReadLine();

            if (SearchChoice == "1")
            {
                SearchingAlgorithms search = new SearchingAlgorithms();
                search.Values = finalArray;
                search.Binary(targetNum);
            }

            else if (SearchChoice == "2")
            {
                SearchingAlgorithms search = new SearchingAlgorithms();
                search.Values = finalArray;
                search.Linear(targetNum);
            }




        }
    }
}
