using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DMV_GUI
{
    public partial class Form1 : Form
    {

        MotorVehicle[] vehicles = new MotorVehicle[20];
        int[] scores = { 12, 34, 54, 65 };
       
        // Car[] cars = new Car[] { new Car() { color = "red", AC = true, airbags = 4 } };

        // Car car = new Car() { color = "red", AC = true, airbags = 4  };
        // je jednako
        Car car = new Car();
        //car.color = "red";
        //car.AC = true;
        //car.airbags = 4;


        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Model_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTruck_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "maximum weight";
            textBox1.Visible = true;
        }

        private void radioButtonBus_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Company name";
            textBox1.Visible = true;
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Car Color";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Number of airbags";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Does the car have AC?";
            radioButtonYes.Visible = true;
            radioButtonNo.Visible = true;
        }

        private void radioButtonTaxi_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Car Color";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Number of airbags";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Driver has licence?";
            radioButtonYes.Visible = true;
            radioButtonNo.Visible = true;

        }
        



        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegVeh_Click(object sender, EventArgs e)
        {
            // Car car = new Car() { color = "red", AC = true, airbags = 4  };

            Car c = new Car();

            //c.setAirbags(4);

            c.Airbag = 4; //set method

            c.Color = "red";

            int numberOfAirbags = c.Airbag; //get method


            MotorVehicle mv = null;
            if(radioButtonTruck.Checked)
            {                                                                         //cast                    //cast
                mv = new Truck(textBoxVIN.Text, textBoxMake.Text, textBoxModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, dateTimePicker1.Value, Convert.ToDouble(textBox1.Text));
            }

            vehicles[count++] = mv;
            
            richTextBox1.Clear();

            foreach(MotorVehicle m in vehicles)
            {
                if (m != null) richTextBox1.AppendText(m.show() + '\n');
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        FileStream outFile = new
        FileStream("SomeText.txt", FileMode.Create, FileAccess.Write);
        

    }
}
