using FacturacionSencom;
using Proyect_Sencom_Form.Business;
using System;
using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmLogin : Form
    {
        private readonly FacturaController _controller;

        public FrmLogin(FacturaController controller)
        {
            InitializeComponent();
            _controller = controller;
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);

            // Asegurar suscripción a eventos
            if (btnIniciarSesion != null)
            {
                btnIniciarSesion.Click -= btnIniciarSesion_Click;
                btnIniciarSesion.Click += btnIniciarSesion_Click;
            }

            if (btnRegistrar != null)
            {
                btnRegistrar.Click -= btnRegistrar_Click;
                btnRegistrar.Click += btnRegistrar_Click;
            }

            // Permitir que Enter dispare el login
            if (btnIniciarSesion != null)
            {
                AcceptButton = btnIniciarSesion;
            }

            lblMensaje.Text = string.Empty;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario?.Text?.Trim() ?? string.Empty;
            string contrasena = txtContrasena?.Text ?? string.Empty;

            if (!ValidadorUsuario.EsUsuarioValido(usuario))
            {
                lblMensaje.Text = "Usuario inválido (3-20 caracteres alfanuméricos).";
                lblMensaje.ForeColor = System.Drawing.Color.Maroon;
                return;
            }
            if (string.IsNullOrEmpty(contrasena))
            {
                lblMensaje.Text = "Ingrese la contraseña.";
                lblMensaje.ForeColor = System.Drawing.Color.Maroon;
                return;
            }

            try
            {
                AuthService auth = new AuthService();

                if (auth.ValidarLogin(usuario, contrasena))
                {
                    // Navegación estándar Windows Forms
                    var main = new FrmMain(usuario, _controller);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña incorrectos.";
                    lblMensaje.ForeColor = System.Drawing.Color.Maroon;
                }
            }
            catch (Exception)
            {
                lblMensaje.Text = "Error al procesar el inicio de sesión.";
                lblMensaje.ForeColor = System.Drawing.Color.Maroon;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario?.Text?.Trim() ?? string.Empty;
            string contrasena = txtContrasena?.Text ?? string.Empty;

            if (!ValidadorUsuario.EsUsuarioValido(usuario))
            {
                lblMensaje.Text = "Usuario inválido (3-20 caracteres alfanuméricos).";
                lblMensaje.ForeColor = System.Drawing.Color.Maroon;
                return;
            }
            if (!ValidadorUsuario.EsContrasenaValida(contrasena))
            {
                lblMensaje.Text = "Contraseña inválida (mínimo 6, letra y número).";
                lblMensaje.ForeColor = System.Drawing.Color.Maroon;
                return;
            }

            try
            {
                AuthService auth = new AuthService();

                if (auth.RegistrarUsuario(usuario, contrasena, out string mensaje))
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Maroon;
                }

                lblMensaje.Text = mensaje;
            }
            catch (Exception)
            {
                lblMensaje.Text = "Error al registrar usuario.";
                lblMensaje.ForeColor = System.Drawing.Color.Maroon;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Application.Exit(); // Login es la raíz, si se cierra, termina el programa.
        }


        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}

