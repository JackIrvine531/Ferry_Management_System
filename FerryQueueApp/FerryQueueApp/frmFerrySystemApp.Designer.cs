namespace FerryQueueApp
{
    partial class frmFerryManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFerryManagementSystem));
            this.btnList = new System.Windows.Forms.Button();
            this.btnTotalVehicles = new System.Windows.Forms.Button();
            this.btnTotalPassengers = new System.Windows.Forms.Button();
            this.btnListDriver = new System.Windows.Forms.Button();
            this.btnListRegistrations = new System.Windows.Forms.Button();
            this.btnVehicleTypes = new System.Windows.Forms.Button();
            this.btnSearchReg = new System.Windows.Forms.Button();
            this.btnSearchDriver = new System.Windows.Forms.Button();
            this.btnGetDeatils = new System.Windows.Forms.Button();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblNumOccupants = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.nudNumOccupants = new System.Windows.Forms.NumericUpDown();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOccupants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(47, 334);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(136, 65);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "List All Details";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnTotalVehicles
            // 
            this.btnTotalVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalVehicles.Location = new System.Drawing.Point(218, 334);
            this.btnTotalVehicles.Name = "btnTotalVehicles";
            this.btnTotalVehicles.Size = new System.Drawing.Size(136, 65);
            this.btnTotalVehicles.TabIndex = 12;
            this.btnTotalVehicles.Text = "Total Vehicles";
            this.btnTotalVehicles.UseVisualStyleBackColor = true;
            this.btnTotalVehicles.Click += new System.EventHandler(this.btnTotalVehicles_Click);
            // 
            // btnTotalPassengers
            // 
            this.btnTotalPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPassengers.Location = new System.Drawing.Point(47, 439);
            this.btnTotalPassengers.Name = "btnTotalPassengers";
            this.btnTotalPassengers.Size = new System.Drawing.Size(136, 65);
            this.btnTotalPassengers.TabIndex = 13;
            this.btnTotalPassengers.Text = "Total Passengers";
            this.btnTotalPassengers.UseVisualStyleBackColor = true;
            this.btnTotalPassengers.Click += new System.EventHandler(this.btnTotalPassengers_Click);
            // 
            // btnListDriver
            // 
            this.btnListDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListDriver.Location = new System.Drawing.Point(375, 334);
            this.btnListDriver.Name = "btnListDriver";
            this.btnListDriver.Size = new System.Drawing.Size(136, 65);
            this.btnListDriver.TabIndex = 19;
            this.btnListDriver.Text = "List All Drivers";
            this.btnListDriver.UseVisualStyleBackColor = true;
            this.btnListDriver.Click += new System.EventHandler(this.btnListDriver_Click);
            // 
            // btnListRegistrations
            // 
            this.btnListRegistrations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListRegistrations.Location = new System.Drawing.Point(218, 439);
            this.btnListRegistrations.Name = "btnListRegistrations";
            this.btnListRegistrations.Size = new System.Drawing.Size(136, 65);
            this.btnListRegistrations.TabIndex = 20;
            this.btnListRegistrations.Text = "List All Registrations";
            this.btnListRegistrations.UseVisualStyleBackColor = true;
            this.btnListRegistrations.Click += new System.EventHandler(this.btnListRegistrations_Click);
            // 
            // btnVehicleTypes
            // 
            this.btnVehicleTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleTypes.Location = new System.Drawing.Point(375, 439);
            this.btnVehicleTypes.Name = "btnVehicleTypes";
            this.btnVehicleTypes.Size = new System.Drawing.Size(136, 65);
            this.btnVehicleTypes.TabIndex = 21;
            this.btnVehicleTypes.Text = "List Vehicle Types";
            this.btnVehicleTypes.UseVisualStyleBackColor = true;
            this.btnVehicleTypes.Click += new System.EventHandler(this.btnVehicleTypes_Click);
            // 
            // btnSearchReg
            // 
            this.btnSearchReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReg.Location = new System.Drawing.Point(584, 334);
            this.btnSearchReg.Name = "btnSearchReg";
            this.btnSearchReg.Size = new System.Drawing.Size(146, 65);
            this.btnSearchReg.TabIndex = 15;
            this.btnSearchReg.Text = "Search Registration";
            this.btnSearchReg.UseMnemonic = false;
            this.btnSearchReg.UseVisualStyleBackColor = true;
            this.btnSearchReg.Click += new System.EventHandler(this.btnSearchReg_Click);
            // 
            // btnSearchDriver
            // 
            this.btnSearchDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDriver.Location = new System.Drawing.Point(746, 334);
            this.btnSearchDriver.Name = "btnSearchDriver";
            this.btnSearchDriver.Size = new System.Drawing.Size(146, 65);
            this.btnSearchDriver.TabIndex = 16;
            this.btnSearchDriver.Text = "Search Driver Name";
            this.btnSearchDriver.UseVisualStyleBackColor = true;
            this.btnSearchDriver.Click += new System.EventHandler(this.btnSearchDriver_Click);
            // 
            // btnGetDeatils
            // 
            this.btnGetDeatils.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDeatils.Location = new System.Drawing.Point(746, 439);
            this.btnGetDeatils.Name = "btnGetDeatils";
            this.btnGetDeatils.Size = new System.Drawing.Size(146, 65);
            this.btnGetDeatils.TabIndex = 18;
            this.btnGetDeatils.Text = "Get Found Details";
            this.btnGetDeatils.UseMnemonic = false;
            this.btnGetDeatils.UseVisualStyleBackColor = true;
            this.btnGetDeatils.Click += new System.EventHandler(this.btnGetDeatils_Click);
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(227, 47);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(176, 20);
            this.txtRegistration.TabIndex = 0;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(451, 47);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(176, 20);
            this.txtDriverName.TabIndex = 1;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Bike",
            "Car",
            "LGV",
            "OGV 1",
            "OGV 2",
            "PSV"});
            this.cmbVehicleType.Location = new System.Drawing.Point(451, 127);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(176, 21);
            this.cmbVehicleType.TabIndex = 4;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(227, 20);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(127, 25);
            this.lblRegistration.TabIndex = 5;
            this.lblRegistration.Text = "Registration";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.Location = new System.Drawing.Point(451, 19);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(131, 25);
            this.lblDriverName.TabIndex = 6;
            this.lblDriverName.Text = "Driver Name";
            // 
            // lblNumOccupants
            // 
            this.lblNumOccupants.AutoSize = true;
            this.lblNumOccupants.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumOccupants.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOccupants.Location = new System.Drawing.Point(227, 99);
            this.lblNumOccupants.Name = "lblNumOccupants";
            this.lblNumOccupants.Size = new System.Drawing.Size(165, 25);
            this.lblNumOccupants.TabIndex = 7;
            this.lblNumOccupants.Text = "Num Occupants";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(451, 96);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(137, 25);
            this.lblVehicleType.TabIndex = 8;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(40, 19);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(136, 65);
            this.btnAddVehicle.TabIndex = 9;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(40, 121);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 65);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove Vehicle";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.Location = new System.Drawing.Point(40, 213);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(136, 65);
            this.btnPeek.TabIndex = 17;
            this.btnPeek.Text = "Peek Last In";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // nudNumOccupants
            // 
            this.nudNumOccupants.Location = new System.Drawing.Point(227, 128);
            this.nudNumOccupants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNumOccupants.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumOccupants.Name = "nudNumOccupants";
            this.nudNumOccupants.Size = new System.Drawing.Size(175, 20);
            this.nudNumOccupants.TabIndex = 22;
            this.nudNumOccupants.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(933, 26);
            this.lblOutput.MaximumSize = new System.Drawing.Size(333, 650);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 20);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "Output";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(564, 309);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 215);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(16, 309);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(537, 215);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(18, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 289);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(206, 8);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(703, 289);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(919, 8);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(347, 516);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.SystemColors.Menu;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(506, 532);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(271, 116);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 28;
            this.pbxLogo.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(919, 8);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.MaximumSize = new System.Drawing.Size(347, 516);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(347, 516);
            this.txtOutput.TabIndex = 29;
            // 
            // frmFerryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.nudNumOccupants);
            this.Controls.Add(this.btnVehicleTypes);
            this.Controls.Add(this.btnListRegistrations);
            this.Controls.Add(this.btnListDriver);
            this.Controls.Add(this.btnGetDeatils);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnSearchDriver);
            this.Controls.Add(this.btnSearchReg);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnTotalPassengers);
            this.Controls.Add(this.btnTotalVehicles);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblNumOccupants);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.cmbVehicleType);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "frmFerryManagementSystem";
            this.Text = "Ferry Management System";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOccupants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnTotalVehicles;
        private System.Windows.Forms.Button btnTotalPassengers;
        private System.Windows.Forms.Button btnListDriver;
        private System.Windows.Forms.Button btnListRegistrations;
        private System.Windows.Forms.Button btnVehicleTypes;
        private System.Windows.Forms.Button btnSearchReg;
        private System.Windows.Forms.Button btnSearchDriver;
        private System.Windows.Forms.Button btnGetDeatils;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblNumOccupants;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.NumericUpDown nudNumOccupants;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

