using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Jairo
{
    public partial class frmpedido : Form
    {
        bool cargado = false;
        double Preciouni = 0;
        public frmpedido()
        {
            InitializeComponent();
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void frmpedido_Load(object sender, EventArgs e)
        {
            BaseSQL datos = new BaseSQL();

            cmbventas.DataSource = datos.LeerDatos("Select * from [Empresa_jairoACF].[dbo].[Rep_Ventas]");
            cmbventas.DisplayMember = "Nombre";
            cmbventas.ValueMember = "Num_Rep";
            cargado = true;
        }

        private void dgdetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.dgdetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetalles_CellEndEdit);
            

            // Verificar qué columna ha sido editada
            if (e.ColumnIndex == 1)
            {
                string valor, valor2;
                string descripcion;
                double precio;
                double Preciouni = 0;
                BaseSQL enlace = new BaseSQL();
                SqlDataReader dato = enlace.ConsultaSQL("SELECT Descripcion,Precio FROM Productos WHERE Id_Fab='" + idfab + "' AND Id_Producto='" + Idproducto + "'");
                if (dato.Read())
                {
                    valor = dgdetalles.CurrentRow.Cells[0].Value.ToString();
                    valor2 = dgdetalles.CurrentRow.Cells[1].Value.ToString();
                    descripcion = dato.GetString(0); // descripción en campo 0 y el precio en el campo 1
                    dgdetalles.CurrentRow.Cells[3].Value = descripcion;
                    precio = dato.GetSqlMoney(1).ToDouble();
                    dgdetalles.CurrentRow.Cells[4].Value = precio;
                }
                else
                {
                    dgdetalles.CurrentRow.Cells[1].Value = "";
                    dgdetalles.CurrentRow.Cells[2].Value = "";
                    dgdetalles.CurrentRow.Cells[3].Value = 0;
                    dgdetalles.CurrentRow.Cells[4].Value = 0;
                }
            }
            else if (e.ColumnIndex == 2)
            {
                try
                {
                    object cantidad = dgdetalles.CurrentRow.Cells[2].Value;
                    double precio = Double.Parse(dgdetalles.CurrentRow.Cells[4].Value.ToString());
                    dgdetalles.CurrentRow.Cells[5].Value = precio * Double.Parse(cantidad.ToString());
                    double resul = dgdetalles.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells[5].Value));
                    txttotal.Text = Convert.ToString(resul);
                }
                catch (Exception x)
                {
                    // Manejo de excepción
                }
            }
        }


        private void dgdetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dgdetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetalles_CellEndEdit);
            //if (e.ColumnIndex == 1)
            //{
            //    BaseSQL enlace = new BaseSQL();
            //    string valor, valor2;
            //    valor = (dgdetalles.CurrentRow.Cells[0].Value.ToString());
            //    valor2 = (dgdetalles.CurrentRow.Cells[1].Value.ToString());
            //    double precio;
            //    SqlDataReader dato = enlace.ConsultaSQL("SELECT Descripcion,Precio FROM Productos WHERE Id_Fab='" + idfab + "' AND Id_Producto='" + Idproducto + "'");
            //    if (dato.Read())
            //    {
            //        dgdetalles.CurrentRow.Cells[3].Value = dato.GetString(0); // Descripcion en campo 0 y el precio en el campo 1
            //        precio = dato.GetSqlMoney(1).ToDouble();
            //        dgdetalles.CurrentRow.Cells[4].Value = precio;
            //    }
            //    else
            //    {
            //        dgdetalles.CurrentRow.Cells[1].Value = "";
            //        dgdetalles.CurrentRow.Cells[2].Value = "";
            //        dgdetalles.CurrentRow.Cells[3].Value = 0;
            //        dgdetalles.CurrentRow.Cells[4].Value = 0;
            //    }
            //}
            //else if (e.ColumnIndex == 2)
            //{
            //    double precio;
            //    try
            //    {
            //        object cantidad = dgdetalles.CurrentRow.Cells[2].Value;
            //        precio = Double.Parse(dgdetalles.CurrentRow.Cells[4].Value.ToString());
            //        dgdetalles.CurrentRow.Cells[5].Value = precio * Double.Parse(txttotal.ToString());
            //        double resul = dgdetalles.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells[5].Value));
            //        cantidad = Convert.ToString(resul);
            //    }
            //    catch (Exception x)
            //    {
            //        MessageBox.Show(x.Message);
            //    }
            //}
        }

        

        private void cmbventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                BaseSQL enlace = new BaseSQL();
                string numempleado;
                numempleado = (cmbventas.SelectedValue.ToString());
                SqlDataReader dato = enlace.ConsultaSQL("SELECT Oficina_Rep FROM Rep_Ventas WHERE Num_Rep='" + numempleado + "'");
                try
                {
                    dato.Read();
                    int oficina = dato.GetInt32(0);
                    lbloficina.Text = oficina.ToString();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BaseSQL datos = new BaseSQL();
            datos.ejecutar("exec AltasPedidos " + txtnumped.Text + ", '" + dtFechapedido.Value.ToShortDateString() + "'," + txtnumcliente.Text + "," + cmbventas.SelectedValue + "," + txttotal.Text + "," + lbloficina.Text);
            for (int i = 0; i < dgdetalles.Rows.Count - 1; i++)
            {
                string idfab = (string)dgdetalles.Rows[i].Cells[0].Value;
                string codigo = (string)dgdetalles.Rows[i].Cells[1].Value;
                string cantidad = (string)dgdetalles.Rows[i].Cells[2].Value;
                string precio = dgdetalles.Rows[i].Cells[4].Value.ToString();
                datos.ejecutar("exec AltasPedidosDetalles " + txtnumped.Text + ", '" + idfab + "', '" + codigo + "'," + cantidad + "," + precio);
            }
        }

        private void txtnumped_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
