using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Tip_Calculator
{
    public partial class Form1 : Form
    {
        public String bill, tip, total,no_of_people,tip_total;
        public Boolean totalError;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {

        }
        private void calcTipBtn_Click(object sender, EventArgs e)
        {
            totalError = false;
            //assign variables
            setBill(txtBill.Text);
            setTip(txttip.Text);
            setno_of_people(NoofPeople.Text);
            //calls the calcTipTotal method to run the tip paid by per person
            calcTipTotal(getBill(), getTip(), getno_of_people());
            if (totalError == false)
            {
                txttipperperson.Text = getTiptotal();
            }
            else
            {
                txttipperperson.Text = "Error";
            }

        }


        private void calcBtn_click(object sender, EventArgs e)
        {
            totalError = false;
            //assign variables
            setBill(txtBill.Text);
            setTip(txttip.Text);
            //Calls the CalcTotal Method to run the calculator for the total
            calcTotal(getBill(), getTip(),getno_of_people());
          
            if (totalError == false)
            {
                txtTotal.Text = getTotal();
            }
            else
            {
                txtTotal.Text = "Error";
            }
        }

        public String getBill()
        {
            return (bill);
        }
        public void setBill(String bill)
        {
            this.bill = bill;
        }
        public String getno_of_people()
        {
            return (no_of_people);
        }
        public void setno_of_people(String no_of_people)
        {
            this.no_of_people = no_of_people;
        }
        public String getTip()
        {
            return (tip);
        }
        public void setTip(String tip)
        {
            this.tip = tip;
        }
        public String getTotal()
        {
            return (total);
        }
        public void setTiptotal(String tip_total)
        {
            this.tip_total = tip_total;
        }
        public String getTiptotal()
        {
            return (tip_total);
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_Click_1(object sender, EventArgs e)
        {

        }

        private void txttipperperson_Click(object sender, EventArgs e)
        {

        }

        public void setTotal(String total)
        {
            this.total = total;
        }
        public void calcTipTotal(String bill, String tip, String no_of_people)
        {
            //convert variable
            Double billDouble = 0;
            Double tipDouble = 0;
            Double noOfPeople = 0;
            //attempt to convert variable "bill" from string to doublle if user input is valid
            try
            {
                noOfPeople = Convert.ToDouble(no_of_people);
                billDouble = Convert.ToDouble(bill);
                totalError = false;
                try
                {
                    tipDouble = Convert.ToDouble(tip) / 100;
                    
                    Double tipperperson = Math.Round(((billDouble * tipDouble)/noOfPeople), 2, MidpointRounding.ToEven);
                    setTiptotal(tipperperson.ToString());
                    errorMessage.Text = "";

                }
                catch (Exception e)
                {
                    if (totalError == false)
                    {
                        errorMessage.Text = "ERROR FOUND ";
                        totalError = true;
                    }
                    else
                    {
                        errorMessage.Text = "Error Found";
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage.Text = "Error found";
               
            }
        }

   
   
        public void calcTotal(String bill, String tip,String no_of_people)
        {
            //convert variable
            Double billDouble = 0;
            Double tipDouble = 0;
            Double noOfPeople = 0;
            //attempt to convert variable "bill" from string to doublle if user input is valid
            try
            {
                billDouble = Convert.ToDouble(bill);
                noOfPeople = Convert.ToDouble(no_of_people);
                billDouble = billDouble / noOfPeople;

                totalError = false;
                try
                {
                    tipDouble = Convert.ToDouble(tip) / 100;
                    //calculates the total based on the bill and tip percentage and then rounds the value upto the last 2 decimal places.
                    Double total = Math.Round(((billDouble * tipDouble) + billDouble), 2, MidpointRounding.ToEven);
                    setTotal(total.ToString());
                    errorMessage.Text = "";

                }
                catch (Exception)
                {
                    if (totalError == false)
                    {
                        errorMessage.Text = "ERROR FOUND ";
                        totalError = true;
                    }
                    else
                    {
                        errorMessage.Text = "Error Found";
                    }
                }
            }
            catch (Exception)
            {
                errorMessage.Text = "Error found";
            }
        }


    }

}


