using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    com.dneonline.www.Calculator myWS = new com.dneonline.www.Calculator();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected Boolean notEmptyFields(string fieldNumberA, string fieldNumberB)
    {
        if (string.Equals(fieldNumberA, "") && string.Equals(fieldNumberB, ""))
        {
            InputNumberA.BorderColor = System.Drawing.Color.Red;
            InputNumberB.BorderColor = System.Drawing.Color.Red;
            theResultLabel.Text = "";
            return false;
        }else if (string.Equals(fieldNumberA, ""))
        {
            InputNumberA.BorderColor = System.Drawing.Color.Red;
            InputNumberB.BorderColor = System.Drawing.Color.Black;
            theResultLabel.Text = "";
            return false;
        }else if (string.Equals(fieldNumberB, ""))
        {
            InputNumberB.BorderColor = System.Drawing.Color.Red;
            InputNumberA.BorderColor = System.Drawing.Color.Black;
            theResultLabel.Text = "";
            return false;
        }else
        {
            InputNumberA.BorderColor = System.Drawing.Color.Black;
            InputNumberB.BorderColor = System.Drawing.Color.Black;
            return true;
        }
    }

    protected void addButton_Click(object sender, ImageClickEventArgs e)
    {
        if (notEmptyFields(InputNumberA.Text, InputNumberB.Text))
        {
            int numberA, numberB;

            numberA = Convert.ToInt32(InputNumberA.Text);
            numberB = Convert.ToInt32(InputNumberB.Text);

            theResultLabel.Text = Convert.ToString(myWS.Add(numberA, numberB));
        }
    }

    protected void multiplicationButton_Click(object sender, ImageClickEventArgs e)
    {
        if (notEmptyFields(InputNumberA.Text, InputNumberB.Text))
        {
            int numberA, numberB;

            numberA = Convert.ToInt32(InputNumberA.Text);
            numberB = Convert.ToInt32(InputNumberB.Text);

            theResultLabel.Text = Convert.ToString(myWS.Multiply(numberA, numberB));
        }
    }

    protected void divisionButton_Click(object sender, ImageClickEventArgs e)
    {
        if (notEmptyFields(InputNumberA.Text, InputNumberB.Text))
        {
            double numberA, numberB;

            numberA = Convert.ToDouble(InputNumberA.Text);
            numberB = Convert.ToDouble(InputNumberB.Text);

            if (numberB != 0)
            {
                double result = numberA / numberB;
                theResultLabel.Text = Convert.ToString(result);
            }
            else
            {
                theResultLabel.Text = "The denominator with 0 in the denominator cannot be set";
            }
        }
    }

    protected void subtractionButton_Click(object sender, ImageClickEventArgs e)
    {
        if (notEmptyFields(InputNumberA.Text, InputNumberB.Text))
        {
            int numberA, numberB;

            numberA = Convert.ToInt32(InputNumberA.Text);
            numberB = Convert.ToInt32(InputNumberB.Text);

            theResultLabel.Text = Convert.ToString(myWS.Subtract(numberA, numberB));
        }
    }

    protected void resetButton_Click(object sender, ImageClickEventArgs e)
    {
        InputNumberA.Text = "";
        InputNumberB.Text = "";
        theResultLabel.Text = "";
        InputNumberB.BorderColor = System.Drawing.Color.Black;
        InputNumberA.BorderColor = System.Drawing.Color.Black;
    }
}