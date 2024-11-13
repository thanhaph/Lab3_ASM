using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM.Test
{
    [TestFixture]
    public class Bai3Test
    {
        private Bai3 _b3;
        [SetUp]
        public void SetUp()
        {
            _b3 = new Bai3();
        }
        [Test]
        [TestCase(new int[] { })] 
        public void TrungBinhCong_EmptyArray_ThrowsArithmeticException(int[] tbc)
        {
            var ex = Assert.Throws<ArithmeticException>(() => _b3.TrungBinhCong(tbc));
            Assert.That(ex.Message, Is.EqualTo("không được phép rỗng."));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 2.0)] 
        [TestCase(new int[] { -1, -2, -3 }, -2.0)] 
        [TestCase(new int[] { 0, 0, 0 }, 0.0)] 
        [TestCase(new int[] { 1, 2, -1 }, 0.6666666666666666)] 
        [TestCase(new int[] { 10, 20, 30 }, 20.0)] 
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3.0)] 
        [TestCase(new int[] { 100, 200, 300 }, 200.0)] 
        [TestCase(new int[] { -5, -10, -15, -20, -25 }, -15.0)] 
        [TestCase(new int[] { int.MaxValue, int.MaxValue }, 2147483647.0)] 
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1.0)] 
        public void TrungBinhCong_ValidArray_ReturnsCorrectAverage(int[] tbc, double expected)
        {
            var result = _b3.TrungBinhCong(tbc);
            Assert.AreEqual(expected, result);
        }
    }
}
