using Proyect_Sencom_Form.Business;
using Proyect_Sencom_Form.UI;
using System;
using System.Windows.Forms;

namespace Proyect_Sencom_Form
{
    static class Program
    {
        public static FacturaController ControllerGlobal = new FacturaController();
        public static SingleFormContext FormContext = new SingleFormContext();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormContext.ShowForm(new FrmLogin(ControllerGlobal));
            Application.Run(FormContext);
        }
    }
}