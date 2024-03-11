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

            Console.WriteLine("Please select a file. (1,2,3): ");

            // ask for 256 or 2048

            String fileChoice = Console.ReadLine();

            List<int> tempArray = new List<int>();

            // put in new options for other text files
            if (fileChoice == "1")
            {
                // reads text file
                String[] lines = File.ReadAllLines("Net_1_256.txt");

                foreach (string value in lines)
                {
                    // converts from string to integer and stores it in array
                    if (int.TryParse(value, out int number))
                    {
                        tempArray.Add(number);
                    }
                }

                int[] finalArray = tempArray.ToArray();

                // put in option for ascending order or descending order
                Array.Sort(finalArray);

                for (int i = 0; i < finalArray.Length; i += 10)
                {
                    Console.WriteLine(finalArray[i]);
                }


            }








                /*
                            // empty array created to store numbers from text file.
                            int[] completeArray = { };
                            List<int> tempArray = new List<int>(completeArray);

                            string data;
                            StreamReader reader = null;

                            // reads file
                            reader = new StreamReader("Net_1_256.txt");
                            data = reader.ReadLine();
                                        if (data == null)
                                        {
                                            foreach (int value in tempArray)
                                            {
                                                Console.WriteLine(value);
                                            }
                                        }

                            // runs through each number printing it until there is no more left.
                            while (data!= null)
                            {
                                Console.WriteLine(data);
                                data = reader.ReadLine();

                                // converts from string to integer
                                tempArray.Add(int.Parse(data));

                            }
                            reader.Close();*/


            }
    }
}
