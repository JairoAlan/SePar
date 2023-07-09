using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Ventas_Jairo
{
    public partial class frmDescontinuarProd : Form
    {
        public frmDescontinuarProd()
        {
            InitializeComponent();
        }

        private void frmDescontinuarProd_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try //Si la ejecucion se lleva acabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT Id_Fab FROM Productos";
                this.cmbIDFab.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbIDFab.DisplayMember = "Id_Fab";
                cmbIDFab.ValueMember = "Id_Fab";

                // Limpia los valores de los labels

                lblDescripcion.Text = "";
                lblPrecio.Text = "";
                lblCantidad.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbIDFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();

                //Verifica si se ha seleccionado un elemento en el comboBox cmbIDFab
                if (cmbIDFab.SelectedValue != null)
                {
                    //Obtiene el Id_Fab seleccionado
                    string idFab = (string)cmbIDFab.SelectedValue;

                    //Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Id_Producto FROM Productos WHERE Id_Fab = '" + idFab + "' order by Id_Fab";
                    this.cmbIDProd.DataSource = objeto.LeerDatos(cadenaSQL);

                    //Depliega los valores en el comboBox.
                    cmbIDProd.DisplayMember = "Id_Producto";
                    cmbIDProd.ValueMember = "Id_Producto";


                }
                else
                {
                    //Si no se ha seleccionado ningun elemento, realiza alguna accion apropiada
                    //por ejemplo, puedes limpiar el comboBox cmbIDProd o mostrar al usuario.
                    cmbIDProd.DisplayMember = "Selecciona un fabricante";
                }
            }
            catch 
            { 
                
            }
        }

        private void cmbIDProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try //Si la ejecucion se lleva acabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                if(cmbIDFab.SelectedValue != null)
                {
                    if(cmbIDProd.SelectedValue != null)
                    {
                        //llena el comboBox cmbIDProd por medio de la clase leerDatos
                        cadenaSQL = "Select Descripcion, Precio, existencias, StatusProd from Productos Where Id_Fab='" + cmbIDFab.SelectedValue + "' and Id_Producto ='" + cmbIDProd.SelectedValue.ToString() + "'";
                        SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                        if (dr.Read())
                        {
                            //Muestra los valores en los labels de IbIdescripcion, Lblprecio y Lblcantidad, de acuerdo a los valores obtenidos en la consulta

                            // el sqlDataReader guarda los valores obtenidos de la consulta en posiciones o casillas.
                            // en la posicion[0] el valor de la descripcion, en la [1] el precio y en la [2] la cantidad
                            //lblDescripcion.Text = dr[0].ToString();
                            //lblPrecio.Text = dr[1].ToString();
                            //lblCantidad.Text = dr[2].ToString();
                            //Tambien se puede poner directamente el nombre del objeto
                            lblDescripcion.Text = dr["Descripcion"].ToString();
                            lblPrecio.Text = dr["Precio"].ToString();
                            lblExi.Text = dr["existencias"].ToString();
                            if (Convert.ToBoolean(dr["StatusProd"]))
                            {
                                lblSta.Text = "Activo";
                                lblSta.ForeColor = Color.Green; //Color Verde
                            }
                            else
                            {
                                lblSta.Text = "Descontinuado";
                                lblSta.ForeColor = Color.Red; // Color Rojo
                            }
                            lblSta.Font = new Font(lblSta.Font.FontFamily, 14f, FontStyle.Bold); // Establecer una fuente mas Grande y en Negrita
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + " " + cadenaSQL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "exec [dbo].DescProd '" + cmbIDFab.SelectedValue + "', '" + cmbIDProd.SelectedValue + "'";

            try //Si la ejecucion se lleva a cabo correctamente
            {
                objeto.ejecutar(cadenaSQL);

                // Se despliega el mensaje para indicar que el registro del producto se guardo correctamente.
                MessageBox.Show("Produto DESCONTINUADO");
            }
            catch (Exception ex)
            {
                // Muestra el error en el mensaje para ver el error.
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }
        }
    }
}
