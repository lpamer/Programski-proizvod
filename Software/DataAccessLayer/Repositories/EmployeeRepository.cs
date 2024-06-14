using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository
    {
        public Employee GetEmployee(string username)
        {
            using (var context = new Database())
            {
                var employee = (from e in context.Employee
                            where e.username == username
                            select e).FirstOrDefault();

                return employee;
            }
        }
        public void AddImage(string username, byte[] image)
        {
            using (var context = new Database())
            {
                var existingEmployee = (from e in context.Employee
                                        where e.username == username
                                        select e).FirstOrDefault();

                existingEmployee.image = image;
                context.Employee.AddOrUpdate(existingEmployee);
                context.SaveChanges();
            }
        }

    }
}
