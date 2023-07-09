using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Jairo
{
    public partial class FrmActualizarClientes : Form
    {
        public FrmActualizarClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            string cadenaSQL = "";
            cadenaSQL = "EXEC ActualizarClientes '" + txtnumClie.Text + "','" + txtEmp.Text + "','" + txtNum_Rep.Text + "','" + txtLim.Text + "' ";
            
            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Cliente se Actualizo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }
            
            //Se limpian los objetos
            txtnumClie.Text = "";
            txtEmp.Text = "";
            txtNum_Rep.Text = "";
            txtLim.Text = "";
        }
    }
}
