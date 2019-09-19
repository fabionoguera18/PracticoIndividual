﻿using DataAccessLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLEmployees : IBLEmployees
    {
       private IDALEmployees _dal;

        public BLEmployees(IDALEmployees dal)
        {
            _dal = dal;
        }

        public void AddEmployee(Employee emp)
        {
            _dal.AddEmployee(emp);
        }

        public void DeleteEmployee(int id)
        {
            _dal.DeleteEmployee(id);
        }

        public void UpdateEmployee(Employee emp)
        {
            _dal.UpdateEmployee(emp);
        }

        public List<Employee> GetAllEmployees()
        {
            return _dal.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            Employee e = _dal.GetEmployee(id);
            if(e == null)
            {
                throw new Exception("Usuario no encontrado");
            }
            return e;
        }

        public Nullable<double> CalcPartTimeEmployeeSalary(int idEmployee, int hours)
        {
            Employee e = _dal.GetEmployee(idEmployee);
            if (e != null)
            {
                if (e.GetType().Name == "PartTimeEmployee")
                {
                    PartTimeEmployee Pte = (PartTimeEmployee)e;
                    return Pte.HourlyRate * hours;
                }
                else
                {
                    throw new Exception("El usuario no es part-time");
                }
            }
            else
            {
                throw new Exception("Usuario no encontrado");
            }
        }
    }
}
