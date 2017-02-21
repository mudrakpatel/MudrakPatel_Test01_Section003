using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Test01_Ex01
{
    public partial class PizzaDeliveryForm : Form
    {
        public PizzaDeliveryForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                //clear all customer details
                userControl1.orderNumberTextBox.Clear();
                userControl1.nameTextBox.Clear();
                userControl1.addressTextBox.Clear();
                userControl1.contactTextBox.Clear();
                //Deselect all pizza shops
                pizzaShopComboBox.SelectedIndex = 0;
                //Deselect pizza sizes
                smallRadioButton.Checked = false;
                mediumRadioButton.Checked = false;
                largeRadioButton.Checked = false;
                //clear all checkboxes
                olivesCheckBox.Checked = false;
                capsicumCheckBox.Checked = false;
                onionsCheckBox.Checked = false;
                tomatoesCheckBox.Checked = false;
                pepperoniCheckBox.Checked = false;
                mushroomCheckBox.Checked = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "System error!");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void clearSummaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderSummaryTextBox.Clear();
                totalTextBox.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "System error!");
            }
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "System error!");
            }
        }

        //private void userControl11_Load(object sender, EventArgs e)
        //{

        //}
    }
}
