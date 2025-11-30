using FacturacionSencom;
using Proyect_Sencom_Form.Business;
using System;
using System.Windows.Forms;
using Proyect_Sencom_Form.Domain;
using Microsoft.VisualBasic;   // para InputBox


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
        private void btnMostrarFacturas_Click(object sender, EventArgs e)
        {
            var lista = _controller.ObtenerFacturasOrdenadas(); // ← BST INORDEN

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay facturas registradas.");
                return;
            }

            lstFacturas.Items.Clear();
            foreach (var factura in lista)
            {
                string cliente = factura.Cliente?.Nombre ?? "(sin cliente)";
                lstFacturas.Items.Add(
                    $"ID {factura.IdFactura} | {cliente} | {factura.FechaEmision:dd/MM/yyyy} | ${factura.MontoMes:F2}"
                );
            }
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarId.Text.Trim(); // ahora es nombre

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nombre del cliente a buscar.");
                return;
            }

            var lista = _controller.ObtenerHistorialPorCliente(nombre.ToLower());

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No se encontraron facturas para ese nombre.");
                return;
            }

            lstFacturas.Items.Clear();
            foreach (var factura in lista)
            {
                string cliente = factura.Cliente?.Nombre ?? "(sin cliente)";
                lstFacturas.Items.Add(
                    $"ID {factura.IdFactura} | {cliente} | {factura.FechaEmision:dd/MM/yyyy} | ${factura.MontoMes:F2}"
                );
            }
        }

        private void MostrarListaEnPantalla(System.Collections.Generic.List<Factura> lista, int indiceSeleccionado)
        {
            lstFacturas.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                var factura = lista[i];
                string cliente = factura.Cliente?.Nombre ?? "(sin cliente)";
                lstFacturas.Items.Add($"ID {factura.IdFactura} - {cliente} - {factura.FechaEmision:dd/MM/yyyy} - ${factura.MontoMes:F2}");
            }

            if (indiceSeleccionado >= 0 && indiceSeleccionado < lstFacturas.Items.Count)
            {
                lstFacturas.SelectedIndex = indiceSeleccionado;
            }
        }

        private int BinarySearchFactura(System.Collections.Generic.List<Factura> lista, int idBuscado)
        {
            int izquierda = 0;
            int derecha = lista.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int idActual = lista[medio].IdFactura;

                if (idActual == idBuscado)
                    return medio;

                if (idActual < idBuscado)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }

            return -1;
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
            var lista = _controller.ObtenerFacturasOrdenadas();

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

        private void panelBotones_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void c(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmLogin(_controller);
            this.Close();
            frm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int ExtraerIdDesdeLinea(string linea)
        {
            if (string.IsNullOrWhiteSpace(linea)) return -1;
            // Formato: "ID 3 | Cliente ..."
            var partes = linea.Split(' ');
            if (partes.Length < 2) return -1;

            if (int.TryParse(partes[1], out int id))
                return id;

            return -1;
        }
        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            if (lstFacturas.SelectedIndex == -1)
            {
                MessageBox.Show("Primero busque por nombre y seleccione la factura que desea eliminar en la lista.");
                return;
            }

            string linea = lstFacturas.SelectedItem.ToString();
            int id = ExtraerIdDesdeLinea(linea);

            if (id == -1)
            {
                MessageBox.Show("No se pudo obtener el ID de la factura seleccionada.");
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Seguro que desea eliminar la factura ID {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            _controller.EliminarFacturaPorId(id);

            MessageBox.Show("Factura eliminada correctamente.");
            btnMostrarFacturas_Click(null, null); // mostrar todo en orden
        }
        private void btnActualizarFactura_Click(object sender, EventArgs e)
        {
            if (lstFacturas.SelectedIndex == -1)
            {
                MessageBox.Show("Primero seleccione una factura de la lista para modificar.");
                return;
            }

            string linea = lstFacturas.SelectedItem.ToString();
            int id = ExtraerIdDesdeLinea(linea);

            if (id == -1)
            {
                MessageBox.Show("No se pudo obtener el ID de la factura seleccionada.");
                return;
            }

            var factura = _controller.BuscarFacturaPorId(id);
            if (factura == null)
            {
                MessageBox.Show("No se encontró la factura en el sistema.");
                return;
            }

            // Clonar datos actuales para edición
            var cliente = factura.Cliente ?? new Cliente();
            var nueva = new Factura
            {
                IdFactura = factura.IdFactura,
                Cliente = new Cliente
                {
                    Nombre = cliente.Nombre,
                    Direccion = cliente.Direccion
                },
                FechaEmision = factura.FechaEmision,
                MesNumero = factura.MesNumero,
                MesNombre = factura.MesNombre,
                CapacidadPlantaKw = factura.CapacidadPlantaKw,
                ProduccionKwhMes = factura.ProduccionKwhMes,
                ProduccionAcumuladaKwh = factura.ProduccionAcumuladaKwh,
                MontoMes = factura.MontoMes,
                MontoAcumulado = factura.MontoAcumulado
            };

            // --- Editar campos con InputBox ---

            string nuevoNombre = Interaction.InputBox("Nombre del cliente:", "Modificar factura", nueva.Cliente.Nombre);
            if (!string.IsNullOrWhiteSpace(nuevoNombre))
            {
                if (!ValidadorFactura.EsNombreValido(nuevoNombre))
                {
                    MessageBox.Show("Nombre inválido.");
                    return;
                }
                nueva.Cliente.Nombre = nuevoNombre.Trim();
            }

            string nuevaDir = Interaction.InputBox("Dirección del cliente:", "Modificar factura", nueva.Cliente.Direccion);
            if (!string.IsNullOrWhiteSpace(nuevaDir))
                nueva.Cliente.Direccion = nuevaDir.Trim();

            string capStr = Interaction.InputBox("Capacidad de la planta (kW):", "Modificar factura", nueva.CapacidadPlantaKw.ToString());
            if (!string.IsNullOrWhiteSpace(capStr))
            {
                if (!double.TryParse(capStr, out double cap) || cap <= 0)
                {
                    MessageBox.Show("Capacidad inválida.");
                    return;
                }
                nueva.CapacidadPlantaKw = cap;
            }

            string prodStr = Interaction.InputBox("Producción del mes (kWh):", "Modificar factura", nueva.ProduccionKwhMes.ToString());
            if (!string.IsNullOrWhiteSpace(prodStr))
            {
                if (!double.TryParse(prodStr, out double prod) || prod < 0)
                {
                    MessageBox.Show("Producción inválida.");
                    return;
                }
                nueva.ProduccionKwhMes = prod;
            }

            string montoStr = Interaction.InputBox("Monto del mes:", "Modificar factura", nueva.MontoMes.ToString());
            if (!string.IsNullOrWhiteSpace(montoStr))
            {
                if (!double.TryParse(montoStr, out double monto) || monto < 0)
                {
                    MessageBox.Show("Monto inválido.");
                    return;
                }
                nueva.MontoMes = monto;
            }

            string fechaStr = Interaction.InputBox("Fecha de emisión (dd/MM/yyyy):", "Modificar factura", nueva.FechaEmision.ToString("dd/MM/yyyy"));
            if (!string.IsNullOrWhiteSpace(fechaStr))
            {
                if (!DateTime.TryParse(fechaStr, out DateTime nuevaFecha))
                {
                    MessageBox.Show("Fecha inválida.");
                    return;
                }
                nueva.FechaEmision = nuevaFecha;
                nueva.MesNumero = nuevaFecha.Month;
                nueva.MesNombre = nuevaFecha.ToString("MMMM");
            }

            _controller.ActualizarFactura(nueva);

            MessageBox.Show("Factura actualizada correctamente.");
            btnMostrarFacturas_Click(null, null); // recargar lista completa
        }



    }
}

