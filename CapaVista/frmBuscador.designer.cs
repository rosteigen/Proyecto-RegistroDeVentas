namespace CapaVista
{
    partial class frmBuscador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxProductoMarca = new System.Windows.Forms.GroupBox();
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gboxColorProveedor = new System.Windows.Forms.GroupBox();
            this.cboxMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxSucursal = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cboxProveedor = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gboxProductoMarca.SuspendLayout();
            this.gboxColorProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(390, 331);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 25);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(483, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gboxProductoMarca
            // 
            this.gboxProductoMarca.AutoSize = true;
            this.gboxProductoMarca.Controls.Add(this.cboxProducto);
            this.gboxProductoMarca.Controls.Add(this.lblProducto);
            this.gboxProductoMarca.Location = new System.Drawing.Point(17, 23);
            this.gboxProductoMarca.Name = "gboxProductoMarca";
            this.gboxProductoMarca.Size = new System.Drawing.Size(269, 80);
            this.gboxProductoMarca.TabIndex = 9;
            this.gboxProductoMarca.TabStop = false;
            this.gboxProductoMarca.Text = "Por Nombre";
            // 
            // cboxProducto
            // 
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Location = new System.Drawing.Point(87, 24);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(164, 21);
            this.cboxProducto.TabIndex = 48;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(33, 27);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 7;
            this.lblProducto.Text = "Producto";
            // 
            // gboxColorProveedor
            // 
            this.gboxColorProveedor.AutoSize = true;
            this.gboxColorProveedor.Controls.Add(this.cboxMetodo);
            this.gboxColorProveedor.Controls.Add(this.lblMetodo);
            this.gboxColorProveedor.Location = new System.Drawing.Point(301, 23);
            this.gboxColorProveedor.Name = "gboxColorProveedor";
            this.gboxColorProveedor.Size = new System.Drawing.Size(269, 65);
            this.gboxColorProveedor.TabIndex = 10;
            this.gboxColorProveedor.TabStop = false;
            this.gboxColorProveedor.Text = "Por Tipo de Pago";
            // 
            // cboxMetodo
            // 
            this.cboxMetodo.FormattingEnabled = true;
            this.cboxMetodo.Location = new System.Drawing.Point(80, 24);
            this.cboxMetodo.Name = "cboxMetodo";
            this.cboxMetodo.Size = new System.Drawing.Size(171, 21);
            this.cboxMetodo.TabIndex = 44;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(31, 26);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(43, 13);
            this.lblMetodo.TabIndex = 43;
            this.lblMetodo.Text = "Metodo";
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(17, 197);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(553, 117);
            this.dgvDatos.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxSucursal);
            this.groupBox1.Controls.Add(this.lblSucursal);
            this.groupBox1.Location = new System.Drawing.Point(17, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Locación";
            // 
            // cboxSucursal
            // 
            this.cboxSucursal.FormattingEnabled = true;
            this.cboxSucursal.Location = new System.Drawing.Point(87, 25);
            this.cboxSucursal.Name = "cboxSucursal";
            this.cboxSucursal.Size = new System.Drawing.Size(164, 21);
            this.cboxSucursal.TabIndex = 46;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(33, 28);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(48, 13);
            this.lblSucursal.TabIndex = 45;
            this.lblSucursal.Text = "Sucursal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProveedor);
            this.groupBox2.Controls.Add(this.cboxProveedor);
            this.groupBox2.Location = new System.Drawing.Point(301, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 65);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Proveedor";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(27, 28);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 31;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cboxProveedor
            // 
            this.cboxProveedor.FormattingEnabled = true;
            this.cboxProveedor.Location = new System.Drawing.Point(89, 25);
            this.cboxProveedor.Name = "cboxProveedor";
            this.cboxProveedor.Size = new System.Drawing.Size(162, 21);
            this.cboxProveedor.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(248, 167);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 25);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 359);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gboxColorProveedor);
            this.Controls.Add(this.gboxProductoMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmBuscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.frmBuscador_Load);
            this.gboxProductoMarca.ResumeLayout(false);
            this.gboxProductoMarca.PerformLayout();
            this.gboxColorProveedor.ResumeLayout(false);
            this.gboxColorProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gboxProductoMarca;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox gboxColorProveedor;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cboxMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cboxProveedor;
        private System.Windows.Forms.ComboBox cboxSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboxProducto;
    }
}