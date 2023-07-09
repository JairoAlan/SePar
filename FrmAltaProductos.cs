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
    public partial class FrmAltaProductos : Form
    {
        public FrmAltaProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            //Llamada a la conexion de la base de datos que se encuentra en la clase BaseSQL, se instancia para su uso.
            BaseSQL objeto = new BaseSQL();

            //Se declara la variable cadena que contendra la sentencia de sql a ejecutar:
            //Los objetos alfanumericos se declaran como '" + txtIDFab.Text + "'
            //Los objetos numericos se declaran como '" + nudPre.Value + "'
            // Se usa el signo "+" para concatenar el sql con los objetos de los cuales se extraeran los valores.

            string cadenaSQL = "";
            cadenaSQL = "INSERT INTO PRODUCTOS (ID_FAB, ID_PRODUCTO, DESCRIPCION,PRECIO,EXISTENCIAS) VALUES ";
            cadenaSQL = cadenaSQL + "('" + txtIDFab.Text + "','" + txtIDProd.Text + "','" + txtDes.Text + "'," + txtPre.Value + "," + txtExi.Value + ");";

            //Se llama el metodo ejecutar que se encuentra en la clase "BaseSQL" y se le pasa el parametro con la cadena que contiene el codigo sql
            objeto.ejecutar(cadenaSQL);

            //Se despliega el mensaje para indicar que el registro del producto se guarto correctamente
            MessageBox.Show("Producto guardado Correctamente");

            //Se limpian los objetos
            txtIDFab.Text = "";
            txtIDProd.Text = "";
            txtDes.Text = "";
            txtPre.Value = 0;
            txtExi.Value = 0;
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            decimal precio = txtPre.Value; //Obtener el valor decimal del control NumericUpDown
            cadenaSQL = "Insertar_Producto '" + txtIDFab.Text + "','" + txtIDProd.Text + "','" + txtDes.Text + "'," + precio.ToString("0.00") + "," + txtExi.Value + "";

            try //Si la ejecucion se lleva acabo correctamente
            {
                objeto.ejecutar(cadenaSQL);

                //Se despliega el mensaje para indicar que el registro del producto se guaro correctamente
                MessageBox.Show("Producto guardado correctamente!");
            }
            catch(Exception ex)  
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }

            //Se limpian los objetos
            txtIDFab.Text = "";
            txtIDProd.Text = "";
            txtDes.Text = "";
            txtPre.Value = 0;
            txtExi.Value = 0;


        }

        private void txtPre_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
