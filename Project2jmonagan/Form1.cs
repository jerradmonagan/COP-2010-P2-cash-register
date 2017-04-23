using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2jmonagan
{
    //Jerrad Monagan
    //COP2010
    //Project2
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//end form 1
        double dblDiscount = 0;
        double dblPrice = 0;
        double dblItemPrice = 0;
        double dblItem = 0;
        double dblFinalPrice = 0;
        double dblSubTotal = 0;
        double dblTaxes = 0;
        double dblTotal = 0;
        double dblTAX = .07;
        int intDiscountID = 0;


        private void btnPizza_Click(object sender, EventArgs e)
        {
                DiscountCheck();
                double dblItemPrice = 10;
                CalculateTotalItem(dblItemPrice);
                CalculateSubTotal(dblFinalPrice);
                CalculateTaxes(dblSubTotal);
                CalculateTotal(dblSubTotal);
                lstDisplay.Items.Add(string.Format("{0,-30}{1,30:C}", "Pizza ", dblFinalPrice));
        }//end pizza methos

        private void btnHotDogs_Click(object sender, EventArgs e)
        {
                DiscountCheck();
                double dblItemPrice = 4.50;
                CalculateTotalItem(dblItemPrice);
                CalculateSubTotal(dblFinalPrice);
                CalculateTaxes(dblSubTotal);
                CalculateTotal(dblSubTotal);
                lstDisplay.Items.Add(string.Format("{0,-30}{1,27:C}", "Hot Dogs", dblFinalPrice)); ;
        }//end hotdog method

        private void btnMacCheese_Click(object sender, EventArgs e)
        {
                DiscountCheck();
                double dblItemPrice = 3.50;
                CalculateTotalItem(dblItemPrice);
                CalculateSubTotal(dblFinalPrice);
                CalculateTaxes(dblSubTotal);
                CalculateTotal(dblSubTotal);
                lstDisplay.Items.Add(string.Format("{0,-30}{1,21:C}", "Mac and Cheese ", dblFinalPrice));
                CalculateSubTotal(dblFinalPrice);
        }//end mac and cheese method

        private void btnFries_Click(object sender, EventArgs e)
        {
                DiscountCheck();
                double dblItemPrice = 1.50;
                CalculateTotalItem(dblItemPrice);
                CalculateSubTotal(dblFinalPrice);
                CalculateTaxes(dblSubTotal);
                CalculateTotal(dblSubTotal);
            lstDisplay.Items.Add(string.Format("{0,-30}{1,32:C}", "Fries ", dblFinalPrice));
        }//end fries method

        private void btnHamburg_Click(object sender, EventArgs e)
        {
                DiscountCheck();
                double dblItemPrice = 5.00;
                CalculateTotalItem(dblItemPrice);
                CalculateSubTotal(dblFinalPrice);
                CalculateTaxes(dblSubTotal);
                CalculateTotal(dblSubTotal);
                lstDisplay.Items.Add(string.Format("{0,-30}{1,26:C}", "Hamburger ", dblFinalPrice));
        }//end hamburger methos

        private void btnPie_Click(object sender, EventArgs e)
        {
                DiscountCheck();
                double dblItemPrice = 2.25;
                CalculateTotalItem(dblItemPrice);
                CalculateSubTotal(dblFinalPrice);
                CalculateTaxes(dblSubTotal);
                CalculateTotal(dblSubTotal);
                lstDisplay.Items.Add(string.Format("{0,-30}{1,28:C}","Apple Pie ", dblFinalPrice));
        }//end pie methos

        private void rBtnMilitary_CheckedChanged(object sender, EventArgs e)
        {
           // sets discount to 15% for military members
            intDiscountID = 4;
        }//end Military method

        private void rBtnSenior_CheckedChanged(object sender, EventArgs e)
        {
            //sets discount to 10% for seiors
            intDiscountID = 3;
        }//end Senior method

        private void rbtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            //sets discount to 5% for students
            intDiscountID = 2;
        }//end student methos

        private void rBtnNoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            //sets discount to 0 for everyone else
            intDiscountID = 1;
        }//end NoDiscount method
        private void DiscountCheck()
            //loop checks discount 
        {
            if (intDiscountID == 4)
                dblDiscount = .15;
            else if (intDiscountID == 3)
                dblDiscount = .10;
            else if (intDiscountID == 2)
                dblDiscount = .05;
            else
                dblDiscount = 0;
           
        }//end dicsount check method

        private void comboBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDrinks.SelectedIndex)
            {
                case 0:
                    lstDisplay.Items.Add(string.Format("{0,-30}{1,30:C}", "Coke",0));
                    break;
                case 1:
                    lstDisplay.Items.Add(string.Format("{0,-27}{1,31:C}", "Diet Coke",0));
                    break;
                case 2:
                    lstDisplay.Items.Add(string.Format("{0,-30}{1,31:C}", "Pepsi",0));
                    break;
                case 3:
                    lstDisplay.Items.Add(string.Format("{0,-30}{1,31:C}", "Tea",0));
                    break;
                case 4:
                    lstDisplay.Items.Add(string.Format("{0,-27}{1,30:C}", "Dr. Pepper",0));
                    break;
            }//end switch
        }//end drink method

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears al the text boxes and resets values to start over
            lstDisplay.Items.Clear();
            txtSubTotal.Clear();
            dblSubTotal = 0;
            txtTaxes.Clear();
            dblTaxes = 0;
            txtTotal.Clear();
            dblTotal = 0;
        }//end clear method

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exits the program
            this.Close();
        }//end exit method
        private Double CalculateTotalItem(double dblItemPrice)
            //calculates the discounted price
        {
            dblFinalPrice = dblItemPrice - (dblItemPrice * dblDiscount);
            return dblFinalPrice;
        }//end calculate total items method
       private double CalculateSubTotal(double dblFinalPrice)
            //calculates the subtotal and diplays in subtotal textbox
        {
            dblSubTotal = (dblSubTotal + dblFinalPrice);
           txtSubTotal.Text = dblSubTotal.ToString("C");
            return dblSubTotal;
        }//end calculatesubtotal method
        private double CalculateTaxes(double dblSubTotal)
            //calculates the taxes and diplays them in the taxes text box
        {
            dblTaxes = (dblSubTotal*dblTAX);
            txtTaxes.Text = dblTaxes.ToString("C");
            return dblTaxes;
        }//end calculate taxes method 
        private double CalculateTotal(double dblSubTotal)
            //calculates the final total with taxes included and displays in the total text box
        {
            dblTotal = dblSubTotal + dblTaxes;
            txtTotal.Text = dblTotal.ToString("C");
            return dblTotal;
        }// end calculate total methos
    }//end class
}//end namespace
