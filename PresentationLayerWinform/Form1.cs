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
    public partial class Form1 : Form
    {
        public static int id_e = 0;
        public static string tipo_e = "";
        public static string name_e = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practico_EntregableDataSet.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.practico_EntregableDataSet.EmployeesTPH);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int id = (int)row.Cells[0].Value;
                Controlador c = new Controlador();
                c.DeleteEmployee(id);
                this.employeesTableAdapter.ClearBeforeFill = true;
                this.employeesTableAdapter.Fill(this.practico_EntregableDataSet.EmployeesTPH);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                id_e = (int)row.Cells[0].Value;
                name_e = (string)row.Cells[1].Value;
                if((int)row.Cells[3].Value == 1)
                {
                    tipo_e = "PartTimeEmployee";
                }
                else
                {
                    tipo_e = "FullTimeEmployee";
                }
                EditarEmpleado a = new EditarEmpleado();
                a.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CrearEmpleado a = new CrearEmpleado();
            a.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.ClearBeforeFill = true;
            this.employeesTableAdapter.Fill(this.practico_EntregableDataSet.EmployeesTPH);   
        }
    }
}
