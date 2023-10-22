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
using static ParcialNomina.CapaDatos.DatosEmpleado;

namespace ParcialNomina.CapaPresentacion
{
    public partial class FormularioRegistroEmpleado : Form
    {
        public FormularioRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            string nombre = txtNombre.Text;
            if ( string.IsNullOrEmpty( identificacion ) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Porfavor, complete todos los campos. ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if( decimal.TryParse(txtSalarioBase.Text, out decimal salarioBase))
            {
                string estado = cboEstado.Text;
                if (estado == "activo" || estado == "inactivo")
                {
                    DatosEmpleado nuevoEmpleado = new DatosEmpleado
                    {
                        Identificacion = identificacion,
                        Nombre = nombre,
                        SalarioBase = salarioBase,
                        Estado = estado
                    };

                    GestorEmpleados.GuardarEmpleado(nuevoEmpleado);

                    txtIdentificacion.Clear();
                    txtNombre.Clear();
                    txtSalarioBase.Clear();
                    cboEstado.SelectedIndex = -1;

                    MessageBox.Show("Empleado registrado con éxito. ", "éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("El Estado debe ser 'Activo' o 'Inactivo'.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El Salario base invalido. Ingrese un numero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private static void IngresarLetra(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private static void IngresarNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresarNumero(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresarLetra(e);
        }

        private void txtSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresarNumero(e);
        }

        private void cboEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresarLetra(e);
        }
    }
}
