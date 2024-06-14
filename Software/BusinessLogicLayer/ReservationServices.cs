using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReservationServices
    {
        public List<Reservation> GetReservations() 
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetAll().ToList();
            }
        }

        public bool AddReservation(Reservation reservation)
        {
            bool isSuccessful = false;
            using (var repo = new ReservationRepository())
            {
                int affectedRows = repo.Add(reservation);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;

        }

        public bool RemoveReservation(Reservation reservation)
        {
            bool isSuccessful = false;
            using (var repo = new ReservationRepository())
            {
                int affectedRows = repo.Remove(reservation);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public List<Reservation> GetReservationsByCustomer(int id)
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetReservationsByCustomer(id).ToList();
            }
        }
        public List<Reservation> GetReservationByVehicle(int id)
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetReservationsByVehicle(id).ToList();
            }
        }

        public List<Reservation> GetTransactionsBasedOnCompletion(bool completed)
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetTransactionByCompletion(completed).ToList();
            }
        }

        public bool CheckIfCompleted(Reservation reservation)
        {
            return reservation.returnLocation != null;
        }        

        public void PrintToPdf()
        {

        }
    }
}
