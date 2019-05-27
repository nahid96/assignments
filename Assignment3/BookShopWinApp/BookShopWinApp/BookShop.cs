using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinApp
{
    public partial class BookShop : Form
    {
        public BookShop()
        {
            InitializeComponent();
        }

        string customerDetails = "";

        int customerNo = 1;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int size = 10;

            string[] customerName = new string[size];

            int[] contactNo = new int[size];

            string[] Address = new string[size];

            string[] Order = new string[size];

            int[] Quantity = new int[size];

            int count = 0;

            customerName[count] = customerNameTextBox.Text;
            contactNo[count] = Convert.ToInt32(ContactNoTextBox.Text);
            Address[count] = AddressTextBox.Text;
            Order[count] = OrderComboBox.Text;
            Quantity[count] = Convert.ToInt32(QuantityTextBox.Text);

            count++;

            string customerInformation = "Customer Information\n\n";

            for (int index = 0; index < count; index++)
            {
                int price = 0;

                if (Order[index] == "Math")
                {
                    price = 120;
                }
                else if (Order[index] == "English")
                {
                    price = 100;
                }
                else if (Order[index] == "Bangla")
                {
                    price = 90;
                }
                else if (Order[index] == "Art")
                {
                    price = 80;
                }

                resulRtichTextBox.Text = customerDetails + "\n" + customerNo + " " + customerInformation + "Customer Name :" + customerName[index] + "\nContact No. " + contactNo[index].ToString() + 
                "\nAdderss : " +Address[index] + "\nOrder : " + Order[index] + "\nQuantity : " +Quantity[index].ToString() +
                    "\nTotal Price : " + price * Quantity[index] + "\n";

                customerDetails = resulRtichTextBox.Text;

                customerNo++;

            }

            customerNameTextBox.Text = string.Empty;
            ContactNoTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            OrderComboBox.Text = string.Empty;
            QuantityTextBox.Text = string.Empty;
        }
    }
}
