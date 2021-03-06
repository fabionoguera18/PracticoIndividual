﻿using ServiceLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerWinform
{
    public class Controlador
    {
        private IServiceEmployees IB;
        public Controlador()
        {
            IB = new ServiceEmployees();
        }
        public void AddEmployee(Employee emp)
        {
            IB.AddEmployee(emp);
        }

        public void DeleteEmployee(int id)
        {
            IB.DeleteEmployee(id);
        }

        public void UpdateEmployee(Employee emp)
        {
            IB.UpdateEmployee(emp);
        }

        public List<Employee> GetAllEmployees()
        {
           return IB.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return IB.GetEmployee(id);
        }

        public Nullable<double> CalcPartTimeEmployeeSalary(int idEmployee, int hours)
        {
            return IB.CalcPartTimeEmployeeSalary(idEmployee, hours);
        }
    }
}
