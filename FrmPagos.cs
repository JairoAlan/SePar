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
    public partial class FrmPagos : Form
    {
        bool entrar = true;
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_limCred_Click(object sender, EventArgs e)
        {
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string lim_cre;
            lim_cre = txtNumCli.Text;
            SqlDataReader dato = objeto.ConsultaSQL("Select Lim_Cred From Clientes WHERE Num_Clie ='" + lim_cre + "'");
            try
            {
                dato.Read();               
                lbl_limCred.Text = dato["Lim_Cred"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
