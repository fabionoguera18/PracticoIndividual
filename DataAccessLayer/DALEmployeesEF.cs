using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALEmployeesEF : IDALEmployees
    {
        private Employee casteo(Model.Employee emp)
        {
            if (emp != null)
            {
                if (emp.GetType().Name == "FullTimeEmployee")
                {
                    Model.FullTimeEmployee x = (Model.FullTimeEmployee)emp;
                    FullTimeEmployee employeeBase = new FullTimeEmployee()
                    {
                        Id = x.EmployeeId,
                        Name = x.Name,
                        StartDate = x.StartDate,
                        Salary = x.Salary
                    };
                    return employeeBase;
                }
                else
                {
                    Model.PartTimeEmployee x = (Model.PartTimeEmployee)emp;
                    PartTimeEmployee employeeBase = new PartTimeEmployee()
                    {
                        Id = x.EmployeeId,
                        Name = x.Name,
                        StartDate = x.StartDate,
                        HourlyRate = x.HourlyRate
                    };
                    return employeeBase;
                }
            }
            return null;        
        }

        public void AddEmployee(Employee emp)
        {
            if (emp != null)
            {
                using (Model.Practico_EntregableEntities en = new Model.Practico_EntregableEntities())
                {
                    if (emp.GetType().Name == "PartTimeEmployee")
                    {
                        PartTimeEmployee Pte = (PartTimeEmployee)emp;
                        Model.PartTimeEmployee obj = new Model.PartTimeEmployee()
                        {
                            Name = Pte.Name,
                            StartDate = Pte.StartDate,
                            HourlyRate = Pte.HourlyRate
                        };
                        en.Employee.Add(obj);
                        en.SaveChanges();
                    }
                    else
                    {
                        FullTimeEmployee Fte = (FullTimeEmployee)emp;
                        Model.FullTimeEmployee obj = new Model.FullTimeEmployee()
                        {
                            Name = Fte.Name,
                            StartDate = Fte.StartDate,
                            Salary = Fte.Salary
                        };
                        en.Employee.Add(obj);
                        en.SaveChanges();
                    }
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            using (Model.Practico_EntregableEntities en = new Model.Practico_EntregableEntities())
            {
                en.Employee.Remove(en.Employee.FirstOrDefault(x => x.EmployeeId == id));
                en.SaveChanges();
            }
        }


        public void UpdateEmployee(Employee emp)
        {
            if (emp != null)
            {
                using (Model.Practico_EntregableEntities en = new Model.Practico_EntregableEntities())
                {
                    Model.Employee e = en.Employee.FirstOrDefault(x => x.EmployeeId == emp.Id);
                    e.Name = emp.Name;
                    e.StartDate = emp.StartDate;
                    if (emp.GetType().Name == "PartTimeEmployee")
                    {
                        Model.PartTimeEmployee Pte = (Model.PartTimeEmployee)e;
                        Pte.HourlyRate = ((PartTimeEmployee)emp).HourlyRate;
                    }
                    else
                    {
                        Model.FullTimeEmployee Fte = (Model.FullTimeEmployee)e;
                        Fte.Salary = ((FullTimeEmployee)emp).Salary;
                    }
                    en.SaveChanges();
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            using (Model.Practico_EntregableEntities en = new Model.Practico_EntregableEntities())
            {
                List<Employee> empleados = new List<Employee>();
                en.Employee.ToList().ForEach(x =>
                {
                    empleados.Add(casteo(x));
                });
                return empleados;
            }
        }

        public Employee GetEmployee(int id)
        {
            using (Model.Practico_EntregableEntities en = new Model.Practico_EntregableEntities())
            {
                return casteo(en.Employee.FirstOrDefault(x => x.EmployeeId == id));
            }
        }
    }
}
