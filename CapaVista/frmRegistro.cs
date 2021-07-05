using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaVista
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        NE_Productos guardar = new NE_Productos();

        #region EVENTOS

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRegistro.Enabled == true)
            {
                guardar.Valor = txtRegistro.Text;
                guardar.AddRegistro();
            }
            if (cbox.Enabled == true)
            {
                guardar.Valor = cbox.SelectedValue.ToString();
                guardar.BorrarRegistro();
            }

            this.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        #endregion

        #region METODOS

        public void EliminarRegistro(Button btn)
        {
            cbox.Enabled = true;
            cbox.Visible = true;
            txtRegistro.Enabled = false;
            txtRegistro.Visible = false;

            frmVentas frm = new frmVentas();

            if (btn.Name == "btnBorrarProducto")
            {
                lblRegistro.Text = "Seleccione Producto a eliminar";
                frm.Cargarcbox(cbox, "Id_Producto", "Productos", "Producto");
                guardar.Tabla = "Productos";
                guardar.Campo = "Producto";
            }
            if (btn.Name == "btnBorrarMarca")
            {
                lblRegistro.Text = "Seleccione Marca a eliminar";
                frm.Cargarcbox(cbox, "Id_Marca", "Marcas", "Marca");
                guardar.Tabla = "Marcas";
                guardar.Campo = "Marca";
            }
            if (btn.Name == "btnBorrarProveedor")
            {
                lblRegistro.Text = "Seleccione Proveedor a eliminar";
                frm.Cargarcbox(cbox, "Id_Proveedor", "Proveedores", "Proveedor");
                guardar.Tabla = "Proveedores";
                guardar.Campo = "Proveedor";
            }
            if (btn.Name == "btnBorrarSucursal")
            {
                lblRegistro.Text = "Seleccione Sucursal a eliminar";
                frm.Cargarcbox(cbox, "Id_Sucursal", "Sucursales", "Sucursal");
                guardar.Tabla = "Sucursales";
                guardar.Campo = "Sucursal";
            }
            if (btn.Name == "btnBorrarVendedor")
            {
                lblRegistro.Text = "Seleccione Vendedor a eliminar";
                frm.Cargarcbox(cbox, "Id_Vendedor", "Vendedores", "Vendedor");
                guardar.Tabla = "Vendedores";
                guardar.Campo = "Vendedor";
            }
            if (btn.Name == "btnBorrarColor")
            {
                lblRegistro.Text = "Seleccione Color a eliminar";
                frm.Cargarcbox(cbox, "Id_Color", "Colores", "Color");
                guardar.Tabla = "Colores";
                guardar.Campo = "Color";
            }
        }



        public void GuardarNuevoRegistro(Button btn)
        {
            txtRegistro.Enabled = true;
            txtRegistro.Visible = true;
            cbox.Enabled = false;
            cbox.Visible = false;

            if (btn.Name == "btnAddMarca")
            {
                lblRegistro.Text = "Ingrese nueva marca";
                guardar.Campo = "Marca";
                guardar.Tabla = "Marcas";
            }

            if (btn.Name == "btnAddProveedor")
            {
                lblRegistro.Text = "Ingrese nuevo proveedor";
                guardar.Campo = "Proveedor";
                guardar.Tabla = "Proveedores";
            }

            if (btn.Name == "btnAddSucursal")
            {
                lblRegistro.Text = "Ingrese nueva sucursal";
                guardar.Campo = "Sucursal";
                guardar.Tabla = "Sucursales";
            }

            if (btn.Name == "btnAddVendedor")
            {
                lblRegistro.Text = "Ingrese nuevo vendedor";
                guardar.Campo = "Vendedor";
                guardar.Tabla = "Vendedores";
            }

            if (btn.Name == "btnAddColor")
            {
                lblRegistro.Text = "Ingrese nuevo color";
                guardar.Campo = "Color";
                guardar.Tabla = "Colores";
            }

            if (btn.Name == "btnAddProducto")
            {
                lblRegistro.Text = "Ingrese nuevo producto";
                guardar.Campo = "Producto";
                guardar.Tabla = "Productos";
            }
        }

        #endregion

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
