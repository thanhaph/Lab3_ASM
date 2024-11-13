using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM
{
    public class Bai3
    {
        public double TrungBinhCong (int [] tbc)
        {
            if (tbc == null || tbc.Length == 0)
            {
                throw new ArithmeticException("không được phép rỗng.");
            }

            return tbc.Average();
        }
    }
}
