using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace CC_Lab_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            string input = textBox1.Text;
            Regex check = new Regex("^[A-Z]{3}[0-9]{1,8}$");
            bool isValid = check.IsMatch(input);

            label4.Text = isValid ? "Valid Input! Your format is identical to the given format!" :
                "Invalid Input! Not identical to the given format!";
        }
    }
}
