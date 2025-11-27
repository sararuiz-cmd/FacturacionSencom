using FacturacionSencom;
using Proyect_Sencom_Form.Business;
using Proyect_Sencom_Form.Domain;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmGrafico : Form
    {
        private readonly FacturaController _controller;

        public FrmGrafico(FacturaController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void FrmGrafico_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);

            try
            {
                var historial = _controller.ObtenerFacturasOrdenadas();

                if (historial == null || historial.Count == 0)
                {
                    MessageBox.Show("No hay facturas registradas para graficar.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Close();
                    return;
                }

                chart1.Series.Clear();

                Series serie = new Series("Producción Mensual (kWh)");
                serie.ChartType = SeriesChartType.Column;
                serie.XValueType = ChartValueType.String;
                serie.YValueType = ChartValueType.Double;

                foreach (var factura in historial)
                {
                    string mes = factura.MesNombre ?? "Mes";
                    double produccion = factura.ProduccionKwhMes;

                    serie.Points.AddXY(mes, produccion);
                }

                chart1.Series.Add(serie);

                if (chart1.ChartAreas.Count > 0)
                {
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.Title = "Mes";
                    chart1.ChartAreas[0].AxisY.Title = "Producción (kWh)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el gráfico:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
        }

        // 🔥 CORREGIDO: YA NO CREA UN NUEVO Frmmain
        public void VolverAlPrincipal()
        {
            var main = this.Tag as Form;
            if (main != null)
                main.Show();

            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        //  Esto garantiza que la app NO quede colgada si se cierra la ventana
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            var main = this.Tag as Form;
            if (main != null)
                main.Show();
            else
                Application.Exit();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
