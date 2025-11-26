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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnVerGrafico = new System.Windows.Forms.Button();
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnPrediccionIA = new System.Windows.Forms.Button();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario actual:";
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
            this.btnVerGrafico.TabIndex = 3;
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
            this.btnRegistrarFactura.TabIndex = 2;
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
            this.btnPrediccionIA.TabIndex = 1;
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
            this.btnExportarPdf.TabIndex = 0;
            this.btnExportarPdf.Text = "Exportar PDF";
            this.btnExportarPdf.UseVisualStyleBackColor = false;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 55);
            this.panelHeader.TabIndex = 1;
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
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.button1);
            this.panelBotones.Controls.Add(this.btnExportarPdf);
            this.panelBotones.Controls.Add(this.btnPrediccionIA);
            this.panelBotones.Controls.Add(this.btnRegistrarFactura);
            this.panelBotones.Controls.Add(this.btnVerGrafico);
            this.panelBotones.Location = new System.Drawing.Point(20, 90);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(760, 218);
            this.panelBotones.TabIndex = 0;
            this.panelBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBotones_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(247, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVolver_Click);

            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.panelBotones);
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

        }

        private System.Windows.Forms.Button button1;
    }
}