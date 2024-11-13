using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM
{
    public class Bai1
    {
        public double TinhTich (object a , object b)
        {
            if (!(a is int) || !(b is int))
            {
                throw new ArgumentException(" a và b phải là số nguyên.");
            }

            return (int)a * (int)b;
        }
    }
}
