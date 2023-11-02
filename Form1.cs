using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clockIn_forms
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeClock.Text = DateTime.Now.ToLongTimeString();
        }


        class Employee
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }

            public string ClockedIn { get; set; }

            public string ClockedOut { get; set; }
            public double HourlyWage { get; set; }

            public Employee(int age, string name, string code, string clockedIn, string clockedOut, double hourlyWage)
            {
                Age = age;
                Name = name;
                Code = code;
                ClockedIn = clockedIn;
                ClockedOut = clockedOut;
                HourlyWage = hourlyWage;

            }
        }


        void employees(string[] args)
        {

        }
        
        Employee eButler = new Employee(18, "Edward", "2468", "", "", 10.5);

        private bool Validated()
        {


            if (textBox1.Text == string.Empty)
            {
                return false;
            }
            else if (textBox1.Text == eButler.Code)
            {
                textBox1.Clear();
                return true;
            }
            else
            {
                return false;
            }

        }


        private void clockIn_Click(object sender, EventArgs e)
        {

            if (Validated())
            {

                eButler.ClockedIn = DateTime.Now.ToLongTimeString();
                labelIn.Text = "Clocked In - " + eButler.Name + " " + eButler.ClockedIn;
                MessageBox.Show("input is valid");

                
            }
            else
            {

                MessageBox.Show("invalid input");

            }

            
            
        }

        private void clockOut_Click(object sender, EventArgs e)
        {
            if (Validated())
            {

                eButler.ClockedOut = DateTime.Now.ToLongTimeString();
                labelOut.Text = "Clocked Out - " + eButler.Name + " " + eButler.ClockedOut;
                MessageBox.Show("input is valid");
                TimeSpan hours = TimeSpan.Parse(eButler.ClockedOut) - TimeSpan.Parse(eButler.ClockedIn);
                labelHours.Text = "Total hours worked = " + hours;
                /*double dHours = Convert.ToDouble(hours);
                labelMoney.Text = "Money made this shift: " + eButler.HourlyWage * dHours;*/


            }
            else
            {
                MessageBox.Show("invalid input");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
