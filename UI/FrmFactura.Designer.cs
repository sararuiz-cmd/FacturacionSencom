namespace Proyect_Sencom_Form.UI
{
    partial class FrmFactura
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapacidadKw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCliente.Location = new System.Drawing.Point(170, 22);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(220, 30);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccion.Location = new System.Drawing.Point(170, 57);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(220, 30);
            this.txtDireccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacidad (kW):";
            // 
            // txtCapacidadKw
            // 
            this.txtCapacidadKw.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCapacidadKw.Location = new System.Drawing.Point(170, 92);
            this.txtCapacidadKw.Name = "txtCapacidadKw";
            this.txtCapacidadKw.Size = new System.Drawing.Size(100, 30);
            this.txtCapacidadKw.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMeses.Location = new System.Drawing.Point(170, 127);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 30);
            this.txtMeses.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(520, 110);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(120, 35);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.ColumnHeadersHeight = 29;
            this.dgvFacturas.Location = new System.Drawing.Point(20, 255);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.Size = new System.Drawing.Size(660, 198);
            this.dgvFacturas.TabIndex = 2;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.Maroon;
            this.lblMensaje.Location = new System.Drawing.Point(20, 235);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(660, 20);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 55);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generador de Facturas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputs.Controls.Add(this.label1);
            this.panelInputs.Controls.Add(this.txtNombreCliente);
            this.panelInputs.Controls.Add(this.label2);
            this.panelInputs.Controls.Add(this.txtDireccion);
            this.panelInputs.Controls.Add(this.label3);
            this.panelInputs.Controls.Add(this.txtCapacidadKw);
            this.panelInputs.Controls.Add(this.label4);
            this.panelInputs.Controls.Add(this.txtMeses);
            this.panelInputs.Controls.Add(this.btnGenerar);
            this.panelInputs.Location = new System.Drawing.Point(20, 70);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(660, 170);
            this.panelInputs.TabIndex = 0;
            this.panelInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInputs_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFactura
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(700, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generador de Facturas";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacidadKw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button button1;
    }
}