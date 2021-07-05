using System;
using System.Data;
using CapaAccesoADatos;



namespace CapaNegocio
{
    public class NE_Productos
    {
        #region ATRIBUTOS

        private string idventa;
        private string idproducto;
        private string idmarca;
        private string precio;
        private string idproveedor;
        private string idsucursal;
        private string idvendedor;
        private string idmetodo;
        private string cantidad;
        private string idcolor;

        private string tabla;
        private string campo;
        private string valor;

        #endregion

        #region PROPERTIES

        public string IdVenta
        {
            set { idventa = value; }
        }
        public string IdProducto
        {
            set { idproducto = value; }
        }
        public string IdMarca
        {
            set { idmarca = value; }
        }
        
        public string Precio
        {
            set { precio = value; }
        }
        public string IdProveedor
        {
            set { idproveedor = value; }
        }
        
        public string IdSucursal
        {
            set { idsucursal = value; }
        }
        
        public string IdVendedor
        {
            set { idvendedor = value; }
        }
       
        public string IdMetodo
        {
            set { idmetodo = value; }
        }
       
        public string Cantidad
        {
            set { cantidad = value; }
        }
        public string IdColor
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


        AD_Productos datos = new AD_Productos();

        #region METODOS

        public void ProductoNuevo()
        {
            PasarDatos();
            datos.NuevaVenta();
        }

        public void ProductoModificado()
        {
            PasarDatos();
            datos.ModificarVenta();
        }

        public void Eliminar()
        {
            datos.IdVenta = Convert.ToInt32(idventa);
            datos.EliminarVenta();
        }

        public void AddRegistro()
        {
            datos.Campo = campo;
            datos.Tabla = tabla;
            datos.Valor = valor;
            datos.AddRegistro();
        }

        public void BorrarRegistro()
        {
            datos.Campo = campo;
            datos.Tabla = tabla;
            datos.Valor = valor;
            datos.BorrarRegistro();
        }
        

        public DataTable BuscarDatos()
        {
            DataTable DT = new DataTable();
            PasarDatos();
            DT = datos.BuscarDatos();
            return DT;
        }
       
        public void PasarDatos()
        {
            datos.IdVenta = Convert.ToInt32(idventa);
            datos.IdProducto = Convert.ToInt32(idproducto);
            datos.Precio = precio;
            datos.Cantidad = Convert.ToInt32(cantidad);
            datos.IdColor = Convert.ToInt32(idcolor);

            datos.IdMarca = Convert.ToInt32(idmarca);

            datos.IdMetodo = Convert.ToInt32(idmetodo);

            datos.IdProveedor = Convert.ToInt32(idproveedor);

            datos.IdSucursal = Convert.ToInt32(idsucursal);

            datos.IdVendedor = Convert.ToInt32(idvendedor);


            
        }

        #endregion
    }
}
