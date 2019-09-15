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
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
