using CapaNegocio;
using System;
using System.Windows.Forms;


namespace CapaVista
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        
        NE_Productos guardar = new NE_Productos();
        
        

        #region EVENTOS



        private void frmProductos_Load(object sender, EventArgs e)
        {
            Herramientas.Deshabilitar(gboxDatos);

            btnGuardar.Enabled = false;
            btnGuardar.Visible = false;
            btnGuardarCambios.Enabled = false;
            btnGuardarCambios.Visible = false;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnModificar.Enabled = false;
            btnModificar.Visible = true;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = true;

            Cargarcbox(cboxMarca, "Id_Marca", "Marcas", "Marca");
            Cargarcbox(cboxColor, "Id_Color", "Colores", "Color");
            Cargarcbox(cboxProveedor, "Id_Proveedor", "Proveedores", "Proveedor");
            Cargarcbox(cboxSucursal, "Id_Sucursal", "Sucursales", "Sucursal");
            Cargarcbox(cboxMetodo, "Id_MetodoDePago", "MetodosDePago", "MetodoDePago");
            Cargarcbox(cboxVendedor, "Id_Vendedor", "Vendedores", "Vendedor");
            Cargarcbox(cboxProducto, "Id_Producto", "Productos", "Producto");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Herramientas.Habilitar(gboxDatos);
            Botones.Buttons(pnlBotones, btnNuevo);
            Herramientas.Limpiar(gboxDatos);
            txtIdVenta.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PasarDatos();
            guardar.ProductoNuevo();
            Herramientas.Deshabilitar(gboxDatos);
            Botones.Buttons(pnlBotones, btnGuardar);
            Herramientas.Limpiar(gboxDatos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Herramientas.Habilitar(gboxDatos);
            Botones.Buttons(pnlBotones, btnModificar);
            txtIdVenta.Enabled = false;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            PasarDatos();
            guardar.ProductoModificado();
            Herramientas.Deshabilitar(gboxDatos);
            Botones.Buttons(pnlBotones, btnGuardarCambios);
            Herramientas.Limpiar(gboxDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el registro?", "ALERTA!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                guardar.IdVenta = txtIdVenta.Text;
                guardar.Eliminar();
                Herramientas.Limpiar(gboxDatos);
            }
            if( resultado == DialogResult.No)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Herramientas.Deshabilitar(gboxDatos);
            Botones.Buttons(pnlBotones, btnCancelar);
            Herramientas.Limpiar(gboxDatos);
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Herramientas.Deshabilitar(gboxDatos);
            
            Botones.Buttons(pnlBotones, btnBuscar);

            frmBuscador frm = new frmBuscador();
            frm.ProductoPasado += new frmBuscador.CargadeProducto(Ejecutar);
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #region EVENTOS ADD

        private void btnAddMarca_Click(object sender, EventArgs e) 
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.GuardarNuevoRegistro(btnAddMarca);
            frmRegistro.ShowDialog();

            Cargarcbox(cboxMarca, "Id_Marca", "Marcas", "Marca");
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.GuardarNuevoRegistro(btnAddColor);
            frmRegistro.ShowDialog();

            Cargarcbox(cboxColor, "Id_Color", "Colores", "Color");
        }

        private void btnAddVendedor_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.GuardarNuevoRegistro(btnAddVendedor);
            frmRegistro.ShowDialog();

            
            Cargarcbox(cboxVendedor, "Id_Vendedor", "Vendedores", "Vendedor");
        }

        private void btnAddSucursal_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.GuardarNuevoRegistro(btnAddSucursal);
            frmRegistro.ShowDialog();

            Cargarcbox(cboxSucursal, "Id_Sucursal", "Sucursales", "Sucursal");
        }

        private void btnAddProveedor_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.GuardarNuevoRegistro(btnAddProveedor);
            frmRegistro.ShowDialog();

            Cargarcbox(cboxProveedor, "Id_Proveedor", "Proveedores", "Proveedor");
           
        }
        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.GuardarNuevoRegistro(btnAddProducto);
            frmRegistro.ShowDialog();

            Cargarcbox(cboxProducto, "Id_Producto", "Productos", "Producto");
        }

        #endregion

        #region EVENTOS ELIMINAR

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.EliminarRegistro(btnBorrarProducto);
            frmRegistro.ShowDialog();
            Cargarcbox(cboxProducto, "Id_Producto", "Productos", "Producto");
        }

        private void btnBorrarSucursal_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.EliminarRegistro(btnBorrarSucursal);
            frmRegistro.ShowDialog();
            Cargarcbox(cboxSucursal, "Id_Sucursal", "Sucursales", "Sucursal");
        }

        private void btnBorrarVendedor_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.EliminarRegistro(btnBorrarVendedor);
            frmRegistro.ShowDialog();
            Cargarcbox(cboxVendedor, "Id_Vendedor", "Vendedores", "Vendedor");
        }

        private void btnBorrarProveedor_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.EliminarRegistro(btnBorrarProveedor);
            frmRegistro.ShowDialog();
            Cargarcbox(cboxProveedor, "Id_Proveedor", "Proveedores", "Proveedor");
        }

        private void btnBorrarMarca_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.EliminarRegistro(btnBorrarMarca);
            frmRegistro.ShowDialog();
            Cargarcbox(cboxMarca, "Id_Marca", "Marcas", "Marca");
        }

        private void btnBorrarColor_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.EliminarRegistro(btnBorrarColor);
            frmRegistro.ShowDialog();
            Cargarcbox(cboxColor, "Id_Color", "Colores", "Color");
        }

        #endregion

        #endregion


        #region METODOS

        public void Cargarcbox(ComboBox cbox, string campoid, string tabla, string campo2, string condicion = "")
        {
            NE_LlenarCombos llenar = new NE_LlenarCombos();

            llenar.CampoId = campoid;
            llenar.Campo2 = campo2;
            llenar.Tabla = tabla;
            llenar.Condicion = condicion;

            cbox.DataSource = llenar.Cargarcbox();
            cbox.DisplayMember = campo2;
            cbox.ValueMember = campoid;
            cbox.SelectedIndex = -1;
        }
        

        public void Ejecutar(string idventa, string idprod, string pre, string cant, string idmarca, string idcolor, string idproveedor, string idsucursal, string idmetodo, string idvendedor)
        {

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;


            Cargarcbox(cboxMarca, "Id_Marca", "Marcas", "Marca");
            Cargarcbox(cboxColor, "Id_Color", "Colores", "Color");
            Cargarcbox(cboxProveedor, "Id_Proveedor", "Proveedores", "Proveedor");
            Cargarcbox(cboxSucursal, "Id_Sucursal", "Sucursales", "Sucursal");
            Cargarcbox(cboxMetodo, "Id_MetodoDePago", "MetodosDePago", "MetodoDePago");
            Cargarcbox(cboxVendedor, "Id_Vendedor", "Vendedores", "Vendedor");
            Cargarcbox(cboxProducto, "Id_Producto", "Productos", "Producto");

            txtIdVenta.Text = idventa;
            cboxProducto.SelectedValue = idprod;
            cboxSucursal.SelectedValue = idsucursal;
            txtPrecio.Text = pre;
            txtCantidad.Text = cant;
            cboxColor.SelectedValue = idcolor;
            cboxProveedor.SelectedValue = idproveedor;
            cboxMetodo.SelectedValue = idmetodo;
            cboxMarca.SelectedValue = idmarca;
            cboxVendedor.SelectedValue = idvendedor;
        }

        private void PasarDatos()
        {
            guardar.Precio = txtPrecio.Text;
            guardar.Cantidad = txtCantidad.Text;
            if (cboxProducto.SelectedItem == null) { guardar.IdProducto = "0"; } else { guardar.IdProducto = cboxProducto.SelectedValue.ToString(); }
            if (cboxColor.SelectedItem == null) { guardar.IdColor = "0"; } else { guardar.IdColor = cboxColor.SelectedValue.ToString(); }
            if (cboxMarca.SelectedItem == null) { guardar.IdMarca = "0"; } else { guardar.IdMarca = cboxMarca.SelectedValue.ToString(); }
            if (cboxSucursal.SelectedItem == null) { guardar.IdSucursal = "0"; } else { guardar.IdSucursal = cboxSucursal.SelectedValue.ToString(); }
            if (cboxVendedor.SelectedItem == null) { guardar.IdVendedor = "0"; } else { guardar.IdVendedor = cboxVendedor.SelectedValue.ToString(); }
            if (cboxProveedor.SelectedItem == null) { guardar.IdProveedor = "0"; } else { guardar.IdProveedor = cboxProveedor.SelectedValue.ToString(); }
            if (cboxMetodo.SelectedItem == null) { guardar.IdMetodo = "0"; } else { guardar.IdMetodo = cboxMetodo.SelectedValue.ToString(); }
        }





        #endregion

        
    }
}
