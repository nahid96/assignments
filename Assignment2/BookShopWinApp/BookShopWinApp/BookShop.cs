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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            int contactNo = Convert.ToInt32(contactNoTextBox.Text);
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            customerNameTextBox.Text = string.Empty;
            contactNoTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            orderComboBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;

            detailsRichTextBox.Text = "\tOrder Information" +
                                       "\t---------------------------"+
                                      "\n\nCustomer Name : " + customerName +
                                      "\nContact No. " + contactNo +
                                        "\nAddress : " + address +
                                        "\nOrder : " + order +
                                        "\nQuantity : " + quantity;
        }
    }
}
