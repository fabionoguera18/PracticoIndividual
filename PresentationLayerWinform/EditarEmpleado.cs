using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
        {
            InitializeComponent();
            datos();
        }

        private void datos()
        {
            DataAccessLayer.DALEmployeesEF dales = new DataAccessLayer.DALEmployeesEF();
            BusinessLogicLayer.BLEmployees bles = new BusinessLogicLayer.BLEmployees(dales);
            Shared.Entities.Employee empEdit = bles.GetEmployee(Form1.id_e);

            if (empEdit.GetType().Name == "FullTimeEmployee")
            {
                Atributo.Text = "Salary:";
                Shared.Entities.FullTimeEmployee edit = (Shared.Entities.FullTimeEmployee)empEdit;
                Name.Text = edit.Name;
                date.Value = edit.StartDate;
                atr.Text = edit.Salary.ToString();
                Tipo.Text = "FullTimeEmployee";
            }
            else
            {
                Atributo.Text = "Hourly Rate:";
                Shared.Entities.PartTimeEmployee edit = (Shared.Entities.PartTimeEmployee)empEdit;
                Name.Text = edit.Name;
                date.Value = edit.StartDate;
                atr.Text = edit.HourlyRate.ToString();
                Tipo.Text = "PartTimeEmployee";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DALEmployeesEF dales = new DataAccessLayer.DALEmployeesEF();
            BusinessLogicLayer.BLEmployees bles = new BusinessLogicLayer.BLEmployees(dales);

            if (Form1.tipo_e == "FullTimeEmployee")
            {  
                Shared.Entities.FullTimeEmployee flte = new Shared.Entities.FullTimeEmployee()
                {
                    Id = Form1.id_e,
                    Name = Name.Text,
                    StartDate = date.Value,
                    Salary = Int32.Parse(atr.Text)
                };
                bles.UpdateEmployee(flte);
            }
            else
            {
                Shared.Entities.PartTimeEmployee flte = new Shared.Entities.PartTimeEmployee()
                {
                    Id = Form1.id_e,
                    Name = Name.Text,
                    StartDate = date.Value,
                    HourlyRate = Int32.Parse(atr.Text)
                };
                bles.UpdateEmployee(flte);
            }
            this.Close();
        }
    }
}
