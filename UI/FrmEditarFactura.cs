using System;
using System.Windows.Forms;
using Proyect_Sencom_Form.Domain;
using Proyect_Sencom_Form.Business;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmEditarFactura : Form
    {
        private Factura _facturaOriginal;
        private FacturaController _controller;

        public FrmEditarFactura(Factura factura, FacturaController controller)
        {
            InitializeComponent();

            _facturaOriginal = factura;
            _controller = controller;

            ThemeManager.ApplyTheme(this);  // ←★ APLICA EL TEMA OSCURO/CLARO

            CargarDatosEnFormulario();
        }

        private void CargarDatosEnFormulario()
        {
            if (_facturaOriginal == null) return;

            txtId.Text = _facturaOriginal.IdFactura.ToString();
            txtNombre.Text = _facturaOriginal.Cliente?.Nombre ?? "";
            txtDireccion.Text = _facturaOriginal.Cliente?.Direccion ?? "";

            txtCapacidad.Text = _facturaOriginal.CapacidadPlantaKw.ToString();
            txtProduccion.Text = _facturaOriginal.ProduccionKwhMes.ToString();
            txtMonto.Text = _facturaOriginal.MontoMes.ToString();

            txtFecha.Text = _facturaOriginal.FechaEmision.ToString("dd/MM/yyyy");
            txtMesNombre.Text = _facturaOriginal.MesNombre;
            txtMesNumero.Text = _facturaOriginal.MesNumero.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (!double.TryParse(txtCapacidad.Text, out double capacidad) || capacidad <= 0)
            {
                MessageBox.Show("Capacidad inválida.");
                return;
            }

            if (!double.TryParse(txtProduccion.Text, out double produccion) || produccion < 0)
            {
                MessageBox.Show("Producción inválida.");
                return;
            }

            if (!double.TryParse(txtMonto.Text, out double monto) || monto < 0)
            {
                MessageBox.Show("Monto inválido.");
                return;
            }

            if (!DateTime.TryParse(txtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("Fecha inválida.");
                return;
            }

            // Crear nueva versión actualizada
            Factura nueva = new Factura
            {
                IdFactura = _facturaOriginal.IdFactura,
                Cliente = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                },
                CapacidadPlantaKw = capacidad,
                ProduccionKwhMes = produccion,
                FechaEmision = fecha,
                MesNumero = fecha.Month,
                MesNombre = fecha.ToString("MMMM"),
                ProduccionAcumuladaKwh = _facturaOriginal.ProduccionAcumuladaKwh,
                MontoMes = monto,
                MontoAcumulado = _facturaOriginal.MontoAcumulado
            };

            _controller.ActualizarFactura(nueva);

            MessageBox.Show("Factura actualizada correctamente.");

            // Volver al padre
            var main = this.Tag as Form;
            if (main != null)
                main.Show();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var main = this.Tag as Form;
            if (main != null)
                main.Show();

            this.Close();
        }
    }
}
