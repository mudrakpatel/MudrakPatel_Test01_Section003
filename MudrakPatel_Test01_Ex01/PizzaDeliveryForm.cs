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

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void clearSummaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderSummaryTextBox.Clear();
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
    }
}
