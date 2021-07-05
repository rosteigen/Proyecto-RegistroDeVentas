using CapaNegocio;
using System;
using System.Windows.Forms;



namespace CapaVista
{

    public partial class frmBuscador : Form
    {
        NE_Productos buscador = new NE_Productos();
        frmVentas frm = new frmVentas();

        public delegate void CargadeProducto(string idventa, string prod, string pre, string cant, string idmarca, string idcolor, string idproveedor,
            string idsucursal, string idmetodo, string idvendedor);
        public event CargadeProducto ProductoPasado;

        public frmBuscador()
        {
            InitializeComponent();
        }



        #region EVENTOS

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PasarAlForm();
            this.Dispose();
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            frm.Cargarcbox(cboxSucursal, "Id_Sucursal", "Sucursales", "Sucursal");
            frm.Cargarcbox(cboxMetodo, "Id_MetodoDePago", "MetodosDePago", "MetodoDePago");
            frm.Cargarcbox(cboxProveedor, "Id_Proveedor", "Proveedores", "Proveedor");
            frm.Cargarcbox(cboxProducto, "Id_Producto", "Productos", "Producto");

            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.ReadOnly = true;
            dgvDatos.MultiSelect = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cboxProducto.SelectedIndex == -1) { buscador.IdProducto = "0"; } else { buscador.IdProducto = cboxProducto.SelectedValue.ToString(); }
            if (cboxMetodo.SelectedIndex == -1) { buscador.IdMetodo = "0"; } else { buscador.IdMetodo = cboxMetodo.SelectedValue.ToString(); }
            if (cboxProveedor.SelectedIndex == -1) { buscador.IdProveedor = "0"; } else { buscador.IdProveedor = cboxProveedor.SelectedValue.ToString(); }
            if (cboxSucursal.SelectedIndex == -1) { buscador.IdSucursal = "0"; } else { buscador.IdSucursal = cboxSucursal.SelectedValue.ToString(); }
            
            
            dgvDatos.DataSource = buscador.BuscarDatos();
        }


       
        #endregion

        #region METODOS


        public void PasarAlForm()
        {

            ProductoPasado(dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_Venta"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_Producto"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Precio"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Cantidad"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_Marca"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_Color"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_Proveedor"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_Sucursal"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_MetodoDePago"].Value.ToString(),
                dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Id_Vendedor"].Value.ToString());
        }

        #endregion

        
    }
}
