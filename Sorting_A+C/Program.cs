using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_A_C
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] completeArray = { };
            List<int> tempArray = new List<int>(completeArray);

            string data;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("C:\\Users\\KPate\\OneDrive\\Documents\\C_Sharp\\Sorting_A+C\\Net_1_256.txt");
                data = reader.ReadLine();

                while (data!= null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                    tempArray.Add(int.Parse(data));

                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
            }

            
        }
    }
}
