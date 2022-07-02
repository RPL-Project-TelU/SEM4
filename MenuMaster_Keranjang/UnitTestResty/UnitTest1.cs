using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestResty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDomainUpDown()
        {
            int x = 0;
            string[] products = { "Orek Tempe", "Tahu Walik", "Milo", "Ayam", "Daging Sapi", 
                "Ati Ampela", "Es Buah", "Bihun Goreng", "Es Kelapa", "Roti"};
            

            for (int i = 0; i < 10; i++)
            {
                x++;
            }

            Assert.AreEqual(x, products.Length);
        }
    }

    
}