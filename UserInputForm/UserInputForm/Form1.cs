using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInputForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "") || (textBox2.Text == "") || (listBox1.SelectedIndex == -1))
            {
                label4.Text = "Please check and fill all the fields in the form ";
            }
            else
            {
                string pay_mode = ((listBox1.SelectedIndex == 0) ? "Debit Card" : "Credit Card");
                long card_number = Convert.ToInt64(textBox2.Text);
                var card_valid = (isValid(card_number) ? "valid" : "invalid");
                if(card_valid == "valid")
                {
                    label4.Text = $"UserName: {textBox1.Text}, Mode of Payment: {pay_mode} and Card Details: {textBox2.Text} and card is {card_valid}";
                }
                else
                {
                    label4.Text = $"Card Number: {card_number} is {card_valid}";
                }                
            }
        }
        // Return true if the card number is valid
        public static bool isValid(long number)
        {
            return (getSize(number) >= 13 &&
                    getSize(number) <= 16) &&
                    (prefixMatched(number, 4) ||
                    prefixMatched(number, 5) ||
                    prefixMatched(number, 37) ||
                    prefixMatched(number, 6)) &&
                    ((sumOfDoubleEvenPlace(number) +
                    sumOfOddPlace(number)) % 10 == 0);
        }
        // Get the result from Step 2
        public static int sumOfDoubleEvenPlace(long number)
        {
            int sum = 0;
            String num = number + "";
            for (int i = getSize(number) - 2; i >= 0; i -= 2)
                sum += getDigit(int.Parse(num[i] + "") * 2);

            return sum;
        }

        // Return this number if it is a
        // single digit, otherwise, return
        // the sum of the two digits
        public static int getDigit(int number)
        {
            if (number < 9)
                return number;
            return number / 10 + number % 10;
        }

        // Return sum of odd-place digits in number
        public static int sumOfOddPlace(long number)
        {
            int sum = 0;
            String num = number + "";
            for (int i = getSize(number) - 1; i >= 0; i -= 2)
                sum += int.Parse(num[i] + "");
            return sum;
        }

        // Return true if the digit d
        // is a prefix for number
        public static bool prefixMatched(long number, int d)
        {
            return getPrefix(number, getSize(d)) == d;
        }

        // Return the number of digits in d
        public static int getSize(long d)
        {
            String num = d + "";
            return num.Length;
        }

        // Return the first k number of digits from
        // number. If the number of digits in number
        // is less than k, return number.
        public static long getPrefix(long number, int k)
        {
            if (getSize(number) > k)
            {
                String num = number + "";
                return long.Parse(num.Substring(0, k));
            }
            return number;
        }
    }
}
