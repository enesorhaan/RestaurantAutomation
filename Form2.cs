using RestaurantAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class Form2 : Form
    {
        public Form2(List<string> _orderListName,List<decimal> _orderListPrice,Form1 _form1)
        {
            InitializeComponent();
            orderListName = _orderListName;
            orderListPrice = _orderListPrice;
            form1 = _form1;
        }

        List<string> orderListName;
        List<decimal> orderListPrice;
        Form1 form1;
        decimal totalPrice;

        List<string> orderLastList = new List<string>();
        List<decimal> orderLastQty = new List<decimal>();

        public void ListDetail()
        {
            try
            {
                foreach (string orderName in orderListName)
                {
                    if (orderLastList.Contains(orderName))
                    {
                        int index = orderLastList.IndexOf(orderName);
                        orderLastQty[index] += 1;
                    }
                    else
                    {
                        orderLastQty.Add(1);
                        orderLastList.Add(orderName);
                    }
                }
                for (int i = 0; i < orderLastList.Count; i++)
                {
                    lbOrderSummary.Items.Add($"Order Name: {orderLastList[i]} - Qty: {orderLastQty[i]}");
                }

                totalPrice = CalculatePrice();
                lblTotalPrice.Text = $"{totalPrice} TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangePage()
        {
            rbCash.Checked = rbCreditCard.Checked = false;
            orderListName.Clear();
            orderLastQty.Clear();
            orderLastList.Clear();
            totalPrice = 0;
            lbOrderSummary.Items.Clear();
            this.Hide();
            form1.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangePage();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(rbCash.Checked == false && rbCreditCard.Checked == false)
            {
                MessageBox.Show("Please select the payment method!");
                return;
            }
            Sales sales = new Sales();
            if (rbCreditCard.Checked != true)
                sales.paymentMethod = "Cash";
            else
                sales.paymentMethod = "Credit Card";
            sales.totalPrice = totalPrice;
            MessageBox.Show(sales.ToString());
            ChangePage();
        }

        private decimal CalculatePrice()
        {
            foreach (decimal price in orderListPrice)
            {
                totalPrice += price;
            }
            return totalPrice;
        }
    }
}
