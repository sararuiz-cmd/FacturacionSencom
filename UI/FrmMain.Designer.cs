namespace Proyect_Sencom_Form.UI
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVerGrafico;
        private System.Windows.Forms.Button btnRegistrarFactura;
        private System.Windows.Forms.Button btnPrediccionIA;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblBuscarFactura;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Button btnMostrarFacturas;
        private System.Windows.Forms.ListBox lstFacturas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnVerGrafico = new System.Windows.Forms.Button();
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnPrediccionIA = new System.Windows.Forms.Button();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblBuscarFactura = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.btnMostrarFacturas = new System.Windows.Forms.Button();
            this.lstFacturas = new System.Windows.Forms.ListBox();
            this.panelHeader.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(20, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(400, 20);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario actual:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 55);
            this.panelHeader.TabIndex = 6;
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
            this.lblTitulo.Text = "Menú Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnVerGrafico);
            this.panelBotones.Controls.Add(this.btnRegistrarFactura);
            this.panelBotones.Controls.Add(this.btnPrediccionIA);
            this.panelBotones.Controls.Add(this.btnExportarPdf);
            this.panelBotones.Controls.Add(this.btnVolver);
            this.panelBotones.Location = new System.Drawing.Point(20, 90);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(760, 218);
            this.panelBotones.TabIndex = 0;
            this.panelBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBotones_Paint_1);
            // 
            // btnVerGrafico
            // 
            this.btnVerGrafico.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerGrafico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerGrafico.ForeColor = System.Drawing.Color.White;
            this.btnVerGrafico.Location = new System.Drawing.Point(30, 30);
            this.btnVerGrafico.Name = "btnVerGrafico";
            this.btnVerGrafico.Size = new System.Drawing.Size(320, 45);
            this.btnVerGrafico.TabIndex = 0;
            this.btnVerGrafico.Text = "Ver Gráfico";
            this.btnVerGrafico.UseVisualStyleBackColor = false;
            this.btnVerGrafico.Click += new System.EventHandler(this.btnVerGrafico_Click);
            // 
            // btnRegistrarFactura
            // 
            this.btnRegistrarFactura.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarFactura.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarFactura.Location = new System.Drawing.Point(370, 30);
            this.btnRegistrarFactura.Name = "btnRegistrarFactura";
            this.btnRegistrarFactura.Size = new System.Drawing.Size(320, 45);
            this.btnRegistrarFactura.TabIndex = 1;
            this.btnRegistrarFactura.Text = "Registrar Factura";
            this.btnRegistrarFactura.UseVisualStyleBackColor = false;
            this.btnRegistrarFactura.Click += new System.EventHandler(this.btnRegistrarFactura_Click);
            // 
            // btnPrediccionIA
            // 
            this.btnPrediccionIA.BackColor = System.Drawing.Color.DimGray;
            this.btnPrediccionIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrediccionIA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrediccionIA.ForeColor = System.Drawing.Color.White;
            this.btnPrediccionIA.Location = new System.Drawing.Point(30, 100);
            this.btnPrediccionIA.Name = "btnPrediccionIA";
            this.btnPrediccionIA.Size = new System.Drawing.Size(320, 45);
            this.btnPrediccionIA.TabIndex = 2;
            this.btnPrediccionIA.Text = "Predicción IA";
            this.btnPrediccionIA.UseVisualStyleBackColor = false;
            this.btnPrediccionIA.Click += new System.EventHandler(this.btnPrediccionIA_Click);
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.BackColor = System.Drawing.Color.DimGray;
            this.btnExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportarPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdf.Location = new System.Drawing.Point(370, 100);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(320, 45);
            this.btnExportarPdf.TabIndex = 3;
            this.btnExportarPdf.Text = "Exportar PDF";
            this.btnExportarPdf.UseVisualStyleBackColor = false;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(247, 164);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(230, 36);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Atrás";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblBuscarFactura
            // 
            this.lblBuscarFactura.AutoSize = true;
            this.lblBuscarFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscarFactura.Location = new System.Drawing.Point(20, 325);
            this.lblBuscarFactura.Name = "lblBuscarFactura";
            this.lblBuscarFactura.Size = new System.Drawing.Size(162, 20);
            this.lblBuscarFactura.TabIndex = 5;
            this.lblBuscarFactura.Text = "Buscar factura por ID:";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(188, 325);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(120, 22);
            this.txtBuscarId.TabIndex = 4;
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFactura.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFactura.Location = new System.Drawing.Point(359, 320);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(170, 27);
            this.btnBuscarFactura.TabIndex = 3;
            this.btnBuscarFactura.Text = "Buscar";
            this.btnBuscarFactura.UseVisualStyleBackColor = false;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // btnMostrarFacturas
            // 
            this.btnMostrarFacturas.BackColor = System.Drawing.Color.DimGray;
            this.btnMostrarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFacturas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarFacturas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarFacturas.Location = new System.Drawing.Point(585, 320);
            this.btnMostrarFacturas.Name = "btnMostrarFacturas";
            this.btnMostrarFacturas.Size = new System.Drawing.Size(170, 27);
            this.btnMostrarFacturas.TabIndex = 2;
            this.btnMostrarFacturas.Text = "Mostrar facturas";
            this.btnMostrarFacturas.UseVisualStyleBackColor = false;
            this.btnMostrarFacturas.Click += new System.EventHandler(this.btnMostrarFacturas_Click);
            // 
            // lstFacturas
            // 
            this.lstFacturas.FormattingEnabled = true;
            this.lstFacturas.HorizontalScrollbar = true;
            this.lstFacturas.ItemHeight = 16;
            this.lstFacturas.Location = new System.Drawing.Point(20, 360);
            this.lstFacturas.Name = "lstFacturas";
            this.lstFacturas.Size = new System.Drawing.Size(760, 132);
            this.lstFacturas.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lstFacturas);
            this.Controls.Add(this.btnMostrarFacturas);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.lblBuscarFactura);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
