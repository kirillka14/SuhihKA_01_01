using NUnit.Framework;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
            
        }
        
        [Test]
        public void Test1 ()
        {
            double calorii = 1.5;
            double ygly = 4;

            Assert.Pass();
        }
        [Test]
        public void Test2 ()
        {
            double calorii = 5;
            double ygly = 2;

            Assert.Pass();
        }
        [Test]
        public void Test3 ()
        {
            double calorii = 7.5;
            double ygly = 2.3;

            Assert.Pass();
        }
        [Test]
        public void Test4 ()
        {
            double calorii = 2.5;
            double ygly = 2;

            Assert.Pass();
        }
    }
}