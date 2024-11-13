using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM
{
    public class Bai6
    {
        public int PhantuMin(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Mảng không được phép rỗng.");
            }

            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
