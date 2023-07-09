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
    public partial class FrmEliminarRepresentante : Form
    {
        public FrmEliminarRepresentante()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "elimina_rep_ventas '" + txtNum_Rep.Text + "','" + txtDirector.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Representante se ELIMINO correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }

            //Se limpian los objetos
            txtNum_Rep.Text = "";
            txtDirector.Text = "";
        }
    }
}
