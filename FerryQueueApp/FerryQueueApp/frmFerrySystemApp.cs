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
using System.Threading;
using System.Linq.Expressions;

namespace FerryQueueApp
{
    public partial class frmFerryManagementSystem : Form
    {
        FerryStack myStack = new FerryStack();
        VehicleNode currentNode;
        public frmFerryManagementSystem()
        {
            InitializeComponent();
            
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {

            if(Convert.ToInt32(myStack.Count) >= 12)
            {
                try
                {
                    throw new Exception("Ferry Full");
                }
                catch (Exception ex)
                {
                    string errMessage = ex.Message + " " + DateTime.Now.ToString() + Environment.NewLine;
                    File.AppendAllText(Environment.CurrentDirectory + "/ErrorLog.txt", errMessage + Environment.NewLine);
                    this.txtOutput.Text = ex.Message;
                    
                }

            }//If for ferry count check

            else
            {
                if (txtRegistration.TextLength <= 5)
                {
                    this.txtOutput.Text = "Minimum 6 Character Registration Required";
                }// data validation for checking a registration is input
                else
                {
                    if (txtDriverName.TextLength <= 1)
                    {
                        this.txtOutput.Text = "Minimum 2 Character Driver Name Required";
                    }// data validation for checking there is a driver name inputed
                    else
                    {
                        if  (cmbVehicleType.SelectedIndex == -1)
                        {
                           this.txtOutput.Text = "Select Vehicle Type";
                        }// data validation for checking there is a selected vehicle type
                        else
                        {
                            try
                            {
                                //create node -----------------
                                string registration = txtRegistration.Text;
                                string driverName = txtDriverName.Text;
                                int numOccupants = Convert.ToInt32(nudNumOccupants.Text);
                                string vehicleType = cmbVehicleType.Text;

                                VehicleNode mynode = new VehicleNode(driverName, registration, vehicleType, numOccupants);

                                this.txtOutput.Text = mynode.deatils();
                                currentNode = mynode;

                                //--------------------

                                // push node onto stack---------------

                                if (currentNode != null)
                                {
                                    myStack.push(currentNode); //adds node to stack
                                    this.txtOutput.Text = " Vehicle added to Ferry";
                                }

                                currentNode = null;

                                txtRegistration.Text = "";
                                txtDriverName.Text = "";
                                nudNumOccupants.Text = "1";
                                cmbVehicleType.SelectedIndex = -1;
                            }//try

                            catch (System.FormatException)
                            {
                                this.txtOutput.Text = "Must Input Valid Registration, Driver Name, Number of Occupants, and Vehicle Type";
                            }
                        }// check for vehicle type selected
                    }// check for driver name 2 or more charcters
                   
                }// check registration is 6 or more chracters

            }// else create vehicle node

            

        }//add button which creates node and pushes node onto stack

        private void btnList_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = myStack.list();
        }// list all vehicles

        private void btnTotalVehicles_Click(object sender, EventArgs e)
        {

            this.txtOutput.Text = "Total Vehicles: " + myStack.TotalVehicles.ToString();
        }//get number of total vehicles on ferry

        private void btnTotalPassengers_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "Total Passengers: " + myStack.TotalOccupants.ToString();
        }// total vehicles button

        private void btnRemove_Click(object sender, EventArgs e)
        {
            VehicleNode removed = myStack.pop();
            if (removed != null)
            {
                this.txtOutput.Text = removed.Registration + " Removed from Ferry";
            }
            else
            {
                this.txtOutput.Text = "Ferry is Empty";
            }
        }// revove vehicle button

        private void btnSearchReg_Click(object sender, EventArgs e)
        {
            VehicleNode found = myStack.searchReg(txtRegistration.Text);
            if (found != null)
            {
                currentNode = found;
                this.txtOutput.Text = "Found: " + found.Registration;

                txtRegistration.Text = "";
                txtDriverName.Text = "";
                nudNumOccupants.Text = "1";
                cmbVehicleType.SelectedIndex = -1;
            }
            else
            {
                this.txtOutput.Text = "No Vehicle Found";
                //--------throw exception to log here-------

                try
                {
                    throw new Exception("Vehicle " + txtRegistration.Text + " Not Found");
                }
                catch (Exception ex)
                {
                    string errMessage = ex.Message + " " + DateTime.Now.ToString() + Environment.NewLine;

                    File.AppendAllText(Environment.CurrentDirectory + "/ErrorLog.txt", errMessage + Environment.NewLine);

                    this.txtOutput.Text = ex.Message;

                    txtRegistration.Text = "";
                    txtDriverName.Text = "";
                    nudNumOccupants.Text = "1";
                    cmbVehicleType.SelectedIndex = -1;
                }
            }
        }// search registration button + error log append

        private void btnSearchDriver_Click(object sender, EventArgs e)
        {
            VehicleNode found = myStack.searchDriver(txtDriverName.Text);
            if (found != null)
            {
                currentNode = found;
                this.txtOutput.Text = "Found: " + found.DriverName;

                txtRegistration.Text = "";
                txtDriverName.Text = "";
                nudNumOccupants.Text = "1";
                cmbVehicleType.SelectedIndex = -1;
            }
            else
            {
                this.txtOutput.Text = "No Driver Found";
                //--------throw exception to log here-------

                try
                {
                    throw new Exception("Driver " + txtDriverName.Text + " Not Found");
                }
                catch (Exception ex)
                {
                    string errMessage = ex.Message + " " + DateTime.Now.ToString() + Environment.NewLine;

                    File.AppendAllText(Environment.CurrentDirectory + "/ErrorLog.txt", errMessage + Environment.NewLine);

                    this.txtOutput.Text = ex.Message;

                    txtRegistration.Text = "";
                    txtDriverName.Text = "";
                    nudNumOccupants.Text = "1";
                    cmbVehicleType.SelectedIndex = -1;
                }

            }// search for driver name + error log append
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (myStack.peek() != null)
            {
                this.txtOutput.Text = "Last Vechicle In"+ Environment.NewLine + myStack.peek().deatils();
            }
            else
            {
                this.txtOutput.Text = "Cannot Peek No Vehicles In Ferry";
            }

        }

        private void btnGetDeatils_Click(object sender, EventArgs e)
        {
            if(currentNode != null)
            {
                this.txtOutput.Text = currentNode.deatils();

                txtRegistration.Text = "";
                txtDriverName.Text = "";
                nudNumOccupants.Text = "1";
                cmbVehicleType.SelectedIndex = -1;

            }
            else
            {
                this.txtOutput.Text = "Must Search For a Registration or Driver Name First";

                txtRegistration.Text = "";
                txtDriverName.Text = "";
                nudNumOccupants.Text = "1";
                cmbVehicleType.SelectedIndex = -1;
            }
        }

        private void btnListDriver_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = myStack.listDrivers();
        }

        private void btnListRegistrations_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = myStack.listRegistrations();
        }

        private void btnVehicleTypes_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "Vehicle type Numbers: " + Environment.NewLine + "Bikes: " + myStack.TotalBikes.ToString() + Environment.NewLine + "Cars: " + myStack.TotalCars.ToString() + Environment.NewLine + "LGVs: " + myStack.TotalLGV.ToString() + Environment.NewLine + "OGV 1: " + myStack.TotalOGV1.ToString() + Environment.NewLine + "OGV 2: " + myStack.TotalOGV2.ToString() + Environment.NewLine + "PSV: " + myStack.TotalPSV.ToString();
        }
    }//class
}//ns