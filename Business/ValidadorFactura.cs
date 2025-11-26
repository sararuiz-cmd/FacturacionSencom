using System.Text.RegularExpressions;

namespace Proyect_Sencom_Form.Business
{//clase para validar datos de facturacion
    public static class ValidadorFactura
    {
        public static bool EsNombreValido(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            var regex = new Regex(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ ]+$");
            return regex.IsMatch(nombre.Trim());
        }

        public static bool EsDireccionValida(string direccion)
        {
            return !string.IsNullOrWhiteSpace(direccion);
        }

        public static bool EsDecimalPositivo(string texto, out double valor)
        {
            if (double.TryParse(texto, out valor) && valor > 0) return true;
            valor = 0;
            return false;
        }

        public static bool EsEnteroPositivo(string texto, out int valor)
        {
            if (int.TryParse(texto, out valor) && valor > 0) return true;
            valor = 0;
            return false;
        }
    }
}

