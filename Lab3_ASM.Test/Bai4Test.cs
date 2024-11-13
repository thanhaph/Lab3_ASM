using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM.Test
{
    [TestFixture]
    public class Bai4Test
    {
        private Bai4 _b4;
        [SetUp]
        public void SetUp()
        {
            _b4 = new Bai4();
        }
        [Test]
        public void GetElementAtIndex_NullArray_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _b4.GetElementAtIndex(new int[] { }, 0));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, -1)] 
        [TestCase(new int[] { 1, 2, 3 }, 3)] 
        [TestCase(new int[] { 10, 20, 30 }, -5)] 
        [TestCase(new int[] { 10, 20, 30 }, 5)] 
        
        public void GetElementAtIndex_IndexOutOfRange_ThrowsIndexOutOfRangeException(int[] array, int index)
        {
            var ex = Assert.Throws<IndexOutOfRangeException>(() => _b4.GetElementAtIndex(array, index));
            Assert.That(ex.Message, Is.EqualTo("Chỉ mục nằm ngoài phạm vi của mảng."));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 0, 1)] 
        [TestCase(new int[] { 1, 2, 3 }, 1, 2)] 
        [TestCase(new int[] { 1, 2, 3 }, 2, 3)] 
       
        public void GetElementAtIndex_ValidIndex_ReturnsCorrectElement(int[] array, int index, int expected)
        {
            var result = _b4.GetElementAtIndex(array, index);
            Assert.AreEqual(expected, result);
        }
    }
}
