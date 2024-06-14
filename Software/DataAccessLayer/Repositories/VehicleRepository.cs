using EntitiesLayer.Entities;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class VehicleRepository : Repository<Vehicle>
    {
        public VehicleRepository() : base(new Database()) { }

        public override IQueryable<Vehicle> GetAll()
        {
            var query = from p in Entities select p;
            return query;
        }

        public override int Add(Vehicle entity, bool saveChanges = true)
        {
            var reservations = Context.Reservations.SingleOrDefault(c => c.id == entity.id);

            Vehicle vehicle = new Vehicle
            {
                model = entity.model,
                mark = entity.mark,
                year = entity.year,
                registrationPlate = entity.registrationPlate,
                currentMileage = entity.currentMileage
            };

            Entities.Add(vehicle);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else return 0;
        }

        public override int Update(Vehicle entity, bool saveChanges = true)
        {
            var reservations = Context.Reservations.SingleOrDefault(c => c.id == entity.id);

            var vehicle = Entities.SingleOrDefault(p => p.id == entity.id);

            vehicle.model = entity.model;
            vehicle.mark = entity.mark;
            vehicle.year = entity.year;
            vehicle.registrationPlate = entity.registrationPlate;
            vehicle.currentMileage = entity.currentMileage;

            if(saveChanges) { return SaveChanges(); } else return 0;
        }

    }
}
