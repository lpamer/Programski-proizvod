using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class ReservationRepository : Repository<Reservation>
    {
        public ReservationRepository() : base(new Database())
        {
        }
        public override int Update(Reservation entity, bool saveChanges = true)
        {
            var reservation = Entities.SingleOrDefault(r => r.id == entity.id);

            reservation.customerID = entity.customerID;
            reservation.vehicleID = entity.vehicleID;
            reservation.pickupDate = entity.pickupDate;
            reservation.returnDate = entity.returnDate;
            reservation.pickupLocation = entity.pickupLocation;
            reservation.returnLocation = entity.returnLocation;
            reservation.totalCost = entity.totalCost;
            reservation.creationDate = entity.creationDate;
            reservation.status = entity.status;
            reservation.Customer = entity.Customer;
            reservation.Vehicle = entity.Vehicle;

            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }

        public override IQueryable<Reservation> GetAll()
        {
            var query = from r in Entities
                        select r;
            return query;
        }

        public IQueryable<Reservation> GetReservationsByCustomer(int id)
        {
            var query = from r in Entities
                        where r.Customer.id == id
                        select r;

            return query;
        }

        public IQueryable<Reservation> GetReservationsByVehicle(int id)
        {
            var query = from r in Entities
                        where r.Vehicle.id == id
                        select r;

            return query;
        }

        public IQueryable<Reservation> GetTransactionByCompletion(bool completed)
        {
            var query = from r in Entities
                        where (r.returnLocation != null) == completed
                        select r;

            return query;
        }

        public void AddReservation(Reservation reservation) {
            using(var context = new Database())
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();
            }
        }

        public List<Reservation> GetReservations()
        {
            using(var context = new Database())
            {
                var query = from r in context.Reservations
                            select r;

                return query.ToList();
            }
            
        }

        public void UpdateReservation(Reservation reservation)
        {
            using(var context = new Database())
            {
                Reservation existingReservation = context.Reservations.Find(reservation.id);
                if (existingReservation != null)
                {
                    context.Reservations.AddOrUpdate(reservation);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteReservation(Reservation reservation)
        {
            using (var context = new Database())
            {         
                
                Reservation existingReservation = context.Reservations.Find(reservation.id);
                if (existingReservation != null)
                {
                    context.Reservations.Remove(existingReservation);
                    context.SaveChanges();
                }
                
            }
        }

        public List<Reservation> GetFilteredReservations(string filterType, string filterValue, int vehicleId)
        {
            using (var context = new Database())
            {
                IQueryable<Reservation> query = null;
                if (filterType == "customerId")
                {
                     var queryValue = int.Parse(filterValue);
                     query = from r in context.Reservations
                             where r.vehicleID == vehicleId && r.customerID == queryValue
                                select r;
                }
                else if (filterType == "pickupDate")
                {
                     query = from r in context.Reservations
                                where r.vehicleID == vehicleId && r.pickupDate.ToString().Contains(filterValue)
                                select r;
                }
                else if (filterType == "returnDate")
                {
                     query = from r in context.Reservations
                                where r.vehicleID == vehicleId && r.returnDate.ToString().Contains(filterValue)
                                select r;
                }
                else if (filterType == "pickupLocation")
                {
                     query = from r in context.Reservations
                                where r.vehicleID == vehicleId && r.pickupLocation.Contains(filterValue)
                                select r;
                }
                else if (filterType == "returnLocation")
                {
                     query = from r in context.Reservations
                                where r.vehicleID == vehicleId && r.returnLocation.Contains(filterValue)
                                select r;
                }
                else if (filterType == "totalCost")
                {
                     query = from r in context.Reservations
                                where r.vehicleID == vehicleId && r.totalCost <= decimal.Parse(filterValue)
                                select r;
                }
                else if (filterType == "creationDate")
                {
                     query = from r in context.Reservations
                                where r.vehicleID == vehicleId && r.creationDate.ToString().Contains(filterValue)
                                select r;
                }
                else if (filterType == "status")
                {
                     query = from r in context.Reservations
                                where r.vehicleID == vehicleId && r.status == filterValue
                                select r;
                }

                return query.ToList();
            }
        }
    }
}
