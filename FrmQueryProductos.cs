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
    public partial class FrmQueryProductos : Form
    {
        public FrmQueryProductos()
        {
            InitializeComponent();
        }

        private void FrmQueryProductos_Load(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            //llenar el combo de Productos del fabricante
            cmbFab.DataSource = objeto.LeerDatos("Select distinct Id_Fab from Productos");
            cmbFab.DisplayMember = "Id_Fab";
            //llenar el combo de total de inventario por proveedor
            cmbInvProv.DataSource = objeto.LeerDatos("Select distinct Id_Fab from Productos");
            cmbInvProv.DisplayMember = "Id_Fab";

            //Agregar los operadores utilizando el metodo AddRange()
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });
            //0 agregar los operadores uno por uno
            //
            //
            //
            //
            //

            //Establecer un valor predeterminado seleccionado
            cmbOperadores.SelectedIndex =0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListaProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT Id_Fab, Id_Producto, Descripcion, Precio, existencias FROM Productos";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                // Desactivar el checkBox que fue seleccionado
                rbtnListaProd.Checked = false;
                // Habilitar el checbox
                rbtnListaProd.Enabled = true;
            }
            else if (rbtnProdFab.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Productos where Id_Fab='" + cmbFab.Text + "'";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdConExi.Checked = false;
                rbtnProdConExi.Enabled = true;
            }
            else if (rbtnProdConExi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Productos WHERE existencias " + cmbOperadores.Text + " '" + txtProdExi.Text + "'";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdConExi.Checked = false;
                rbtnProdConExi.Enabled =true;
            }
            else if (rbtnTotInv.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT Id_Fab, Id_Producto, Descripcion, Precio, existencias, Precio*existencias as Total FROM Productos";
                objeto.llenargrid(cadenaSQL,dataGridView1);
                rbtnTotInv.Checked = false;
                rbtnTotInv.Enabled = true;
            }
            else if (rbtnTotInvProv.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT Id_Fab, Id_Producto, Descripcion, Precio, existencias, Precio*existencias as Total FROM Productos WHERE Id_Fab = '" + cmbInvProv.Text + "'";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnTotInvProv.Checked = false;
                rbtnTotInvProv.Enabled = true;
            }
            else if (rbtnEdoProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT Id_Producto, Descripcion, CASE WHEN [StatusProd]=1 THEN 'Activo' WHEN [StatusProd]=2 THEN 'Descontinuado' ELSE 'Dañado' END as Estado FROM Productos";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnEdoProd.Checked = false;
                rbtnEdoProd.Enabled = true;
            }
            
        }
    }
}
