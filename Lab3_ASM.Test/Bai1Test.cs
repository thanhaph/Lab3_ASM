namespace Lab3_ASM.Test
{
    [TestFixture]
    public class Tests
    {
        private Bai1 _b1;
        [SetUp]
        public void Setup()
        {
            _b1 = new Bai1();
        }

        [Test]
        [TestCase(3, 5, 15)] 
        [TestCase(-2, -4, 8)] 
        [TestCase(6, -7, -42)]
        [TestCase(10, 0, 0)]
        [TestCase(-3, 0, 0)] 
        [TestCase("abc", "def", 0)] 
        [TestCase(5, 3.14, 0)] 
        [TestCase(100000, 200000, 2000000000)] 
        [TestCase(-1, -1, 1)] 
        [TestCase(2147483647, 1, 2147483647)] 
        public void TinhTich(object a, object b, int expected)
        {
            if (a is string || b is string || a is double || b is double)
            {
                Assert.Throws<ArgumentException>(() => _b1.TinhTich(a, b));
            }
            else
            {
                var result = _b1.TinhTich(a, b);
                Assert.AreEqual(expected, result);
            }
        }
    }
}