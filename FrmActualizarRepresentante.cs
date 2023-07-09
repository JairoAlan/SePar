using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ventas_Jairo
{
    public partial class FrmActualizarRepresentante : Form
    {
        public FrmActualizarRepresentante()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "ActualizarRepVentas '" + txtNum_Rep.Text + "','" + txtNombre.Text + "','" + txtEdad.Text + "','" + txtTitulo.Text + "','" + txtContrato.Text + "','" + txtCuota.Text + "','" + txtVentas.Text + "','" + txtOficina.Text + "','" + txtEstado.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Representante se actualizo correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }


            //Se limpian los objetos
            txtNum_Rep.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtTitulo.Text = "";
            txtContrato.Text = "";
            txtOficina.Text = "";
            txtEstado.Text = "";
            txtDirector.Text = "";
            txtCuota.Text = "";
            txtVentas.Text = "";
        }
    }
}
