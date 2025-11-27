namespace Proyect_Sencom_Form.UI
{
    partial class FrmFactura
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;

        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidadKw;

        private System.Windows.Forms.Label lblProduccion;
        private System.Windows.Forms.TextBox txtProduccion;

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnAtras;

        private System.Windows.Forms.Label lblMensaje;

        private System.Windows.Forms.DataGridView dgvFacturas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidadKw = new System.Windows.Forms.TextBox();
            this.lblProduccion = new System.Windows.Forms.Label();
            this.txtProduccion = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Factura";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputs.Controls.Add(this.label1);
            this.panelInputs.Controls.Add(this.txtMeses);
            this.panelInputs.Controls.Add(this.lblNombreCliente);
            this.panelInputs.Controls.Add(this.txtNombreCliente);
            this.panelInputs.Controls.Add(this.lblDireccion);
            this.panelInputs.Controls.Add(this.txtDireccion);
            this.panelInputs.Controls.Add(this.lblCapacidad);
            this.panelInputs.Controls.Add(this.txtCapacidadKw);
            this.panelInputs.Controls.Add(this.lblProduccion);
            this.panelInputs.Controls.Add(this.txtProduccion);
            this.panelInputs.Controls.Add(this.btnGenerar);
            this.panelInputs.Controls.Add(this.btnAtras);
            this.panelInputs.Location = new System.Drawing.Point(20, 70);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(760, 160);
            this.panelInputs.TabIndex = 1;
            this.panelInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInputs_Paint);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 15);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(160, 25);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(190, 12);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(180, 22);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(20, 50);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(160, 25);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(190, 47);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(180, 22);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.Location = new System.Drawing.Point(20, 85);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(160, 25);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "Capacidad (kW):";
            // 
            // txtCapacidadKw
            // 
            this.txtCapacidadKw.Location = new System.Drawing.Point(190, 82);
            this.txtCapacidadKw.Name = "txtCapacidadKw";
            this.txtCapacidadKw.Size = new System.Drawing.Size(120, 22);
            this.txtCapacidadKw.TabIndex = 5;
            // 
            // lblProduccion
            // 
            this.lblProduccion.Location = new System.Drawing.Point(400, 15);
            this.lblProduccion.Name = "lblProduccion";
            this.lblProduccion.Size = new System.Drawing.Size(160, 25);
            this.lblProduccion.TabIndex = 6;
            this.lblProduccion.Text = "Producción (kWh):";
            // 
            // txtProduccion
            // 
            this.txtProduccion.Location = new System.Drawing.Point(570, 12);
            this.txtProduccion.Name = "txtProduccion";
            this.txtProduccion.Size = new System.Drawing.Size(150, 22);
            this.txtProduccion.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(400, 115);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(160, 30);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Registrar Factura";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.DimGray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(580, 115);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(140, 30);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Location = new System.Drawing.Point(20, 240);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(760, 25);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.ColumnHeadersHeight = 29;
            this.dgvFacturas.Location = new System.Drawing.Point(20, 270);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.Size = new System.Drawing.Size(760, 220);
            this.dgvFacturas.TabIndex = 3;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(570, 52);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(150, 22);
            this.txtMeses.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Meses de operación:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmFactura
            // 
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMeses;
    }
}
