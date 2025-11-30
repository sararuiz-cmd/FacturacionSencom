using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    partial class FrmEditarFactura
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblProduccion;
        private System.Windows.Forms.TextBox txtProduccion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblMesNombre;
        private System.Windows.Forms.TextBox txtMesNombre;
        private System.Windows.Forms.Label lblMesNumero;
        private System.Windows.Forms.TextBox txtMesNumero;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblProduccion = new System.Windows.Forms.Label();
            this.txtProduccion = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblMesNombre = new System.Windows.Forms.Label();
            this.txtMesNombre = new System.Windows.Forms.TextBox();
            this.lblMesNumero = new System.Windows.Forms.Label();
            this.txtMesNumero = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(20, 100);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(100, 23);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(120, 100);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(300, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.Location = new System.Drawing.Point(20, 140);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(100, 23);
            this.lblCapacidad.TabIndex = 6;
            this.lblCapacidad.Text = "Capacidad kW:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(120, 140);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(150, 22);
            this.txtCapacidad.TabIndex = 7;
            // 
            // lblProduccion
            // 
            this.lblProduccion.Location = new System.Drawing.Point(20, 180);
            this.lblProduccion.Name = "lblProduccion";
            this.lblProduccion.Size = new System.Drawing.Size(100, 23);
            this.lblProduccion.TabIndex = 8;
            this.lblProduccion.Text = "Producción kWh:";
            // 
            // txtProduccion
            // 
            this.txtProduccion.Location = new System.Drawing.Point(120, 180);
            this.txtProduccion.Name = "txtProduccion";
            this.txtProduccion.Size = new System.Drawing.Size(150, 22);
            this.txtProduccion.TabIndex = 9;
            // 
            // lblMonto
            // 
            this.lblMonto.Location = new System.Drawing.Point(20, 220);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(100, 23);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "Monto $:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(120, 220);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 22);
            this.txtMonto.TabIndex = 11;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(20, 260);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha (dd/MM/yyyy):";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(180, 260);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(120, 22);
            this.txtFecha.TabIndex = 13;
            // 
            // lblMesNombre
            // 
            this.lblMesNombre.Location = new System.Drawing.Point(20, 300);
            this.lblMesNombre.Name = "lblMesNombre";
            this.lblMesNombre.Size = new System.Drawing.Size(100, 23);
            this.lblMesNombre.TabIndex = 14;
            this.lblMesNombre.Text = "Mes:";
            // 
            // txtMesNombre
            // 
            this.txtMesNombre.Location = new System.Drawing.Point(120, 300);
            this.txtMesNombre.Name = "txtMesNombre";
            this.txtMesNombre.Size = new System.Drawing.Size(150, 22);
            this.txtMesNombre.TabIndex = 15;
            // 
            // lblMesNumero
            // 
            this.lblMesNumero.Location = new System.Drawing.Point(20, 340);
            this.lblMesNumero.Name = "lblMesNumero";
            this.lblMesNumero.Size = new System.Drawing.Size(100, 23);
            this.lblMesNumero.TabIndex = 16;
            this.lblMesNumero.Text = "Mes #:";
            // 
            // txtMesNumero
            // 
            this.txtMesNumero.Location = new System.Drawing.Point(120, 340);
            this.txtMesNumero.Name = "txtMesNumero";
            this.txtMesNumero.Size = new System.Drawing.Size(100, 22);
            this.txtMesNumero.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(120, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 35);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(253, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmEditarFactura
            // 
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lblProduccion);
            this.Controls.Add(this.txtProduccion);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblMesNombre);
            this.Controls.Add(this.txtMesNombre);
            this.Controls.Add(this.lblMesNumero);
            this.Controls.Add(this.txtMesNumero);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmEditarFactura";
            this.Text = "Editar Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
