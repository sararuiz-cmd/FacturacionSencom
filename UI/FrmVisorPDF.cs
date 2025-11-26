using FacturacionSencom;
using Proyect_Sencom_Form.Business;
using System;
using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmVisorPDF : Form
    {
        private string rutaPdf;

        public FrmVisorPDF(string ruta)
        {
            InitializeComponent();
            rutaPdf = ruta;
        }

        private void FrmVisorPDF_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            try
            {
                if (string.IsNullOrWhiteSpace(rutaPdf))
                {
                    MessageBox.Show("Ruta de PDF inválida.");
                    Close();
                    return;
                }
                if (!System.IO.File.Exists(rutaPdf))
                {
                    MessageBox.Show("El archivo PDF no existe.");
                    Close();
                    return;
                }
                webBrowser1.Navigate(rutaPdf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el PDF: " + ex.Message);
                Close();
            }
        }

        public void VolverAlPrincipal(string usuario = "")
        {
            var frm = new FrmMain(usuario, Program.ControllerGlobal);
            frm.Show();
            this.Hide();


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
