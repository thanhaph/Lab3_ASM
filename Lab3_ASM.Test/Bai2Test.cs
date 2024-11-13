using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM.Test
{
    [TestFixture]
    public class Bai2Test
    {
        private Bai2 _b2;
        [SetUp]
        public void SetUp()
        {
            _b2 = new Bai2();
        }
        [Test]
        [TestCase(10, 2, 5)] 
        [TestCase(-10, -2, 5)] 
        [TestCase(10, -2, -5)] 
        [TestCase(-10, 2, -5)] 
        [TestCase(0, 5, 0)] 
        [TestCase(0, -5, 0)] 
        [TestCase(5, 1, 5)] 
        [TestCase(-5, -1, 5)] 
        [TestCase(int.MaxValue, 1, int.MaxValue)] 
        [TestCase(int.MinValue, -1, int.MaxValue)] 
        public void TinhChia(int a, int b, int expected)
        {
            var result = _b2.TinhThuong(a, b);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(5, 0)] 
        [TestCase(-5, 0)] 
        [TestCase(0, 0)] 
        public void TinhChia_ChiaChoKhong(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => _b2.TinhThuong(a, b));
        }
    }
}
