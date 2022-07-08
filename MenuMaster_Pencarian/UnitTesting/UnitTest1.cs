using Microsoft.VisualStudio.TestTools.UnitTesting;
using MenuMaster_Pencarian;
namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTersedia()
        {
            Assert.IsFalse(MenuMaster_WinFormsApp.pencarianController.getTersedia());
        }
    }
}