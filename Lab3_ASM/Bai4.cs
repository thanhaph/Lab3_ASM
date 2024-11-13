using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM
{
    public class Bai4
    {
        public T GetElementAtIndex<T>(T[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Mảng không được phép null.");
            }

            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Chỉ mục nằm ngoài phạm vi của mảng.");
            }

            return array[index];
        }
    }
}
