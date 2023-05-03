using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class SortedArray
    {
        public static void Sort(int[] array, bool isAsk = true)
        {
            int[] tempArray = new int[array.Length];
            array.CopyTo(tempArray, 0);
            
            if(isAsk) 
            {
                tempArray = tempArray.OrderBy(x => x).ToArray();
            }
            else
            {
                tempArray = tempArray.OrderByDescending(x => x).ToArray();
            }

            tempArray.CopyTo(array, 0);
        }
    }
}
