using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaster_Keranjang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int itemsOrdered;
        const int numberOfProducts = 10;
        Product[] products = new Product[numberOfProducts];

        private void tabShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    if (itemsOrdered == 0)
                    {
                        MessageBox.Show("No items were ordered", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                    {
                        double totalCost = 0;
                        lstProducts.Items.Clear();
                        for (int i = 0; i < numberOfProducts; i++)
                        {
                            if (products[i].NumberOrdered != 0)
                            {
                                lstProducts.Items.Add(products[i].NumberOrdered.ToString() + " " + products[i].Deskripsi);
                                totalCost += products[i].Cost * products[i].NumberOrdered;

                            }
                        }

                        //lblTotalCost.Text = "Total Cost: $" + String.Format("{0:f2}", totalCost);
                        lblTotalCost.Text = "Total Cost: $" + totalCost;
                    }
                    break;
                case 2:
                    if (textOrderAddress.Text == "")
                    {
                        MessageBox.Show("No address was entered", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControl1.SelectedIndex = 0;
                        textOrderAddress.Focus();
                    }
                    else
                    {
                        string address = textOrderAddress.Text;
                        txtMailingLabel.Text = address;
                    }
                    break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products[0] = new Product("Orek Tempe", 1000);
            products[1] = new Product("Tahu Walik", 1000);
            products[2] = new Product("Milo", 1000);
            products[3] = new Product("Ayam", 1000);
            products[4] = new Product("Daging Sapi", 1000);
            products[5] = new Product("Ati Ampela", 1000);
            products[6] = new Product("Es Buah", 1000);
            products[7] = new Product("Bihun Goreng", 1000);
            products[8] = new Product("Es Kelapa", 1000);
            products[9] = new Product("Roti", 1000);

            for (int i = 0; i < 10; i++)
            {
                dudProducts.Items.Add(products[i].Deskripsi);
            }

            dudProducts.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            textOrderAddress.Text = "";
            itemsOrdered = 0;
            lblItemsOrdered.Text = "Items Ordered: 0";
            //int totalCost = 0;

            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i].NumberOrdered = 0;
            }

            dudProducts.SelectedIndex = 0;
            lstProducts.Items.Clear();
            //lblTotalCost.Text = "Total Cost : ";
            txtMailingLabel.Text = "";
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            products[dudProducts.SelectedIndex].NumberOrdered++;
            itemsOrdered++;
            lblItemsOrdered.Text = "Items Ordered: " + itemsOrdered.ToString();
            lblTotalCost.Text = "Total Cost Belanja: " + itemsOrdered * 1000;
            //textOrderAddress.Text = "";
            //itemsOrdered = 0;
            //lblItemsOrdered.Text = "Items Ordered: 0";
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void dudProducts_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void textOrderAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
