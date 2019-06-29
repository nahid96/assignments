using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        private Refrigerator _refrigerator;

        public RefrigeratorUi()
        {
            InitializeComponent();

            _refrigerator = new Refrigerator();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _refrigerator.MaxWeight = Convert.ToInt32(maxWeightTakeTextBox.Text);

            maxWeightTakeTextBox.Text = string.Empty;
            
            maxWeightTakeTextBox.ReadOnly = true;

            MessageBox.Show("Saved!");

            currentWeightTextBox.Text = _refrigerator.CurrentWeight.ToString();
            remainingWeightTextBox.Text = _refrigerator.RemainingWeight.ToString();


        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int weight = (Convert.ToInt32(itemTextBox.Text) * Convert.ToInt32(weightTextBox.Text));
            
            _refrigerator.SetAddWeight = weight;

            bool flag = Convert.ToBoolean(_refrigerator.SetAddWeight);

            if (flag == true)
            {
                MessageBox.Show("Your given amount can’t be entered because it will be over flown.");
            }

            currentWeightTextBox.Text = _refrigerator.CurrentWeight.ToString();
            remainingWeightTextBox.Text = _refrigerator.RemainingWeight.ToString();
        }
    }
}
