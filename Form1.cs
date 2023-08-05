using RestaurantAutomation.Helpers;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pitas> pitas;
        List<Beverages> beverages;
        List<Menus> menus;
        Sales sales = new Sales();
        DateTime currentDate = DateTime.Now;

        List<string> orderListName = new List<string>();
        List<int> orderListPrice = new List<int>();
        int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = currentDate.ToShortDateString();
            pitas = Helper.CreatePitas();
            beverages = Helper.CreateBeverages();
            menus = Helper.CreateMenus();
            ListControls();
        }

        private void ListControls()
        {
            pbFlakedCheese.Image = Image.FromFile(pitas[0].picturePath);
            pbMix.Image = Image.FromFile(pitas[1].picturePath);
            pbSausage.Image = Image.FromFile(pitas[2].picturePath);
            pbVegetables.Image = Image.FromFile(pitas[3].picturePath);
            lblFlakedPrice.Text = pitas[0].price.ToString() + " TL";
            lblMixPrice.Text = pitas[1].price.ToString() + " TL";
            lblSausagePrice.Text = pitas[2].price.ToString() + " TL";
            lblVegetablesPrice.Text = pitas[3].price.ToString() + " TL";
            updateTotalPrice();
            foreach (Menus menuName in menus)
            {
                cbMenus.Items.Add(menuName.menuName);
            }
            cbExtraBeverages.Items.Add(" ");
            foreach (Beverages beverageName in beverages)
            {
                cbExtraBeverages.Items.Add(beverageName.beverageName);
            }
        }

        private void rbSingle_Click(object sender, EventArgs e)
        {
            btnFlakedCheese.Visible = btnMix.Visible = btnSausage.Visible = btnVegetables.Visible = true;
            cbMenus.Text = " ";
            cbAnotherBeverage.Text = " ";
            cbMenus.Enabled = false;
            lblMnuCont.Visible = lblMnuPrc.Visible = lblMenuPrice.Visible = lblMenuContents.Visible = lblAnotherBeverage.Visible = lblMenuNewPrice.Visible = lblMnuNewPrc.Visible = cbAnotherBeverage.Visible = btnAddMenu.Visible = false;
            lblMenuContents.Text = " ";
            lblMenuPrice.Text = " ";
            lblMenuNewPrice.Text = " ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbAnotherBeverage.Items.Clear();
            btnFlakedCheese.Visible = btnMix.Visible = btnSausage.Visible = btnVegetables.Visible = false;
            cbMenus.Enabled = true;
            lblMnuCont.Visible = lblMnuPrc.Visible = lblMenuPrice.Visible = lblMenuContents.Visible = lblAnotherBeverage.Visible = lblMenuNewPrice.Visible = lblMnuNewPrc.Visible = cbAnotherBeverage.Visible = btnAddMenu.Visible = true;
        }

        private void cbMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAnotherBeverage.Items.Clear();
            cbAnotherBeverage.Items.Add(" ");
            lblMenuNewPrice.Text = " ";
            lblMenuNewPrice.Enabled = lblMnuNewPrc.Enabled = false;
            lblMnuPrc.Enabled = lblMenuPrice.Enabled = true;
            lblMenuContents.Text = menus[cbMenus.SelectedIndex].contents.ToString();
            lblMenuPrice.Text = menus[cbMenus.SelectedIndex].price.ToString() + " TL";
            MenusChanged();
        }

        private void cbAnotherBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnotherBeverage.SelectedIndex != 0)
            {
                lblMenuNewPrice.Enabled = lblMnuNewPrc.Enabled = true;
                lblMnuPrc.Enabled = lblMenuPrice.Enabled = false;
                lblMenuNewPrice.Text = (menus[cbMenus.SelectedIndex].anotherPrice).ToString() + $" TL (with {cbAnotherBeverage.Text})";
            }
            else
            {
                lblMenuNewPrice.Enabled = lblMnuNewPrc.Enabled = false;
                lblMnuPrc.Enabled = lblMenuPrice.Enabled = true;
                lblMenuNewPrice.Text = " ";
            }
        }

        private void MenusChanged()
        {
            if (cbMenus.SelectedIndex == 0)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (k == 0)
                        continue;
                    cbAnotherBeverage.Items.Add(beverages[k].beverageName);
                }
            }
            else if (cbMenus.SelectedIndex == 1)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (k == 1)
                        continue;
                    cbAnotherBeverage.Items.Add(beverages[k].beverageName);
                }
            }
            else if (cbMenus.SelectedIndex == 2)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (k == 2)
                        continue;
                    cbAnotherBeverage.Items.Add(beverages[k].beverageName);
                }
            }
            else if (cbMenus.SelectedIndex == 3)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (k == 3)
                        continue;
                    cbAnotherBeverage.Items.Add(beverages[k].beverageName);
                }
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            if (cbMenus.Text == "")
            {
                MessageBox.Show("Please select the menu!");
            }
            else
            {
                foreach (Menus menu in menus)
                {
                    if (cbMenus.Text == menu.menuName)
                    {
                        lbOrderContents.Items.Add(menu.menuName);
                        if (cbExtraBeverages.Text != " ")
                            sales.totalPrice += menu.price;
                        else
                            sales.totalPrice += menu.anotherPrice;
                        updateTotalPrice();
                    }
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(lbOrderContents.Items.Count == 0)
                MessageBox.Show("Add something to the order list");
            else
            {

            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lbOrderContents.Items.Clear();
            sales.totalPrice = 0;
            updateTotalPrice();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbOrderContents.CanSelect)
                lbOrderContents.Items.Remove(lbOrderContents.SelectedItem);
            else
                MessageBox.Show("Please select the content to delete!");
        }

        private void btnFlakedCheese_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            lbOrderContents.Items.Add(pitas[Convert.ToInt32(button.Tag)].pitaName);
            sales.totalPrice += pitas[Convert.ToInt32(button.Tag)].price;
            updateTotalPrice();
        }

        private void updateTotalPrice()
        {
            lblTotalPrice.Text = $"{sales.totalPrice} TL";
        }

        private void btnAddBeverage_Click(object sender, EventArgs e)
        {
            if(cbExtraBeverages.Text == "" || cbExtraBeverages.SelectedIndex == 0)
                MessageBox.Show("Please select the extra beverage!");
            else if(nmrQty.Value == 0)
                MessageBox.Show("Please select the Quantity!");
            else
            {
                lbOrderContents.Items.Add(cbExtraBeverages.Text);
                sales.totalPrice = beverages[cbExtraBeverages.SelectedIndex + 1].price * nmrQty.Value; 
                updateTotalPrice();
            }
        }

        private void btnDesert_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            lbOrderContents.Items.Add(button.Text);
            switch (button.Text)
            {
                case "Desert":
                    sales.totalPrice += 25;
                    break;
                case "Cheese":
                    sales.totalPrice += 5;
                    break;
                case "Sauce":
                    sales.totalPrice += 10;
                    break;
                case "CrispyEdge":
                    sales.totalPrice += 18;
                    break;
                default:
                    break;
            }
            updateTotalPrice();
        }
    }
}
