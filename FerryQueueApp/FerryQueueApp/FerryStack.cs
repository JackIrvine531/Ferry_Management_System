using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerryQueueApp
{
    public class FerryStack
    {
        private VehicleNode top;
        private int count;
        private int totalVehicles;
        private int totalOccupants;
        private int bikeCount, carCount, lgvCount, ogvCount, ogv2Count, psvCount;

        public FerryStack()
        {
            top = null;
            count = 0;
            totalVehicles = 0;
            totalOccupants = 0;
            bikeCount = 0;
            carCount = 0;
            lgvCount = 0;
            ogvCount = 0;
            ogv2Count = 0;
            psvCount = 0;

            
        }//constructor

        private bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//isEmpty

        public void push (VehicleNode newNode)
        {
            if (isEmpty())
            {
                top = newNode;
            }
            else
            {
                newNode.Prev = top;
                top = newNode;
            }
            count++;
            totalVehicles++;
            totalOccupants += newNode.NumOccupants;
            if (newNode.VehicleType == "Bike")
            {
                bikeCount++;
            }
            if(newNode.VehicleType == "Car")
            {
                carCount++;
            }
            if (newNode.VehicleType == "LGV")
            {
                lgvCount++;
            }
            if (newNode.VehicleType == "OGV 1")
            {
                ogvCount++;
            }
            if (newNode.VehicleType == "OGV 2")
            {
                ogv2Count++;
            }
            if (newNode.VehicleType == "PSV")
            {
                psvCount++;
            }
        }//push

        public string Count
        {
            get
            {
                return count.ToString();
            }
        }//get count

        public string TotalOccupants
        {
            get
            {
                return totalOccupants.ToString();
            }
        }// get total occupants

        public string TotalVehicles
        {
            get
            {
                return totalVehicles.ToString();
            }
        }// get total vehicles

        public string TotalBikes
        {
            get
            {
                return bikeCount.ToString();
            }
        }// get total number of bikes
        public string TotalCars
        {
            get
            {
                return carCount.ToString();
            }
        }// get total number of cars
        public string TotalLGV
        {
            get
            {
                return lgvCount.ToString();
            }
        }// get total number of LVGs
        public string TotalOGV1
        {
            get
            {
                return ogvCount.ToString();
            }
        }// get total number of OVG 1
        public string TotalOGV2
        {
            get
            {
                return ogv2Count.ToString();
            }
        }// get total number of OVG2 
        public string TotalPSV
        {
            get
            {
                return psvCount.ToString();
            }
        }// get total number of PSV


        public string list()
        {
            if (isEmpty())
            {
                return "No vehicles on ferry";
            }

            string output = "Vehicles on Ferry: " + Environment.NewLine + Environment.NewLine;
            VehicleNode current = top;

            while (current != null)
            {
                output += current.deatils() + Environment.NewLine;
                current = current.Prev;
            }
            return output;
        }//list

        public VehicleNode peek()
        {
            return top;
        }//peek

        public VehicleNode pop()
        {
            if (isEmpty())
            {
                return null;
            }

            VehicleNode remove = top;

            totalOccupants -= remove.NumOccupants;
            top = remove.Prev;
            count--;
            totalVehicles--;

            if (remove.VehicleType == "Bike")
            {
                bikeCount--;
            }
            if (remove.VehicleType == "Car")
            {
                carCount--;
            }
            if (remove.VehicleType == "LGV")
            {
                lgvCount--;
            }
            if (remove.VehicleType == "OGV 1")
            {
                ogvCount--;
            }
            if (remove.VehicleType == "OGV 2")
            {
                ogv2Count--;
            }
            if (remove.VehicleType == "PSV")
            {
                psvCount--;
            }

            return remove;
            
        }//pop

        public VehicleNode searchReg(string findreg)
        {
            if (isEmpty())
            {
                return null;
            }

            VehicleNode current = top; //start at top

            while (current != null)
            {
                if (findreg.Equals(current.Registration, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Prev;// if not found move to next node
            }
            return null;
        }//search for registration

        public VehicleNode searchDriver(string findname)
        {
            if (isEmpty())
            {
                return null;
            }

            VehicleNode current = top; //start at top

            while (current != null)
            {
                if (findname.Equals(current.DriverName, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Prev;// if not found move to next node
            }
            return null;
        }//search for registration

        public string listDrivers()
        {
            if (isEmpty())
            {
                return "No vehicles on ferry";
            }

            string output = "All Drivers Names: " + Environment.NewLine + Environment.NewLine;
            VehicleNode current = top;

            while (current != null)
            {
                output += current.DriverName + Environment.NewLine;
                current = current.Prev;
            }
            return output;
        }//list driver names

        public string listRegistrations()
        {
            if (isEmpty())
            {
                return "No vehicles on ferry";
            }

            string output = "All Vehicle Registrations: " + Environment.NewLine + Environment.NewLine;
            VehicleNode current = top;

            while (current != null)
            {
                output += current.Registration + Environment.NewLine;
                current = current.Prev;
            }
            return output;
        }//list driver names

    }//class
}//ns
