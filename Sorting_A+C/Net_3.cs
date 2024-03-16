﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting_A_C
{
    public class Net_3
    {

        public int[] SmallFile()
        {
            String[] lines = File.ReadAllLines("Net_3_256.txt");

            List<int> tempArray = new List<int>();

            foreach (string value in lines)
            {
                // converts from string to integer and stores it in array
                if (int.TryParse(value, out int number))
                {
                    tempArray.Add(number);
                }
            }

            int[] finalArray = tempArray.ToArray();
            return finalArray;

        }

        public int[] LargeFile()
        {
            String[] lines = File.ReadAllLines("Net_3_2048.txt");

            List<int> tempArray = new List<int>();

            foreach (string value in lines)
            {
                // converts from string to integer and stores it in array
                if (int.TryParse(value, out int number))
                {
                    tempArray.Add(number);
                }
            }

            int[] finalArray = tempArray.ToArray();

            return finalArray;

        }
    }
}
