using FacturacionSencom;
using Proyect_Sencom_Form.Business;
using System;
using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmMain : Form
    {
        private readonly FacturaController _controller;
        private readonly string _usuario;
        private Button btnToggleTheme; // eliminado btnSalir

        public FrmMain(string usuario, FacturaController controller)
        {
            InitializeComponent();
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
            _usuario = string.IsNullOrWhiteSpace(usuario) ? "(desconocido)" : usuario.Trim();
            lblUsuario.Text = "Usuario actual: " + _usuario;
            ThemeManager.LoadTheme();
            AddThemeToggleButton();
            ThemeManager.ApplyTheme(this);
        }

        private void AddThemeToggleButton()
        {
            btnToggleTheme = new Button();
            btnToggleTheme.Text = ThemeManager.CurrentTheme == AppTheme.Dark ? "Modo Claro" : "Modo Oscuro";
            btnToggleTheme.Width = 120;
            btnToggleTheme.Height = 30;
            btnToggleTheme.Top = 60;
            btnToggleTheme.Left = 600;
            btnToggleTheme.FlatStyle = FlatStyle.Flat;
            btnToggleTheme.Click += (s, e) =>
            {
                ThemeManager.ToggleTheme();
                btnToggleTheme.Text = ThemeManager.CurrentTheme == AppTheme.Dark ? "Modo Claro" : "Modo Oscuro";
            };
            Controls.Add(btnToggleTheme);
            btnToggleTheme.BringToFront();
        }

        private void AbrirUnico(Form frm)
        {
            ThemeManager.ApplyTheme(frm);
            frm.Tag = this;     // guardar referencia al formulario padre
            frm.Show();
            this.Hide();
        }



        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            AbrirUnico(new FrmFactura(_controller));
        }

        private void btnPrediccionIA_Click(object sender, EventArgs e)
        {
            AbrirUnico(new FrmPrediccionIA(_controller));
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            var lista = _controller.ObtenerTodasLasFacturas();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay facturas para exportar.");
                return;
            }
            var factura = lista[lista.Count - 1];
            var cliente = factura.Cliente;
            if (factura == null || cliente == null)
            {
                MessageBox.Show("Datos de factura inválidos.");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo PDF|*.pdf";
            sfd.FileName = "Factura_" + factura.IdFactura + ".pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfService pdf = new PdfService();
                    pdf.GenerarReporteFactura(factura, cliente, sfd.FileName);
                    MessageBox.Show("PDF generado correctamente.");
                    AbrirUnico(new FrmVisorPDF(sfd.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message);
                }
            }
        }

        private void btnVerGrafico_Click(object sender, EventArgs e)
        {
            var frm = new FrmGrafico(_controller);
            frm.Tag = this;  // ← Enlaza el padre
            frm.Show();
            this.Hide();
        }


        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }



        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            var main = this.Tag as Form;
            if (main != null)
                main.Show();

            this.Close();
        }




    }
}

