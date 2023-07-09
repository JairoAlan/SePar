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
    public partial class FrmAltaClientes : Form
    {
        public FrmAltaClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            string cadenaSQL = "";
            cadenaSQL = "INSERT INTO Clientes (Num_Clie, Empresa, Num_Rep,Lim_Cred) VALUES ";
            cadenaSQL = cadenaSQL + "('" + txtnumClie.Text + "','" + txtnomEmp.Text + "','" + txtNum_Rep.Text + "','" + txtlLimi.Text + "');";

            objeto.ejecutar(cadenaSQL);

            //Se despliega el mensaje para indicar que el registro del producto se guarto correctamente
            MessageBox.Show("Producto guardado Correctamente");

            //Se limpian los objetos
            txtnumClie.Text = "";
            txtnomEmp.Text = "";
            txtNum_Rep.Text = "";
            txtlLimi.Text = "";
            
        }

        private void FrmAltaClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
