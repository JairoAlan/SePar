using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ventas_Jairo
{
    class BaseSQL
    {
        // Se llama la clase SqlConnection y se instancia en un nuevo objeto llamado "conn"
        // Se requiere agregar la libreria "using System.Data.SqlClient"
        SqlConnection conn = new SqlConnection();

        // Se declara publica la clase BaseSQL, que es la que llamara la conexion

        public BaseSQL() {
            //Invoca el metodo conectar
            conectar();
        }

        // El metodo conectar no devuelve ningun valorpor lo que se declara como vacio (void)
        void conectar()
        {
            // Se asigna a "conn" la cadena de conexion con el servidor de SQL Server
            // "Data Source=nombre del servidor; Initial Catalog=Nombre de la base de datos; User ID=Usuario que se conecta a la BD; Password=Clave del usuario;
            // Persist Security Info=True" indica que se requiere autentificacion
            conn.ConnectionString = "Data Source = JACFO; Initial Catalog = Empresa_jairoACF; User ID = jairoACF; Password = J4ir0280; Persist Security Info = True;";

            // Si el estado de la conexion SQL esta cerrado, se abre
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                // Abre la conexion con el servidor SQL
                conn.Open();
            }
        }

        // Aqui se declaran los metodos mas comunes que se utilizaran en el formulario para no repetir los codigos cada vez que se unen

        //EL metodo "Ejecutar" se usa para ejecutar clausulas (insert, update, delete) pasando la cadena de la sentencia SQL y la conexion al comando "ExecuteNonQuery()"

        public void ejecutar(string Sqltexto)
        {
            SqlCommand comando = new SqlCommand(Sqltexto, conn);
            comando.ExecuteNonQuery();
        }

        // El metodo "ConsultaSQL" se usa para ejecutar clausulas (select) pasando la cadena de la sentencia SQL y la conexion al comando "ExecuteReader()"
        public SqlDataReader ConsultaSQL(string Sqltexto)
        {
            SqlCommand command1 = new SqlCommand(Sqltexto, conn);
            return command1.ExecuteReader();
        }

        // El metodo "LeerDatos" se utiliza para ejecutar una consulta SELECT y obtener los resultados en un objeto BindingSource
        public BindingSource LeerDatos(string Sqltexto)
        {
            BindingSource bindingSource1 = new BindingSource();

            // Se crea un nuevo objeto SqlCommand con la consulta SQL y la conexion establecida.
            SqlCommand command1 = new SqlCommand( Sqltexto, conn);

            //Se crea un objeto SqlDataAdapter para adaptar los resultados de la consulta.
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Se asigna el comando SqlCommand al objeto SqlDataAdapter.
            adapter.SelectCommand = command1;

            //Se crea un nuevo objeto DataTable para almacenar los resultados de la consulta.
            DataTable table = new DataTable();

            //Se establece la configuracion regional del DataTable.
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            //Se llena el DataTable con los resultados de la consulta utilizando el objeto SqlDataAdapter.
            adapter.Fill(table);

            //Se asigna el DataTable al objeto BindingSource.
            bindingSource1.DataSource = table;

            //Se devuelve el objeto BindingSource con los resultados de la consulta.
            return bindingSource1;
        }
        
        //El metodo "LlenarCombo" se usa para leer datos de una consulta select y llenar un objeto ComboBox con los resultados.
        public void llenarcombo(string Sqltexto, ComboBox cmb)
        {
            //Se llama al metodo LeerDatos y se le pasa como argumento la consulta SQL almacenada en la variable Sqltexto.
            //Este metodo ejecuta la consulta SELECT y retorna un objeto BindingSource que contiene los resultados de la consulta.
            cmb.DataSource = LeerDatos(Sqltexto);
        }

        //El metodo "LlenarGrid" se usa para leer datos de una consulta select y llenar un objeto DataGridView con los resultados
        // se pasa la cadena de Texto y el nombre del objeto
        public void llenargrid(string Sqltexto, DataGridView dg)
        {
            dg.DataSource = LeerDatos(Sqltexto);
        }
    }
}
