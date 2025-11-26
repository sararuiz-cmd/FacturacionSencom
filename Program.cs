using Proyect_Sencom_Form.Business;
using Proyect_Sencom_Form.UI;
using System;
using System.Windows.Forms;

namespace Proyect_Sencom_Form
{
    static class Program
    {
        public static FacturaController ControllerGlobal = new FacturaController();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar con login
            Application.Run(new FrmLogin(ControllerGlobal));
        }
    }
}
