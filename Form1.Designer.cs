namespace DMV_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxVIN = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.dateOfProdLabel = new System.Windows.Forms.Label();
            this.noOfWheelsLabel = new System.Windows.Forms.Label();
            this.noOfSeatsLabel = new System.Windows.Forms.Label();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.NoOfSeats = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NoOfWheels = new System.Windows.Forms.NumericUpDown();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.vehicleTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonMotorcycle = new System.Windows.Forms.RadioButton();
            this.rbTaxi = new System.Windows.Forms.RadioButton();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbBus = new System.Windows.Forms.RadioButton();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.buttonRegVeh = new System.Windows.Forms.Button();
            this.groupBoxVehicleInfo = new System.Windows.Forms.GroupBox();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfWheels)).BeginInit();
            this.vehicleTypeGroupBox.SuspendLayout();
            this.groupBoxVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVIN
            // 
            this.textBoxVIN.Location = new System.Drawing.Point(6, 38);
            this.textBoxVIN.Name = "textBoxVIN";
            this.textBoxVIN.Size = new System.Drawing.Size(208, 20);
            this.textBoxVIN.TabIndex = 0;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(6, 77);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(208, 20);
            this.textBoxMake.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(6, 116);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(208, 20);
            this.textBoxModel.TabIndex = 2;
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(6, 22);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(145, 13);
            this.VINLabel.TabIndex = 6;
            this.VINLabel.Text = "Vehicle Identification Number";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(6, 61);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(108, 13);
            this.MakeLabel.TabIndex = 7;
            this.MakeLabel.Text = "Vehicle Manufacturer";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(6, 100);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            // 
            // dateOfProdLabel
            // 
            this.dateOfProdLabel.AutoSize = true;
            this.dateOfProdLabel.Location = new System.Drawing.Point(6, 139);
            this.dateOfProdLabel.Name = "dateOfProdLabel";
            this.dateOfProdLabel.Size = new System.Drawing.Size(96, 13);
            this.dateOfProdLabel.TabIndex = 9;
            this.dateOfProdLabel.Text = "Date of Production";
            // 
            // noOfWheelsLabel
            // 
            this.noOfWheelsLabel.AutoSize = true;
            this.noOfWheelsLabel.Location = new System.Drawing.Point(6, 178);
            this.noOfWheelsLabel.Name = "noOfWheelsLabel";
            this.noOfWheelsLabel.Size = new System.Drawing.Size(95, 13);
            this.noOfWheelsLabel.TabIndex = 10;
            this.noOfWheelsLabel.Text = "Number of Wheels";
            // 
            // noOfSeatsLabel
            // 
            this.noOfSeatsLabel.AutoSize = true;
            this.noOfSeatsLabel.Location = new System.Drawing.Point(6, 217);
            this.noOfSeatsLabel.Name = "noOfSeatsLabel";
            this.noOfSeatsLabel.Size = new System.Drawing.Size(86, 13);
            this.noOfSeatsLabel.TabIndex = 11;
            this.noOfSeatsLabel.Text = "Number of Seats";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Controls.Add(this.NoOfSeats);
            this.propertiesGroupBox.Controls.Add(this.textBoxVIN);
            this.propertiesGroupBox.Controls.Add(this.MakeLabel);
            this.propertiesGroupBox.Controls.Add(this.radioButtonNo);
            this.propertiesGroupBox.Controls.Add(this.dateTimePicker1);
            this.propertiesGroupBox.Controls.Add(this.NoOfWheels);
            this.propertiesGroupBox.Controls.Add(this.radioButtonYes);
            this.propertiesGroupBox.Controls.Add(this.textBoxMake);
            this.propertiesGroupBox.Controls.Add(this.label3);
            this.propertiesGroupBox.Controls.Add(this.VINLabel);
            this.propertiesGroupBox.Controls.Add(this.textBox2);
            this.propertiesGroupBox.Controls.Add(this.label2);
            this.propertiesGroupBox.Controls.Add(this.ModelLabel);
            this.propertiesGroupBox.Controls.Add(this.label1);
            this.propertiesGroupBox.Controls.Add(this.textBox1);
            this.propertiesGroupBox.Controls.Add(this.textBoxModel);
            this.propertiesGroupBox.Controls.Add(this.dateOfProdLabel);
            this.propertiesGroupBox.Controls.Add(this.noOfWheelsLabel);
            this.propertiesGroupBox.Controls.Add(this.noOfSeatsLabel);
            this.propertiesGroupBox.Location = new System.Drawing.Point(12, 155);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(220, 399);
            this.propertiesGroupBox.TabIndex = 0;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Vehicle Properties";
            // 
            // NoOfSeats
            // 
            this.NoOfSeats.Location = new System.Drawing.Point(6, 233);
            this.NoOfSeats.Name = "NoOfSeats";
            this.NoOfSeats.Size = new System.Drawing.Size(208, 20);
            this.NoOfSeats.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // NoOfWheels
            // 
            this.NoOfWheels.Location = new System.Drawing.Point(6, 194);
            this.NoOfWheels.Name = "NoOfWheels";
            this.NoOfWheels.Size = new System.Drawing.Size(208, 20);
            this.NoOfWheels.TabIndex = 17;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(9, 350);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(46, 17);
            this.radioButtonYes.TabIndex = 23;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "YES";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(9, 373);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNo.TabIndex = 24;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "NO";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.Visible = false;
            // 
            // vehicleTypeGroupBox
            // 
            this.vehicleTypeGroupBox.Controls.Add(this.radioButtonMotorcycle);
            this.vehicleTypeGroupBox.Controls.Add(this.rbTaxi);
            this.vehicleTypeGroupBox.Controls.Add(this.rbCar);
            this.vehicleTypeGroupBox.Controls.Add(this.rbBus);
            this.vehicleTypeGroupBox.Controls.Add(this.rbTruck);
            this.vehicleTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.vehicleTypeGroupBox.Name = "vehicleTypeGroupBox";
            this.vehicleTypeGroupBox.Size = new System.Drawing.Size(220, 137);
            this.vehicleTypeGroupBox.TabIndex = 13;
            this.vehicleTypeGroupBox.TabStop = false;
            this.vehicleTypeGroupBox.Text = "Vehicle Type";
            // 
            // radioButtonMotorcycle
            // 
            this.radioButtonMotorcycle.AutoSize = true;
            this.radioButtonMotorcycle.Location = new System.Drawing.Point(6, 111);
            this.radioButtonMotorcycle.Name = "radioButtonMotorcycle";
            this.radioButtonMotorcycle.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMotorcycle.TabIndex = 4;
            this.radioButtonMotorcycle.TabStop = true;
            this.radioButtonMotorcycle.Text = "Motorcycle";
            this.radioButtonMotorcycle.UseVisualStyleBackColor = true;
            // 
            // rbTaxi
            // 
            this.rbTaxi.AutoSize = true;
            this.rbTaxi.Location = new System.Drawing.Point(6, 88);
            this.rbTaxi.Name = "rbTaxi";
            this.rbTaxi.Size = new System.Drawing.Size(45, 17);
            this.rbTaxi.TabIndex = 3;
            this.rbTaxi.TabStop = true;
            this.rbTaxi.Text = "Taxi";
            this.rbTaxi.UseVisualStyleBackColor = true;
            this.rbTaxi.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(6, 65);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(41, 17);
            this.rbCar.TabIndex = 2;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Car";
            this.rbCar.UseVisualStyleBackColor = true;
            this.rbCar.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // rbBus
            // 
            this.rbBus.AutoSize = true;
            this.rbBus.Location = new System.Drawing.Point(6, 42);
            this.rbBus.Name = "rbBus";
            this.rbBus.Size = new System.Drawing.Size(43, 17);
            this.rbBus.TabIndex = 1;
            this.rbBus.TabStop = true;
            this.rbBus.Text = "Bus";
            this.rbBus.UseVisualStyleBackColor = true;
            this.rbBus.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // rbTruck
            // 
            this.rbTruck.AutoSize = true;
            this.rbTruck.Checked = true;
            this.rbTruck.Location = new System.Drawing.Point(6, 19);
            this.rbTruck.Name = "rbTruck";
            this.rbTruck.Size = new System.Drawing.Size(53, 17);
            this.rbTruck.TabIndex = 0;
            this.rbTruck.TabStop = true;
            this.rbTruck.Text = "Truck";
            this.rbTruck.UseVisualStyleBackColor = true;
            this.rbTruck.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // buttonRegVeh
            // 
            this.buttonRegVeh.Location = new System.Drawing.Point(12, 560);
            this.buttonRegVeh.Name = "buttonRegVeh";
            this.buttonRegVeh.Size = new System.Drawing.Size(220, 79);
            this.buttonRegVeh.TabIndex = 14;
            this.buttonRegVeh.Text = "REGISTER VEHICLE";
            this.buttonRegVeh.UseVisualStyleBackColor = true;
            this.buttonRegVeh.Click += new System.EventHandler(this.RegisterVehicleClick);
            // 
            // groupBoxVehicleInfo
            // 
            this.groupBoxVehicleInfo.Controls.Add(this.rtLog);
            this.groupBoxVehicleInfo.Location = new System.Drawing.Point(244, 12);
            this.groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            this.groupBoxVehicleInfo.Size = new System.Drawing.Size(440, 627);
            this.groupBoxVehicleInfo.TabIndex = 16;
            this.groupBoxVehicleInfo.TabStop = false;
            this.groupBoxVehicleInfo.Text = "Vehicle Information";
            // 
            // rtLog
            // 
            this.rtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtLog.Location = new System.Drawing.Point(6, 19);
            this.rtLog.Name = "rtLog";
            this.rtLog.ReadOnly = true;
            this.rtLog.Size = new System.Drawing.Size(428, 602);
            this.rtLog.TabIndex = 0;
            this.rtLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 651);
            this.Controls.Add(this.groupBoxVehicleInfo);
            this.Controls.Add(this.buttonRegVeh);
            this.Controls.Add(this.vehicleTypeGroupBox);
            this.Controls.Add(this.propertiesGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfWheels)).EndInit();
            this.vehicleTypeGroupBox.ResumeLayout(false);
            this.vehicleTypeGroupBox.PerformLayout();
            this.groupBoxVehicleInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVIN;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label dateOfProdLabel;
        private System.Windows.Forms.Label noOfWheelsLabel;
        private System.Windows.Forms.Label noOfSeatsLabel;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.GroupBox vehicleTypeGroupBox;
        private System.Windows.Forms.RadioButton rbTaxi;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbBus;
        private System.Windows.Forms.RadioButton rbTruck;
        private System.Windows.Forms.RadioButton radioButtonMotorcycle;
        private System.Windows.Forms.Button buttonRegVeh;
        private System.Windows.Forms.GroupBox groupBoxVehicleInfo;
        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown NoOfSeats;
        private System.Windows.Forms.NumericUpDown NoOfWheels;
    }
}

