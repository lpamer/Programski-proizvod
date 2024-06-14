using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class VehicleService
    {
        public List<Vehicle> GetVehicles()
        {
            using(var repo = new VehicleRepository())
            {
                List<Vehicle> vehicles = repo.GetAll().ToList();
                return vehicles;
            }
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            bool isSuccessful = false;

            using(var repo = new VehicleRepository())
            {
                int affectedRows = repo.Add(vehicle);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool UpdateVehicle(Vehicle vehicle)
        {
            bool isSuccessful = false;

            using (var repo = new VehicleRepository())
            {
                int affectedRows = repo.Update(vehicle);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool RemoveVehicle(Vehicle vehicle)
        {
            bool isSuccessful = false;

            bool canRemove = CheckIfVehicleCanBeRemoved(vehicle);
            if (canRemove)
            {
                using(var repo = new VehicleRepository())
                {
                    int aaffectedRows = repo.Remove(vehicle);
                    isSuccessful |= aaffectedRows > 0;
                }
            }

            return isSuccessful;
        }

        public bool CheckIfVehicleCanBeRemoved(Vehicle vehicle)
        {
            if (vehicle == null) return false;
            else return true;
        }
    }
}
