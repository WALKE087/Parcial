using ParcialNomina.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialNomina.CapaPresentacion
{
    public partial class FormularioConsultaEmpleados : Form
    {
        private List<DatosEmpleado> empleados; // Variable para almacenar la lista de empleados

        public FormularioConsultaEmpleados(List<DatosEmpleado> listaEmpleados)
        {
            InitializeComponent();
            empleados = listaEmpleados; // Asigna la lista de empleados al campo del formulario
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            string filtroNombre = txtNombreFiltro.Text;
            string filtroEstado = cboEstadoFiltro.Text;

            List<DatosEmpleado> empleadosFiltrados = new List<DatosEmpleado>();

            foreach (DatosEmpleado empleado in empleados)
            {
                bool cumpleFiltroNombre = empleado.Nombre.ToLower().Contains(filtroNombre.ToLower());

                bool cumpleFiltroEstado = string.IsNullOrEmpty(filtroEstado) || empleado.Estado.ToLower() == filtroEstado.ToLower();


                if (cumpleFiltroNombre && cumpleFiltroEstado)
                {
                    empleadosFiltrados.Add(empleado);
                }
            }

            dataGridViewResultados.DataSource = empleadosFiltrados;
        }
    }
}
