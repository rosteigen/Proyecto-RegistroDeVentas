using System.Data.OleDb;
using System.Data;


namespace CapaAccesoADatos
{
    public class AD_LlenarCombos
    {

        #region ATRIBUTOS

        private string campoid;
        private string tabla;
        private string campo2;
        private string condicion;
        #endregion

        #region PROPERTIES

        public string CampoId
        {
            set { campoid = value; }
        }

        public string Tabla
        {
            set { tabla = value; }
        }

        public string Campo2
        {
            set { campo2 = value; }
        }
        
        public string Condicion
        {
            set { condicion = value; }
        }
        #endregion

        #region METODOS

        private DataTable DTcbox = new DataTable();

        public DataTable cargarcbox()
        {
            
            string sql;

            if (condicion == "") 
            { 
                sql = "Select " + campoid + ", " + campo2 + " from " + tabla;
            }
            else
            {
                sql = "Select " + campoid + ", " + campo2 + " from " + tabla;
            }

            AD_Conexion CN = new AD_Conexion();
            OleDbCommand cmd = new OleDbCommand(sql, CN.AbrirConexion());
            OleDbDataReader DR = cmd.ExecuteReader();
            DTcbox.Load(DR);
            CN.CerrarConexion();

            return DTcbox;
        }
        #endregion
    }
}
