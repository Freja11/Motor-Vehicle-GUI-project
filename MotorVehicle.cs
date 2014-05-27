using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMV_GUI
{

    //MotorVehicle n = new MotorVehicle()
    abstract class MotorVehicle
    {
        string VIN;
        string make;
        string model;
        DateTime dateOfProduction; //datetime , has to be >now
        protected int noOfWheels; //has to be >2 , <18
        protected int noOfSeats;  //has to be >=1

        public MotorVehicle() { } //doesnt do anything, it allocates the memory to reserve memory and assing to a variable
       // public MotorVehicle() { }
        public MotorVehicle(string VIN, string make, string model, int noOfWheels, int noOfSeats, DateTime dateOfProduction)  //, int noOfWheels, int noOfSeats)
        {
            this.VIN = VIN;
            this.make = make;
            this.model = model;
            this.noOfSeats = noOfSeats;
            this.noOfWheels = noOfWheels;
            this.dateOfProduction = dateOfProduction;
        }


        





        //if VIN is valid return true, otherwise return false
        public bool SetVIN(string VIN)
        {
            if (VIN.Length != 17) return false;
            else return true;
        }

        public string show()
        {
            return string.Format(" make {0}, model {1} and has {2} wheels", make, model, noOfWheels);
        }


    }

    class Truck : MotorVehicle
    {
        private double maxWeight;
        public Truck(string VIN, string make, string model, int noOfWheels, int noOfSeats, DateTime dateOfProduction, double maxWeight)
            : base(VIN, make, model, noOfWheels, noOfSeats, dateOfProduction)
        {
            
            this.maxWeight = maxWeight;
        }

        public string show()
        {
            return "Truck " + "make and model " + " and has max weight of" + maxWeight;
        }
        
    }

    //has to have >8 seats to be a bus
    class Bus : MotorVehicle
    {
        private string companyName;
        public Bus(string VIN, string make, string model, int noOfWheels, int noOfSeats, DateTime dateOfProduction, string companyName)
            : base(VIN, make, model, noOfWheels, noOfSeats, dateOfProduction)
        {
            this.companyName = companyName;
        }

        public string show()
        {
            return "Bus " + "make and model " + ", company: " + companyName;
        }
    }

    //has to have <8 seats to be a car
    class Car : MotorVehicle
    {
        //field
        private string color; //not needed
        private bool AC;
        private int airbags;

        //property
        public string Color { set; get; } //called automatic property, if done like this field color is not needed
        //same as
        //{
            //set { color = value; }
            //get { return color; }
        //}
        public int Airbag
        {
            set
            {
                if (value > 0 && value < 10)
                {
                    airbags = value;
                }
                else
                {
                    airbags = 0;
                }
            }
            get
            {
                return airbags;
            }
        }
        //je jednako
        public void setAirbags(int numberOfAirbags)
        {
            if (numberOfAirbags > 0 && numberOfAirbags < 10)
            {
                airbags = numberOfAirbags;
            }
            else
            {
                airbags = 0;
            }
        }
    

    

        public Car() { }
        public Car(string VIN) { }
        public Car(string VIN, string make, string model, int noOfWheels, int noOfSeats, DateTime dateOfProduction, string color, bool AC, int airbags)
            : base(VIN, make, model, noOfWheels, noOfSeats, dateOfProduction)
        {
            this.color = color;
            this.AC = AC;
            this.airbags = airbags;
        }

        public string show()
        {
            return "Car " + "make and model " + " in " + color + "has AC: " + AC + " and has" + airbags + "airbags.";
        }
    }

    class Taxi : Car
    {
        private bool licence;
        public Taxi(string VIN, string make, string model, int noOfWheels, int noOfSeats, DateTime dateOfProduction, string color, bool AC, int airbags, bool licence)
            : base(VIN, make, model, noOfWheels, noOfSeats, dateOfProduction, color, AC, airbags)
        {
            new Car(VIN, make, model, noOfSeats, noOfWheels, dateOfProduction, color, AC, airbags);
            this.licence = licence;
        }
        public string show()
        {
            return "Taxi " + "make and model " + " and has the licence plate: " + licence;
        }
    }

    class Motorcycle : MotorVehicle
    {
        private double ccm;
        public Motorcycle(string VIN, string make, string model, int noOfWheels, int noOfSeats, DateTime dateOfProduction, double ccm)
            : base(VIN, make, model, noOfWheels, noOfSeats, dateOfProduction)
        {

            this.ccm = ccm;
        }
        public string show()
        {
            return "Motorcycle " + "make and model " + " and has ccm of: " + ccm;
        }

    }
}
