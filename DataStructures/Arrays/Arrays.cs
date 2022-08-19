using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class Arrays
    {
        public void Run()
        {
            int[] values = new int[10] { 7, 2, 3, 7, 9, 7, 4, 7, 1, 8 };
            int[] copy = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == 7)
                {
                    //values = values.Where((valor, index) => index != i).ToArray();
                    values[i] = (values.Length - values.Length);
                    values[i] = values[i - 1];//erro
                }
                else
                {
                    copy[i] = values[i];
                }
            }

            Console.ReadKey();
        }
    }
}
