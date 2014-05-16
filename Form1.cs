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

        MotorVehicle[] vehicleArray = new MotorVehicle[20]; //Define Array of MotorVehicle objects
        int count = 0; //Initialize array counter  
        public static string fileName = "log_"+(int)(DateTime.Today.Subtract(new DateTime(1970, 1, 1)).TotalSeconds)+".txt"; //Define dynamic time-dependant name of textfile

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VehicleTypeChange(null, null); //Run function to check the default radio button

            if (!File.Exists(fileName)) //Check if our textfile already exists
            {
                FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write); //Create a new texfile
                file.Close(); //Close the file, so that other methods can acces it
            }
        }

        private void VehicleTypeChange(object sender, EventArgs e) //Method for radio button selector. Displays required fileds for diferent types of motor Vehicles
        {
            if (rbTruck.Checked)
            {
                label1.Visible = textBox1.Visible = true;
                label2.Visible = textBox2.Visible = label3.Visible = radioButtonYes.Visible = radioButtonNo.Visible = false;
                label1.Text = "maximum weight";
            }
            else if (rbBus.Checked)
            {
                label1.Visible = textBox1.Visible = true;
                label2.Visible = textBox2.Visible = label3.Visible = radioButtonYes.Visible = radioButtonNo.Visible = false;
                label1.Text = "Company name";
            }
            else if (rbCar.Checked)
            {
                label1.Visible = textBox1.Visible = label2.Visible = label3.Visible = textBox2.Visible = radioButtonYes.Visible = radioButtonNo.Visible = true;
                label1.Text = "Car Color";
                label2.Text = "Number of airbags";
                label3.Text = "Does the car have AC?";
            }
            else if (rbTaxi.Checked)
            {
                label1.Visible = textBox1.Visible = label2.Visible = label3.Visible = textBox2.Visible = radioButtonYes.Visible = radioButtonNo.Visible = true;
                label1.Text = "Car Color";
                label2.Text = "Number of airbags";
                label3.Text = "Driver has licence?";
            }
        }

        private void RegisterVehicleClick(object sender, EventArgs e) //Button Click method. Creates objects, puts them in our array, then displays them in log as well as stores them in out textfile
        {
            MotorVehicle mv = null;
            if (rbTruck.Checked)
            {
                mv = new Truck(textBoxVIN.Text, textBoxMake.Text, textBoxModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, dateTimePicker1.Value, Convert.ToDouble(textBox1.Text));
            }
            else if (rbBus.Checked)
            {
                mv = new Bus(textBoxVIN.Text, textBoxMake.Text, textBoxModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, dateTimePicker1.Value, textBox1.Text);                
            }
            else if (rbCar.Checked)
            {
                mv = new Car(textBoxVIN.Text, textBoxMake.Text, textBoxModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, dateTimePicker1.Value, textBox1.Text, radioButtonYes.Checked, Convert.ToInt32(textBox2.Text));                
            }
            else if (rbTaxi.Checked)
            {
                //mv = new Taxi(textBoxVIN.Text, textBoxMake.Text, textBoxModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, dateTimePicker1.Value, Convert.ToDouble(textBox1.Text));                   
            }

            vehicleArray[count++] = mv; //Append newest object to array
            
            rtLog.Clear();

            foreach(MotorVehicle m in vehicleArray) //Display and store in textfile
            {
                if (m != null)
                {
                    rtLog.AppendText(m.show() + '\n');
                    FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);
                    writer.WriteLine(m.show() + '\n');
                    writer.Close();
                    file.Close();  
                }
            }
        }
        
        private void btnLastVehicle_Click(object sender, EventArgs e) //Get from textfile and display in Richtextbox
        {
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file);
                    string lastVehicle = reader.ReadLine();
                    rtLog.AppendText(lastVehicle + "\n");
                    reader.Close();
                    file.Close();   
        }
        
        
    }
}
