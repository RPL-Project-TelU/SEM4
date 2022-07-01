using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestResty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public void TestMethod1()
        //{
        //    string[] arrString = { "String 1", "string 2", "string 3" };
        //    switch (arrString.Length)
        //    {
        //        case 1:
        //            if (itemsOrdered == 0)
        //            {
        //                MessageBox.Show("No items were ordered", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                tabControl1.SelectedIndex = 0;
        //            }
        //            else
        //            {
        //                double totalCost = 0;
        //                lstProducts.Items.Clear();
        //                for (int i = 0; i < numberOfProducts; i++)
        //                {
        //                    if (products[i].NumberOrdered != 0)
        //                    {
        //                        lstProducts.Items.Add(products[i].NumberOrdered.ToString() + " " + products[i].Deskripsi);
        //                        totalCost += products[i].Cost * products[i].NumberOrdered;

        //                    }
        //                }

        //                //lblTotalCost.Text = "Total Cost: $" + String.Format("{0:f2}", totalCost);
        //                lblTotalCost.Text = "Total Cost: $" + totalCost;
        //            }
        //            break;
        //        case 2:
        //            if (textOrderAddress.Text == "")
        //            {
        //                MessageBox.Show("No address was entered", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                tabControl1.SelectedIndex = 0;
        //                textOrderAddress.Focus();
        //            }
        //            else
        //            {
        //                string address = textOrderAddress.Text;
        //                txtMailingLabel.Text = address;
        //            }
        //            break;

        //    }

        //}

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