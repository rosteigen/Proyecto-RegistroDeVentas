using System.Data;
using System.Data.OleDb;



namespace CapaAccesoADatos
{
    public class AD_Conexion
    {
        #region METODOS

        private OleDbConnection CN = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =|DataDirectory|DBFinal.accdb");

        public OleDbConnection AbrirConexion()
        {
            if (CN.State == ConnectionState.Open)
            {
                CN.Close();
            }
            CN.Open();
            return CN;
        }

        public OleDbConnection CerrarConexion()
        {
            CN.Close();
            return CN;
        }


        #endregion
    }
}
