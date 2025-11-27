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

                if (!ValidadorFactura.EsDecimalPositivo(txtCapacidadKw.Text, out double capacidadKw))
                {
                    MostrarError("Capacidad de planta inválida.");
                    return;
                }

                if (!ValidadorFactura.EsEnteroPositivo(txtMeses.Text, out int numeroMes))
                {
                    MostrarError("Número de mes inválido.");
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
                // CALCULOS AUTOMÁTICOS (PORTADO DE PYTHON)
                // ==========================
                const double PRECIO_KW = 0.15;
                Random r = new Random();

                // 1. Producción base mensual
                double produccionBaseMensual = Utilidades.CalcularProduccionBaseMensual(capacidadKw);

                // 2. Producción real del mes con variación ±5%
                double produccionMes = Utilidades.AplicarVariacionAleatoria(produccionBaseMensual, r);

                // 3. Producción acumulada (simple suma por los meses anteriores)
                double produccionAcumulada = produccionMes * numeroMes;

                // 4. Monto mensual y acumulado
                double montoMes = produccionMes * PRECIO_KW;
                double montoAcumulado = produccionAcumulada * PRECIO_KW;

                // 5. Mes actual (usando Utilidades)
                string mesNombre = Utilidades.SeleccionarMes(numeroMes);

                // ==========================
                // CREAR FACTURA YA CON CÁLCULOS
                // ==========================
                Factura factura = new Factura
                {
                    IdFactura = new Random().Next(1, 999999),
                    Cliente = cliente,
                    FechaEmision = DateTime.Now,

                    MesNumero = numeroMes,
                    MesNombre = mesNombre,

                    CapacidadPlantaKw = capacidadKw,
                    ProduccionKwhMes = produccionMes,
                    ProduccionAcumuladaKwh = produccionAcumulada,

                    MontoMes = montoMes,
                    MontoAcumulado = montoAcumulado
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
