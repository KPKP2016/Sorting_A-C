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
    public class Net_2
    {
        // 256 files
        public int[] SmallFile()
        {
            // reads the file
            String[] lines = File.ReadAllLines("Net_2_256.txt");

            List<int> tempArray = new List<int>();

            foreach (string value in lines)
            {
                // converts from string to integer and stores it in array
                if (int.TryParse(value, out int number))
                {
                    // adds to array
                    tempArray.Add(number);
                }
            }

            int[] finalArray = tempArray.ToArray();
            return finalArray;

        }

        // 2048 files
        public int[] LargeFile()
        {
            // reads the file
            String[] lines = File.ReadAllLines("Net_2_2048.txt");

            List<int> tempArray = new List<int>();

            foreach (string value in lines)
            {
                // converts from string to integer and stores it in array
                if (int.TryParse(value, out int number))
                {
                    // adds to array
                    tempArray.Add(number);
                }
            }

            int[] finalArray = tempArray.ToArray();
            return finalArray;

        }
    }
}
