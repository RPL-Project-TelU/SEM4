using MenuMaster_WinFormsApp;

namespace FiturPencarianTest
{
    [TestClass]
    public class TestMencari
    {
        [TestMethod]
        public void pencarianTersedia()
        {
            // arrange
            String expected = "nasi goreng";

            // act
            String actual = Mencari.pencarian("nasi goreng");

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}