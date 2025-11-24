using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    partial class FrmPrediccionIA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtMesPrediccion;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Button btnPredecir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelContenido;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrediccionIA));
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtMesPrediccion = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.btnPredecir = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCliente.Location = new System.Drawing.Point(160, 17);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 25);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtMesPrediccion
            // 
            this.txtMesPrediccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMesPrediccion.Location = new System.Drawing.Point(160, 52);
            this.txtMesPrediccion.Name = "txtMesPrediccion";
            this.txtMesPrediccion.Size = new System.Drawing.Size(200, 25);
            this.txtMesPrediccion.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResultado.Location = new System.Drawing.Point(160, 132);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(200, 25);
            this.txtResultado.TabIndex = 7;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.Maroon;
            this.lblMensaje.Location = new System.Drawing.Point(20, 270);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(380, 25);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntrenar.ForeColor = System.Drawing.Color.White;
            this.btnEntrenar.Location = new System.Drawing.Point(160, 90);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(95, 30);
            this.btnEntrenar.TabIndex = 4;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = false;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click);
            // 
            // btnPredecir
            // 
            this.btnPredecir.BackColor = System.Drawing.Color.DimGray;
            this.btnPredecir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredecir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPredecir.ForeColor = System.Drawing.Color.White;
            this.btnPredecir.Location = new System.Drawing.Point(265, 90);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(95, 30);
            this.btnPredecir.TabIndex = 5;
            this.btnPredecir.Text = "Predecir";
            this.btnPredecir.UseVisualStyleBackColor = false;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(20, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(119, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nombre Cliente:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMes.Location = new System.Drawing.Point(20, 55);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(114, 19);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "Mes a Predecir:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(20, 135);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 19);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(420, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(420, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Predicción IA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenido.Controls.Add(this.lblCliente);
            this.panelContenido.Controls.Add(this.txtNombreCliente);
            this.panelContenido.Controls.Add(this.lblMes);
            this.panelContenido.Controls.Add(this.txtMesPrediccion);
            this.panelContenido.Controls.Add(this.btnEntrenar);
            this.panelContenido.Controls.Add(this.btnPredecir);
            this.panelContenido.Controls.Add(this.lblResultado);
            this.panelContenido.Controls.Add(this.txtResultado);
            this.panelContenido.Location = new System.Drawing.Point(20, 65);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(380, 200);
            this.panelContenido.TabIndex = 0;
            // 
            // FrmPrediccionIA
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(420, 310);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrediccionIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Predicción IA";
            this.Load += new System.EventHandler(this.FrmPrediccionIA_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}