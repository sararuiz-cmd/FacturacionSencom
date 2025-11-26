using System.Text.RegularExpressions;

namespace Proyect_Sencom_Form.Business
{// clase para validar usuarios
    public static class ValidadorUsuario
    {
        public static bool EsUsuarioValido(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario)) return false;
            // 3-20 caracteres alfanum�ricos, permite . _ -
            var rx = new Regex("^[A-Za-z0-9._-]{3,20}$");
            return rx.IsMatch(usuario.Trim());
        }

        public static bool EsContrasenaValida(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena)) return false;
            if (contrasena.Length < 6) return false; // m�nimo
            bool tieneLetra = false, tieneDigito = false;
            foreach (var c in contrasena)
            {
                if (char.IsLetter(c)) tieneLetra = true;
                if (char.IsDigit(c)) tieneDigito = true;
            }
            return tieneLetra && tieneDigito; // debe tener al menos una letra y un n�mero
        }
    }
}
