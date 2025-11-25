using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography; // añadido para hashing

namespace Proyect_Sencom_Form.Business
{// clase de autenticacion
    public class AuthService
    {
        private readonly string _rutaArchivo;
        private readonly Dictionary<string, string> _usuarios;

        public AuthService(string rutaArchivo = "usuarios.txt")
        {
            _rutaArchivo = rutaArchivo;
            _usuarios = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            if (!File.Exists(_rutaArchivo)) return;
            foreach (var linea in File.ReadAllLines(_rutaArchivo))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var partes = linea.Split(';');
                if (partes.Length == 2)
                {
                    var u = partes[0].Trim();
                    var p = partes[1].Trim();
                    if (!_usuarios.ContainsKey(u))
                        _usuarios.Add(u, p);
                }
            }
        }

        private void GuardarUsuarios()
        {
            var lineas = new List<string>();
            foreach (var kv in _usuarios)
                lineas.Add($"{kv.Key};{kv.Value}");
            File.WriteAllLines(_rutaArchivo, lineas);
        }

        public bool RegistrarUsuario(string usuario, string contrasena, out string mensaje)
        {
            usuario = (usuario ?? "").Trim();
            contrasena = (contrasena ?? "").Trim();
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                mensaje = "El usuario y la contraseña no pueden estar vacíos.";
                return false;
            }
            if (_usuarios.ContainsKey(usuario))
            {
                mensaje = "El usuario ya existe.";
                return false;
            }
            // Hash de la contraseña antes de almacenar
            var hash = HashPassword(contrasena);
            _usuarios.Add(usuario, hash);
            GuardarUsuarios();
            mensaje = "Usuario registrado correctamente.";
            return true;
        }

        public bool ValidarLogin(string usuario, string contrasena)
        {
            usuario = (usuario ?? "").Trim();
            contrasena = (contrasena ?? "").Trim();
            if (!_usuarios.TryGetValue(usuario, out var stored)) return false;
            return VerifyPassword(contrasena, stored);
        }

        // PBKDF2 hashing con salt y número de iteraciones
        private static string HashPassword(string password)
        {
            const int iterations = 10000;
            const int saltSize = 16;
            const int hashSize = 32;

            var salt = new byte[saltSize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                hash = pbkdf2.GetBytes(hashSize);
            }
            return $"{iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        private static bool VerifyPassword(string password, string stored)
        {
            if (string.IsNullOrEmpty(stored)) return false;
            var parts = stored.Split('.');
            if (parts.Length != 3 || !int.TryParse(parts[0], out var iterations))
            {
                // Compatibilidad con formato antiguo (texto plano)
                return password == stored;
            }
            try
            {
                var salt = Convert.FromBase64String(parts[1]);
                var storedHash = Convert.FromBase64String(parts[2]);
                byte[] computed;
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    computed = pbkdf2.GetBytes(storedHash.Length);
                }
                return FixedTimeEquals(storedHash, computed);
            }
            catch
            {
                return false;
            }
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
