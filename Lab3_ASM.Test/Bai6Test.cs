using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM.Test
{
    [TestFixture]
    public class Bai6Test
    {
        private Bai6 _b6;
        [SetUp]
        public void SetUp()
        {
            _b6 = new Bai6();
        }
        [Test]
        public void MangRong()
        {
            var ex = Assert.Throws<ArgumentException>(() => _b6.PhantuMin(new int[] { }));
            Assert.That(ex.Message, Is.EqualTo("Mảng không được phép rỗng."));
        }


        [Test]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, -2, -3 }, ExpectedResult = -3)]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 2, -1 }, ExpectedResult = -1)]
        [TestCase(new int[] { 10, 20, 30 }, ExpectedResult = 10)]
        [TestCase(new int[] { 5, 3, 8, 1, 4 }, ExpectedResult = 1)]
        [TestCase(new int[] { -5, -10, -15, -20, -25 }, ExpectedResult = -25)]
        [TestCase(new int[] { int.MaxValue, int.MaxValue }, ExpectedResult = int.MaxValue)]
        [TestCase(new int[] { int.MinValue, int.MaxValue }, ExpectedResult = int.MinValue)]
        [TestCase(new int[] { 100, 200, 300 }, ExpectedResult = 100)]
        public int FindMin_ValidArray_ReturnsCorrectMin(int[] array)
        {
            return _b6.PhantuMin(array);
        }

        [Test]
        public void Mang1phantu()
        {
            var result = _b6.PhantuMin(new int[] { 42 });
            Assert.AreEqual(42, result);
        }

        [Test]
        public void Mangcophantuam()
        {
            var result = _b6.PhantuMin(new int[] { -1, 2, 3, 4 });
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Mangtoansoam()
        {
            var result = _b6.PhantuMin(new int[] { -1, -2, -3, -4 });
            Assert.AreEqual(-4, result);
        }

        [Test]
        public void Mangco2phantubangnhau()
        {
            var result = _b6.PhantuMin(new int[] { 1, 2, 1, 3 });
            Assert.AreEqual(1, result);
        }
    }
}
