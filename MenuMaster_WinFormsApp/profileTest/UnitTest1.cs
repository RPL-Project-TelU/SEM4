
namespace profileTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            
            using (var sw = new StringWriter())
            {

                string nama = "testNama";
                string username = "testUsername";
                string password = "testPassword";
                string email = "testEmail";
                string handphone = "testHandphone";
                string alamat = "testAlamat";

                string Expected = "testNama testUsername testPassword testEmail testHandphone testAlamat";
                string result = nama + " " + username + " " + password + " " + email + " " + handphone + " " + alamat;
                 
                Assert.AreEqual(Expected, result);
            }
        }

    }
}