using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMV_GUI
{
    public partial class Form1 : Form
    {
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
        private void button1_Click(object sender, EventArgs e)
        {
            MotorVehicle mv = null;
            if (radioButtonTruck.Checked)
            {
                mv = new Truck(textBoxVIN.Text, textBoxMake.Text, textBoxModel.Text, (int) NoOfSeets.Value, (int)NoOfWheels.Value,dateTimePicker1.Value,Convert.ToDouble(tbAddInfo.Text) );
            }

            if (radioButtonCar.Checked)
            {
                mv = new Car(textBoxVIN.Text, textBoxMake.Text, textBoxModel.Text, (int)NoOfSeets.Value, (int)NoOfWheels.Value, dateTimePicker1.Value,"Red", false, 4);
            }

            vehicles[count++] = mv;

            richTextBox1.Clear();
            foreach(MotorVehicle m in vehicles)
            {
                if (m != null) richTextBox1.AppendText(m.show() + '\n');

            }
        }
    }
}
