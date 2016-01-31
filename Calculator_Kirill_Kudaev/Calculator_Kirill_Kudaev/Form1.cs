// Student: Kirill Kudaev
// College: Principia College
// Class:   220: Programming Languages
// Teacher: John Broere
// Date:    Oct/28/2015 
// Description: Calculator with basic functionality. Gives the result 0 if user divides by 0.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Kirill_Kudaev
{
    public partial class Form1 : Form
    {
        Double value = 0;       // to store decimal places
        String operation = "";  // to store the operation that user chose
        bool operation_pressed = false; // to store if the operator was pressed
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // for buttons 0 to 9 
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))    // in case we have 0 in our text field
                result.Clear();         // clear the textf ield

            Button b = (Button)sender;  //"convert" our object to the button
            result.Text = result.Text + b.Text; //append the number we pressed to our text field

            operation_pressed = false;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;  //"convert" our object to the button
            operation = b.Text; //storing the operator user clicked
            value = Double.Parse(result.Text); // converting the value that is in our texfield into double and storing it
            operation_pressed = true;     
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {   
                case "+":   // for addition
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":   // for subtraction
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":   // for multiplication
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":   // for division
                    if (result.Text == "0") // in case user wants do divide by 0 print out 0
                        result.Text = "0";
                    else
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch 
            operation_pressed = false;    // change flag back to false
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();     // clear the result
            value = 0;          // set value to 0
        }
    }
}
