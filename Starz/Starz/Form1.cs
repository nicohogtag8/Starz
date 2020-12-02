using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//WRITTEN BY NICOLAS HOUGHTALING

namespace Starz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            List<string> Errors = new List<string>();
            string Product = ProductComboBox.Text; //allowing for your apple and orange, but whatever else you'd like
            double Price = 0;
            int Basket = 0;
            double Promotion = 0;

            //Parse price, look for errors
            if(!double.TryParse(PriceTextBox.Text.Replace("$", ""), out Price))//pull off dollar sign people sometimes like to enter
            {
                Errors.Add("Invalid price entered; please enter a decimal.");
            }

            //Parse basket qty, look for errors
            if (!int.TryParse(BasketTextBox.Text, out Basket))
            {
                Errors.Add("Invalid number entered for basket quantity; please enter a whole number.");
            }

            //requirements they want to enter the string "No", so lets let them. 'No' = 0
            if (PromotionTextBox.Text.ToLower().Trim() == "no")
            {
                //already equals zero
                //Promotion = 0; 
            }
            else //try to parse out decimal
            {
                if (!double.TryParse(PromotionTextBox.Text, out Promotion))//pull off dollar sign people sometimes like to enter
                {
                    Errors.Add("Invalid promotion value entered; please enter a decimal or No.");
                }
            }

            //check if errors exist and report them to the user
            if(Errors.Count > 0)
            {
                MessageBox.Show(string.Join("\r\n", Errors));
            }
            else//Add new shopping line
            {
                int sRowID = ShoppingCartGridView.Rows.Add();//create new row
                DataGridViewRow sRow = ShoppingCartGridView.Rows[sRowID];
                sRow.Cells["Product"].Value = Product;
                sRow.Cells["Price"].Value = Price;
                sRow.Cells["Basket"].Value = Basket;
                sRow.Cells["Promotion"].Value = Promotion;

                //reset text - personal preference
                PriceTextBox.Text = "";
                BasketTextBox.Text = "";
                PromotionTextBox.Text = "";
            }

            //after your new line is added, calculate your new price
            CalculateShoppingCart();
        }

        public void CalculateShoppingCart()
        {
            double TotalCartCost = 0;
            try
            {
                //cast your rows into a List/IEnumerable so you can use LINQ for simple math
                TotalCartCost = ShoppingCartGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(x => x.Cells["Price"].Value != null)//no using the empty rows
                    .Sum(x => (double.Parse(x.Cells["Price"].Value.ToString()) * double.Parse(x.Cells["Basket"].Value.ToString())) * (1 - double.Parse(x.Cells["Promotion"].Value.ToString())));
                TotalLabel.Text = "Total: $" + TotalCartCost.ToString("N2");
            }catch(Exception ex)
            {
                MessageBox.Show("Shopping cart failed to calculate.");
            }
        }

        private void ShoppingCartGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //when a user deletes a row from their shopping cart, recalculate the price
            CalculateShoppingCart();
        }
    }
}
