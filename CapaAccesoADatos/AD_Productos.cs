using System.Data;
using System.Data.OleDb;

namespace CapaAccesoADatos
{
    public class AD_Productos
    {
        #region ATRIBUTOS

        private int idventa;
        private int idproducto;
        private int idmarca;
        private string precio;
        private int idproveedor;
        private int idsucursal;
        private int idvendedor;
        private int idmetodo;
        private int cantidad;
        private int idcolor;
        


        private string tabla;
        private string campo;
        private string valor;

        #endregion

        #region PROPERTIES

        public int IdVenta
        {
            set { idventa = value; }
        }
        public int IdProducto
        {
            set { idproducto = value; }
        }
        public int IdMarca
        {
            set { idmarca = value; }
        }
        
        public string Precio
        {
            set { precio = value; }
        }
        public int IdProveedor
        {
            set { idproveedor = value; }
        }
        
        public int IdSucursal
        {
            set { idsucursal = value; }
        }
        
        public int IdVendedor
        {
            set { idvendedor = value; }
        }
        
        public int IdMetodo
        {
            set { idmetodo = value; }
        }
       
        public int Cantidad
        {
            set { cantidad = value; }
        }
        public int IdColor
        {
            set { idcolor = value; }
        }
        
        public string Tabla
        {
            set { tabla = value; }
        }
        public string Campo
        {
            set { campo = value; }
        }
        public string Valor
        {
            set { valor = value; }
        }
       
        #endregion

        #region METODOS

        DataTable DT = new DataTable();
        AD_Conexion CN = new AD_Conexion();
        

        public void NuevaVenta()
        {
            string sql = "Insert into Ventas " + "(Id_Producto, Id_Marca, Id_Color, Precio, Cantidad, Id_MetodoDePago, Id_Vendedor, Id_Sucursal, Id_Proveedor)" + 
                " values " + "('" + idproducto + "','" + idmarca + "','" + idcolor + "','" + precio.Trim() + "','" + cantidad + "','" + idmetodo + "','" + idvendedor +
                "','" + idsucursal + "','" + idproveedor + "')";
            Ejecutar(sql);
        }

        public void ModificarVenta()
        {
            string sql = "UPDATE Ventas set " +
                "Id_Producto = " + idproducto + ", Id_Marca = " + idmarca + ", Id_Color = " + idcolor + ", Precio = " + precio + ", Cantidad = " + cantidad +
                ", Id_MetodoDePago = " + idmetodo + ", Id_Vendedor = " + idvendedor + ", Id_Sucursal = " + idsucursal + ", Id_Proveedor = " + idproveedor +
                " where Id_Venta = " + idventa;
            Ejecutar(sql);
        }

        public void EliminarVenta()
        {
            string sql = "Delete from Ventas where Id_Venta = " + idventa;
            Ejecutar(sql);
        }
        public void Ejecutar(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, CN.AbrirConexion());
            cmd.ExecuteNonQuery();
            CN.CerrarConexion();
        }

        public DataTable BuscarDatos()
        {
            string condicion = null;
            string sql = "SELECT * from Ventas ";

            if (idproducto != 0) { condicion = " Ventas.Id_Producto = " + idproducto; }

            if (idmetodo != 0) { condicion = " Ventas.Id_MetodoDePago = " + idmetodo; }

            if (idsucursal != 0) { condicion = " Ventas.Id_Sucursal = " + idsucursal; }
            
            if (idproveedor != 0) { condicion = " Ventas.Id_Proveedor = " + idproveedor; }

            if (condicion != null) { sql += " where " + condicion; }
            
            DT.Clear();
            OleDbCommand cmd = new OleDbCommand(sql, CN.AbrirConexion());
            OleDbDataReader DR = cmd.ExecuteReader();
            DT.Load(DR);
            CN.CerrarConexion();
            return DT;
        }

        public void AddRegistro()
        {
            string sql = "Insert into " + tabla + " (" + campo + ") values ('" + valor + "')";
            Ejecutar(sql);
        }

        public void BorrarRegistro()
        {
            string sql = "Delete from " + tabla + " where Id_" + campo + " = " + valor;
            Ejecutar(sql);
        }


        #endregion
    }
}
