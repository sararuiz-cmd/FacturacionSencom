using FacturacionSencom;
using Proyect_Sencom_Form.Business;
using Proyect_Sencom_Form.Domain;
using System;
using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmFactura : Form
    {
        private readonly FacturaController _controller;

        public FrmFactura(FacturaController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);

            dgvFacturas.AutoGenerateColumns = true;
            dgvFacturas.DataSource = _controller.ObtenerTodasLasFacturas();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidadorFactura.EsNombreValido(txtNombreCliente.Text))
                {
                    MostrarError("Nombre inválido.");
                    return;
                }

                if (!ValidadorFactura.EsDireccionValida(txtDireccion.Text))
                {
                    MostrarError("Dirección inválida.");
                    return;
                }

                if (!ValidadorFactura.EsDecimalPositivo(txtCapacidadKw.Text, out double capacidad))
                {
                    MostrarError("Capacidad inválida.");
                    return;
                }

                if (!ValidadorFactura.EsEnteroPositivo(txtMeses.Text, out int meses))
                {
                    MostrarError("Meses inválidos.");
                    return;
                }

                Cliente cli = new Cliente
                {
                    IdCliente = new Random().Next(1, 99999),
                    Nombre = txtNombreCliente.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };

                _controller.GenerarFacturasSimuladas(
                    cli,
                    capacidad,
                    meses,
                    DateTime.Now.AddMonths(-meses)
                );

                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = _controller.ObtenerTodasLasFacturas();

                lblMensaje.Text = "Facturas generadas correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void MostrarError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.ForeColor = System.Drawing.Color.Red;
        }

        // BOTÓN ATRÁS — usar navegación segura
        private void button1_Click(object sender, EventArgs e)
        {
            var main = new FrmMain("Usuario", _controller);
            main.Show();
            this.Close();
        }


        // NO USAR Application.Exit
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Evita que el proceso quede vivo
            base.OnFormClosed(e);
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panelInputs_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
