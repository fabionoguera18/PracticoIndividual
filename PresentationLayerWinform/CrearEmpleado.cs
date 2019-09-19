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
    public partial class CrearEmpleado : Form
    {
        public CrearEmpleado()
        {
            InitializeComponent();
        }

        private void CrearEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practico_EntregableDataSet1.EmployeesTPH' Puede moverla o quitarla según sea necesario.
            this.employeesTPHTableAdapter.Fill(this.practico_EntregableDataSet1.EmployeesTPH);
            comboBox1.Items.Add("FullTimeEmployee");
            comboBox1.Items.Add("PartTimeEmployee");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Controlador c = new Controlador();
            if (comboBox1.Text == "FullTimeEmployee")
            {
                Shared.Entities.FullTimeEmployee fte = new Shared.Entities.FullTimeEmployee()
                {
                    Name = Name.Text,
                    StartDate = dateTimePicker1.Value,
                    Salary = Int32.Parse(Salary.Text),
                };
                c.AddEmployee(fte);
            }
            else
            {
                Shared.Entities.PartTimeEmployee fte = new Shared.Entities.PartTimeEmployee()
                {
                    Name = Name.Text,
                    StartDate = dateTimePicker1.Value,
                    HourlyRate = Int32.Parse(Rate.Text),
                };
                c.AddEmployee(fte);
            }
            this.Close();
        }
    }
}
