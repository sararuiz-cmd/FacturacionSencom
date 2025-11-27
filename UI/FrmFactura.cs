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
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            dgvFacturas.AutoGenerateColumns = true;
            dgvFacturas.DataSource = _controller.ObtenerFacturasOrdenadas();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // ==========================
                // VALIDACIONES
                // ==========================
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

                if (!ValidadorFactura.EsDecimalPositivo(txtProduccion.Text, out double produccion))
                {
                    MostrarError("Producción inválida.");
                    return;
                }


                // ==========================
                // CREAR CLIENTE
                // ==========================
                Cliente cliente = new Cliente
                {
                    IdCliente = new Random().Next(1, 99999),
                    Nombre = txtNombreCliente.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };

                // ==========================
                // CREAR FACTURA MANUAL
                // ==========================
                Factura factura = new Factura
                {
                    IdFactura = new Random().Next(1, 999999),
                    Cliente = cliente,
                    FechaEmision = DateTime.Now,
                    MesNumero = DateTime.Now.Month,
                    MesNombre = DateTime.Now.ToString("MMMM"),
                    ProduccionKwhMes = capacidad,
                    CapacidadPlantaKw = capacidad,
                    MontoMes = capacidad * 0.15
                };

                _controller.AgregarFactura(factura);



                // ==========================
                // REFRESCAR GRID
                // ==========================
                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = _controller.ObtenerFacturasOrdenadas();

                lblMensaje.Text = "Factura registrada correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            txtDireccion.Text = "";
            txtCapacidadKw.Text = "";
        }

        private void MostrarError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.ForeColor = System.Drawing.Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // ← usa el TAG del padre, no crea ventanas nuevas
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            var main = this.Tag as Form;
            if (main != null)
                main.Show();
            else
                Application.Exit();
        }

        private void panelInputs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
