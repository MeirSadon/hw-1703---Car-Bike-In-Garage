using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703__hw___CarInGarageWithNewException
{
     public class Garage<T> : IGarage<T>, IEnumerable where T: IGiveDetails
    {
        List<T> vehicles = new List<T>();
        List<string> vehicleTypes = new List<string>();

        public Garage(List<string> vehicleTypes)
        {
            this.vehicleTypes = vehicleTypes;
        }

        public bool CanFixTotalLost()
        {
            return this.CanFixTotalLost();
        }

        public void AddVehicle(T v)
        {
            if (v == null) //Null Exception.
            {
                throw new VehicleNullException("Not Found A Vehicle!");
            }
            if (!vehicleTypes.Contains(v.Brand)) //Not From CarTypes Exception.
            {
                throw new WrongGarageException("We Can't Fix Vehicles From This Brand");
            }
            if (vehicles.Contains(v)) //Car Already Here Exception.
            {
                throw new VehicleAlreadyHereException("Your Vehicle Is Already Here!");
            }
            if (v.TotalLost == true && !v.CanFixTotalLost()) //Car Is Total Lost Exception.
            {
                throw new WeDoNotFixTotalLostException("Your Vehicle Is Total Lost!");
            }
            if(v.NeedRepair == false) //Car Do Not Need Repair Exception.
            {
                throw new RepairMisMatchException("Your Vehicle Does Not Need Repair!");
            }

            vehicles.Add(v);
        }
        public void TakeOutVehicle(T v) //Remove Car From The List.
        {
            if (v == null) //Null Exception.
            {
                throw new VehicleNullException("Not Found A Vehicle!");
            }
            if(!vehicles.Contains(v)) //Car Isn't Here Exception.
            {
                throw new VehicleNotInGarageException("Your Car Is Not Exist In This Garage!");
            }
            if (v.NeedRepair == true) //Car Need Repair Exception.
            {
                throw new VehicleNotReadyException("Your Vehicle Is Not Ready Yet!");
            }
            vehicles.Remove(v);
        }
        public void FixVehicle(T v)
        {
            if (v == null) //Null Exception.
            {
                throw new VehicleNullException("Not Found A Vehicle!");
            }
            if (!vehicles.Contains(v)) //Car Isn't Here Exception.
            {
                throw new VehicleNotInGarageException("Your Car Is Not Exist In This Garage!");
            }
            if (v.NeedRepair == false) //Car Do Not Need Repair Exception.
            {
                throw new RepairMisMatchException("Your Vehicle Does Not Need Repair!");
            }
            v.NeedRepair = false;
        }

        public IEnumerator GetEnumerator()
        {
            return vehicles.GetEnumerator();
         }

        public override string ToString()
        {
            string result = $"in This Garage Have {vehicles.Count} Vehicles: \n";
            foreach (T car in vehicles)
            {
                result = result + $"{car} \n";
            }
            return result;
        }
    }
}
