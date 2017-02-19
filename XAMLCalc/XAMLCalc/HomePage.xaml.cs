using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


using Xamarin.Forms;

namespace XAMLCalc
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void OnBackspaceButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Notification", "The backspaceButton has been clicked.", "OK", "Cancel");
        }

        private void OnDigitButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.StyleId == "7")
            {
                displayLabel.Text = displayLabel.Text + "7";

            }
            if (button.StyleId == "8")
            {
                displayLabel.Text = displayLabel.Text + "8";

            }
            if (button.StyleId == "9")
            {
                displayLabel.Text = displayLabel.Text + "9";

            }
            if (button.StyleId == "4")
            {
                displayLabel.Text = displayLabel.Text + "4";

            }
            if (button.StyleId == "5")
            {
                displayLabel.Text = displayLabel.Text + "5";

            }
            if (button.StyleId == "6")
            {
                displayLabel.Text = displayLabel.Text + "6";

            }
            if (button.StyleId == "1")
            {
                displayLabel.Text = displayLabel.Text + "1";

            }
            if (button.StyleId == "2")
            {
                displayLabel.Text = displayLabel.Text + "2";

            }
            if (button.StyleId == "3")
            {
                displayLabel.Text = displayLabel.Text + "3";

            }
            if (button.StyleId == "+")
            {
                //convert the string to a value
                displayLabel.Text = displayLabel.Text + "+";

            }
            if (button.StyleId == "=")
            {
                //convert the string to a value
                String[] expressions = new String[] { displayLabel.Text };
                decimal total = 0m;

                String pattern = @"(\d+)+([-+*/])+(\d+)";
                foreach (var expression in expressions)
                    foreach (Match m in Regex.Matches(expression, pattern))
                    {
                        int value1 = Int32.Parse(m.Groups[1].Value);
                        int value2 = Int32.Parse(m.Groups[3].Value);
                        switch (m.Groups[2].Value)
                        {
                            case "+":
                                total = value1 + value2;
                                displayLabel.Text = total.ToString();
                                break;
                            case "-":
                                total = value1 - value2;
                                break;
                            case "*":
                                total = value1 * value2;
                                break;
                            case "/":
                                total = value1 / value2;
                                break;
                        }
                    }



            }
            if (button.StyleId == "C")
            {
                displayLabel.Text = "";

            }
        }

    }
}
