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
    public partial class FrmAltaRepresentante : Form
    {
        public FrmAltaRepresentante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "INSERT INTO Rep_Ventas (Num_Rep, Nombre, Edad,Titulo,Contrato, Oficina_Rep, Director, Cuota, Ventas, EstadoRep) VALUES ";
            cadenaSQL = cadenaSQL + "( '" + txtNum_Rep.Text + "','" + txtNombre.Text + "','" + txtEdad.Text + "','" + txtTitulo.Text + "','" + txtContrato.Text + "','" + txtOficina.Text + "','" + txtDirector.Text + "','" + txtCuota.Text + "','" + txtVentas.Text + "','" + txtEstado.Text + "');";

            objeto.ejecutar(cadenaSQL);

            //Se despliega el mensaje para indicar que el registro del producto se guarto correctamente
            MessageBox.Show("Producto guardado Correctamente");
            
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

        private void FrmAltaRepresentante_Load(object sender, EventArgs e)
        {

        }
    }
}
