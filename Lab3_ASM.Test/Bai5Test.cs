using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM.Test
{
    [TestFixture]
    public class Bai5Test
    {
        private Bai5 _b5;
        [SetUp]
        public void SetUp()
        {
            _b5 = new Bai5();
        }

        [Test]
        [TestCase("ha le", ExpectedResult = "ha le")]
        public string GetName_Tenbinhthuong(string name)
        {
            var profile = new UserProfile { Name = name };
            return _b5.GetName(profile);
        }

        [Test]
        [TestCase("   ", ExpectedResult = "   ")]
        public string GetName_Tencokhoangtrang(string name)
        {
            var profile = new UserProfile { Name = name };
            return _b5.GetName(profile);
        }

        [Test]
        [TestCase("!@#$%^&*()", ExpectedResult = "!@#$%^&*()")]
        public string GetName_Tencokytudacbiet(string name)
        {
            var profile = new UserProfile { Name = name }; 
            return _b5.GetName(profile);
        }

        [Test]
        [TestCase(1000, ExpectedResult = "aaaaaaaaaa...")] 
        public string GetNameTen1000kytu(int length)
        {
            var longName = new string('a', length); 
            var profile = new UserProfile { Name = longName };
            return _b5.GetName(profile);
        }

        [Test]
        [TestCase("", ExpectedResult = "")]
        public string GetName_Tennull(string name)
        {
            var profile = new UserProfile { Name = name };
            return _b5.GetName(profile);
        }

        [Test]
        [TestCase("12345", ExpectedResult = "12345")]
        public string GetName_Tenlaso(string name)
        {
            var profile = new UserProfile { Name = name }; 
            return _b5.GetName(profile);
        }

        [Test]
        [TestCase("haha 123!", ExpectedResult = "haha 123!")]
        public string GetName_Tencosovaktdb(string name)
        {
            var profile = new UserProfile { Name = name }; 
            return _b5.GetName(profile);
        }
    }
}
