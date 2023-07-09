using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Jairo
{
    public partial class FrmActualizarProducto : Form
    {
        public FrmActualizarProducto()
        {
            InitializeComponent();
        }
        //Al cargar el formulario.
        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try //Si la ejecicion se lleva a cabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT Id_Fab FROM Productos";
                this.cmbIDFab.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbIDFab.DisplayMember = "Id_Fab";
                cmbIDFab.ValueMember = "Id_Fab";

                //Limpia los valores de los labels
                txtDes.Text = "";
                nudPre.Text = "";
                nudExi.Text = "";
            }
            catch (Exception ex)
            {

            }

        }
        //Cuando cambie el combo del fabricante.
        private void cmbIDFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try //Si la ejecucion se lleva a cabo.
            {
                BaseSQL objeto = new BaseSQL();

                // Verificar si se ha seleccionado un elemento en el ComboBox cmbIDFab
                if(cmbIDFab.SelectedValue != null)
                {
                    //Obtiene el Id_Fab seleccionado
                    string idFab = (string)cmbIDFab.SelectedValue;

                    //Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Id_Producto FROM Productos WHERE Id_Fab = '" + idFab + "' order by Id_Fab";
                    this.cmbIDProd.DataSource = objeto.LeerDatos(cadenaSQL);

                    //Despliega los valores en el comboBox.
                    cmbIDProd.DisplayMember = "Id_Producto";
                    cmbIDProd.ValueMember = "Id_Producto";
                }
                else
                {
                    // Si no se ha seleccionado ningun elemento, realiza alguna accion apropiada.
                    // por ejemplo, puedes limpiar el ComboBox cmbIDProd o mostrar un mensaje al usuario.
                    cmbIDProd.DisplayMember = "Selecciona un fabricante";
                }

            }catch (Exception ex)
            {

            }
        }

        //Cuando cambia el combo del producto.
        private void cmbIDProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try // Si la ejecucion se lleva a acabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                if(cmbIDFab.SelectedValue != null)
                {
                    if(cmbIDProd.SelectedValue != null)
                    {
                        //llena el comboBox cmbIDProd por medio de la clase leerDatos.
                        cadenaSQL = "SELECT Descripcion, Precio, existencias, StatusProd from Productos WHERE Id_Fab ='" + cmbIDFab.SelectedValue + "' and Id_Producto ='" + cmbIDProd.SelectedValue.ToString() + "'";
                        SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                        if (dr.Read())
                        {
                            txtDes.Text = dr["Descripcion"].ToString();
                            nudPre.Value = (decimal)dr["Precio"];
                            nudExi.Value = (int)dr["existencias"];
                            if (Convert.ToBoolean(dr["StatusProd"]))
                            {
                                lblStatus.Text = "ACTIVO";
                                lblStatus.ForeColor = Color.Green; // Color Verde
                            }
                            else
                            {
                                lblStatus.Text = "DESCONTINUADO";
                                lblStatus.ForeColor = Color.Red; // Color Rojo
                            }
                            lblStatus.Font = new Font(lblStatus.Font.FontFamily, 14f, FontStyle.Bold); //Establece una fuente mas grande y en negrita
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                //Muestra el error en el mensaje para ver el error.
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + " " + cadenaSQL);
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            //El nombre del procedimiento sera el que nosotros pusimos, en este caso es: ActualizaProductos
            cadenaSQL = "exec ActualizaProductos '" + cmbIDFab.SelectedValue + "','" + cmbIDProd.SelectedValue + "','" + txtDes.Text + "', " + nudPre.Value + "," + nudExi.Value + "";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("Producto actualizado correctamente");
            }
            catch(Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }
        }

        private void lbllDes_Click(object sender, EventArgs e)
        {

        }
    }
}
