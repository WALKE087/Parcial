using Newtonsoft.Json;
using ParcialNomina.CapaDatos;
using ParcialNomina.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialNomina
{
    public partial class Form1 : Form
    {
        private List<DatosEmpleado> listaEmpleados;

        public Form1()
        {
            InitializeComponent();
            string archivoEmpleados = "empleados.json";

            if (File.Exists(archivoEmpleados))
            {
                string datosJson = File.ReadAllText(archivoEmpleados);
                listaEmpleados = JsonConvert.DeserializeObject<List<DatosEmpleado>>(datosJson);
            }
            else
            {
                listaEmpleados = new List<DatosEmpleado>(); // Crear una lista vacía si el archivo no existe
            }
        }

        private void btnAbrirRegistroEmpleado_Click(object sender, EventArgs e)
        {

            FormularioRegistroEmpleado registroForm = new FormularioRegistroEmpleado();

            registroForm.Show();

        }

        private void btnAbrirConsultaEmpleados_Click(object sender, EventArgs e)
        {
            FormularioConsultaEmpleados consultaForm = new FormularioConsultaEmpleados(listaEmpleados);

            consultaForm.Show();
        }
    }
}
