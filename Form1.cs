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
using System.Globalization;

namespace DMV_GUI
{
    public partial class Form1 : Form
    {

        MotorVehicle[] vehicles = new MotorVehicle[20];
        String lastFileName = "";
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
            {                                                                         //cast                    //cast
                mv = new Truck(textBoxVIN.Text, ComboBoxMake.Text, textBoxModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, dateTimePicker1.Value, Convert.ToDouble(textBox1.Text));
            }

            richTextBox1.Text = mv.show();
            FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(mv.show());
            writer.Close();
            file.Close(); 
 
            if (!File.Exists("RegisteredVehicles.txt"))
            {
                File.Create("RegisteredVehicles.txt").Close();
            }
            if (!Directory.Exists("C:\\DVM\\BACKUP"))
            {
                Directory.CreateDirectory("C:\\DVM\\BACKUP");
            }
            File.Move("RegisteredVehicles.txt", "C:\\DVM\\Backup\\RegisteredVehicles.txt");
            String name = "C:\\DVM\\Backup\\RegisteredVehicles" + DateTime.Now.ToString("HH-mm-ss dd-MM-yyyy") + ".txt";
            File.Move("C:\\DVM\\Backup\\RegisteredVehicles.txt", name);
            file = new FileStream(name, FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(file);
            StringBuilder sb = new StringBuilder();
            writer.WriteLine(mv.show());
            writer.Close();
            file.Close();
            lastFileName = name;
        }

        private void LastVehicleButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream(lastFileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                String[] values = reader.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                textBoxVIN.Text = values[0];
                ComboBoxMake.Text = values[1];
                textBoxModel.Text = values[2];
                dateTimePicker1.Value = DateTime.ParseExact(values[3], "MMddyy", CultureInfo.InvariantCulture);
                NoOfWheels.Value = int.Parse(values[4]);
                NoOfSeats.Value = int.Parse(values[5]);
                reader.Close();
                file.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There is no file "+lastFileName+" in C:\\DVM\\Backup");
            }
        }

    }
}
