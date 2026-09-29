using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryQueueApp
{
    public class VehicleNode
    {
        private string driverName;
        private string registration;
        private string vehicleType;
        private int numOccupants;
        private VehicleNode prev;

        public VehicleNode(string driverName, string registration, string vehicleType, int numOccupants)
        {
            this.driverName = driverName;
            this.registration = registration;
            this.vehicleType = vehicleType;
            this.numOccupants = numOccupants;
            prev = null;
        }//constructor

        public string DriverName
        {
            get
            {
                return driverName;
            }
        }//get name

        public string Registration
        {
            get
            {
                return registration;
            }

        }// get registration

        public string VehicleType
        {
            get
            {
                return vehicleType;
            }

        }// get VehicleType

        public int NumOccupants
        {
            get
            {
                return numOccupants;
            }
        }//get number of occupants

        public VehicleNode Prev
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }
        }// get and set Previous

        public string deatils()
        {
            return "Registration: " + registration + Environment.NewLine + "Vehicle Type: " + vehicleType + Environment.NewLine + "Driver Name: " + driverName + Environment.NewLine + "Number of Occupants: " + numOccupants + Environment.NewLine;
        }//get details
    }//class
}//ns
