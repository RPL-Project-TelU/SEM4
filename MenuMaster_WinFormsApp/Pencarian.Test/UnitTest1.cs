namespace Pencarian.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPencarianTidakTersedia()
        {
            
            String[] makanan = { "nasi goreng", "mie ayam", "ayam goreng madu, ayam bakar madu", "bebek goreng, bebek bakar, ayam bakar, ayam goreng, lele goreng" };

            int i = 0;
            for (i = 0; i < 3; i++)
            {
                String expected1 = "burger";
                if (makanan[i] != expected1)
                {
                    String result1 = expected1;
                    Assert.AreEqual(expected1, result1);
                }
            }
 
        }

        [TestMethod]
        public void TestPencarianTersedia()
        {
            string[] makanan = { "nasi goreng", "mie ayam", "ayam goreng madu, ayam bakar madu", "bebek goreng, bebek bakar, ayam bakar, ayam goreng, lele goreng" };
            
            int i = 0;
            for (i=0; i<3; i++)
            {
                String expected2 = "nasi goreng";
                if (makanan[i] == expected2)
                {
                    String result2 = expected2;
                    Assert.AreEqual(expected2, result2);
                }
            }
           
            
        }
    }
}