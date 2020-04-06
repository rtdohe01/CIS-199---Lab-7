//Lab 7
//By: Ross Doherty (N7701)
//Due Date: 3/24/2019
//CIS 199-75

// This application explores the use of parallel arrays and
// range matching. The app calculates a typing student's
// grade in a course based on their achieved words per minute.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculates and displayed grade earned using parallel
        // arrays and range matching
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int[] ranges = new int[] { 0, 16, 31, 51, 76 };
            char[] grades = new char[] { 'F', 'D', 'C', 'B', 'A' };
            int userInput = Convert.ToInt32(inputGrade.Text);//read the input from textboxes and convert into int.
            int len = ranges.Length;
            char gradeEarn = 'F';
            bool flag = false;
            for (int i = len - 1; i >= 0; i--)
            {
                //from this part
                if (userInput >= ranges[i])
                {
                    gradeEarn = grades[i];//to this
                    flag = true;//indicating the user input is withing the range
                    break;
                }


            }
            if (flag == true)//that means if the user input is valid and we found the value within the range and a grade corresponding to range
            {//then
                outputGrade.Text = "The grade is " + gradeEarn;

            }
            if (flag == false)//if the user input is not valid
            {
                MessageBox.Show("Wrong input!!", "Warning");
            }

        }

        private void promptGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
