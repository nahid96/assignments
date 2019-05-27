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
        List<string> customerNames = new List<string>();
        List<int> contactNo = new List<int>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<int> quantity = new List<int>();

        private string message = "";

        int count = 0;

        List<string> messages = new List<string>();

        public BookShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerNames.Add(customerNameTextBox.Text);
            contactNo.Add(Convert.ToInt32(ContactNoTextBox.Text));
            address.Add(AddressTextBox.Text);
            order.Add(OrderComboBox.Text);
            quantity.Add(Convert.ToInt32(QuantityTextBox.Text));

            int totalPrice = 0;

            if (order[count] == "Math")
            {
                totalPrice = 120;
            }
            else if (order[count] == "English")
            {
                totalPrice = 100;
            }
            else if (order[count] == "Bangla")
            {
                totalPrice = 90;
            }
            else if (order[count] == "Art")
            {
                totalPrice = 80;
            }

            message = message + "\nCustomer Name : " + customerNames[count] + "\n" +
                      "Contact No. " + contactNo[count] + "\n" +
                     "Address : " + address[count] + "\n" +
                     "Order : " + order[count] + "\n" +
                     "Quantity : " + quantity[count] + "\n" +
                      "Total Price : " + quantity[count] * totalPrice +
                      "\n\n";

            count++;

            customerNameTextBox.Text = string.Empty;
            ContactNoTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            OrderComboBox.Text = string.Empty;
            QuantityTextBox.Text = string.Empty;

            resulRtichTextBox.Text = "\t\tCustomers information - \n" + message;


        }
    }
}
