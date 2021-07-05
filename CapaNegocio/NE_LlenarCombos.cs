using CapaAccesoADatos;
using System.Data;

namespace CapaNegocio
{
    public class NE_LlenarCombos
    {
        private AD_LlenarCombos cargacbox = new AD_LlenarCombos();

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

        public DataTable Cargarcbox()
        {
            cargacbox.CampoId = campoid;
            cargacbox.Tabla = tabla;
            cargacbox.Campo2 = campo2;
            cargacbox.Condicion = condicion;

            DataTable DT = new DataTable();
            DT = cargacbox.cargarcbox();
            return DT;
        }
        



        #endregion
    }
}
