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
        int count = 0;       
        public static string fileName = "log_"+(int)(DateTime.Today.Subtract(new DateTime(1970, 1, 1)).TotalSeconds)+".txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            file.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Model_Click(object sender, EventArgs e)
        {

        }


        private void radioButtonTruck_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "maximum weight";
            textBox1.Visible = true;

            ComboBoxMake.Items.Clear();
            ComboBoxMake.Items.Add("MAN");
            ComboBoxMake.Items.Add("Volvo");
            ComboBoxMake.Items.Add("Mercedes");
            ComboBoxMake.Items.Add("Ford");
            ComboBoxMake.Items.Add("Chevrolet");
            ComboBoxMake.Sorted = true;

            ComboBoxMake.SelectedIndex = 0;
        }

        private void radioButtonBus_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Company name";
            textBox1.Visible = true;

            ComboBoxMake.Items.Clear();
            ComboBoxMake.Items.Add("Neoplan");
            ComboBoxMake.Items.Add("MAN");
            ComboBoxMake.Items.Add("Volvo");
            ComboBoxMake.Items.Add("Iveco");
            ComboBoxMake.Items.Add("Hyundai");

            ComboBoxMake.Sorted = true;
            ComboBoxMake.SelectedIndex = 0;
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


            ComboBoxMake.Items.Clear();
            ComboBoxMake.Items.Add("Ferrari");
            ComboBoxMake.Items.Add("Audi");
            ComboBoxMake.Items.Add("BMW");
            ComboBoxMake.Items.Add("Volkswagen");
            ComboBoxMake.Items.Add("Mercedes");
            ComboBoxMake.Items.Add("Volvo");
            ComboBoxMake.Items.Add("Ford");
            ComboBoxMake.Sorted = true;
            ComboBoxMake.SelectedIndex = 0;
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


            ComboBoxMake.Items.Clear();
            ComboBoxMake.Items.Add("Ferrari");
            ComboBoxMake.Items.Add("Audi");
            ComboBoxMake.Items.Add("BMW");
            ComboBoxMake.Items.Add("Volkswagen");
            ComboBoxMake.Items.Add("Mercedes");
            ComboBoxMake.Items.Add("Volvo");
            ComboBoxMake.Items.Add("Ford");

            ComboBoxMake.Sorted = true;
            ComboBoxMake.SelectedIndex = 0;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegVeh_Click(object sender, EventArgs e)
        {
            MotorVehicle mv = null;
            if(radioButtonTruck.Checked)
            {
                mv = new Truck(textBoxVIN.Text, ComboBoxMake.Text, textBoxModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, dateTimePicker1.Value, Convert.ToDouble(textBox1.Text));
            }

            vehicles[count++] = mv;
            
            richTextBox1.Clear();

            foreach(MotorVehicle m in vehicles)
            {
                if (m != null)
                {
                    richTextBox1.AppendText(mv.show() + '\n');
                    FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write); //Create Stream to edit file
                    StreamWriter writer = new StreamWriter(file); //Create file writer
                    writer.WriteLine(mv.show() + '\n'); //Append to file
                    writer.Close(); //Close file writer
                    file.Close();  //Close File
                }        
            }
        }

    }
}
