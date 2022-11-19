using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex2H
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DateCalculationButton_Click(object sender, EventArgs e)
        {
            TextBox1aResult.Text = DateTime.Now.ToShortDateString();
            TextBox1bResult.Text = DateTime.Now.ToShortTimeString(); 
            TextBox2aResult.Text = DateTime.Today.ToShortDateString();
            TextBox2bResult.Text = DateTime.Today.ToShortTimeString();
            TextBox3aResult.Text = DateTime.Today.Year.ToString();
            TextBox3bResult.Text = DateTime.Today.Month.ToString();
            TextBox3cResult.Text = DateTime.Today.Day.ToString();
            TextBox4Result.Text = DateTime.Today.AddDays(90).ToShortDateString();
            TextBox5Result.Text = DateTime.Today.AddMonths(3).ToShortDateString();
            TextBox6Result.Text = Ex2hCalculations.DateCalc06(TextBox6a.Text, TextBox6b.Text, TextBox6c.Text);
            TextBox7Result.Text = Ex2hCalculations.DateCalc07(TextBox7.Text);
            TextBox8Result.Text = Ex2hCalculations.DateCalc08(TextBox8.Text);
            TextBox9Result.Text = Ex2hCalculations.DateCalc09(TextBox9a.Text, TextBox9b.Text);

        }
        
    }
}