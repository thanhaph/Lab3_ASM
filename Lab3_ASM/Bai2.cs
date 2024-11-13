using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM
{
    public class Bai2
    { 
            public int TinhThuong(int a, int b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("không thể chia cho 0");
                }

                return a / b;
            }
    }
}
