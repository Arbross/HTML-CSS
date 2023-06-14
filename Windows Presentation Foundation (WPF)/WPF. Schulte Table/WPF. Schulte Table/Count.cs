using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF._Schulte_Table
{
    public class Count
    {
        public int GetNumbers(string last_index, string current_index)
        {
            if (last_index == null && current_index == "1")
            {
                return 0;
            }
            int last_tmp = int.Parse(last_index);
            int current_tmp = int.Parse(current_index);
            if (current_tmp == (last_tmp + 1))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public static int[] FillRand()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Random random = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                int _tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = _tmp;
            }
            return arr;
        }
    }
}
