using System;
using System.Collections.Generic;
using Proyect_Sencom_Form.Domain;
using System.IO;
using System.Linq;
using System.Globalization;


namespace Proyect_Sencom_Form.Business
{
    public class FacturaController
    {
        private readonly string _rutaFacturas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "facturas.txt");
        private readonly ArbolFacturas _arbolFacturas;
        private readonly List<Factura> _historial;
        private int _siguienteId = 1;

        public FacturaController()
        {
            _arbolFacturas = new ArbolFacturas();
            _historial = new List<Factura>();
            CargarDesdeArchivo();
        }
        private void GuardarEnArchivo()
        {
            var lista = ObtenerFacturasOrdenadas();
            var lineas = new List<string>();

            foreach (var f in lista)
            {
                string nombre = f.Cliente?.Nombre ?? "";
                string direccion = f.Cliente?.Direccion ?? "";

                string linea = string.Join(";",
                    f.IdFactura.ToString(),
                    nombre,
                    direccion,
                    f.FechaEmision.Ticks.ToString(),
                    f.MesNumero.ToString(),
                    f.MesNombre ?? "",
                    f.CapacidadPlantaKw.ToString(),
                    f.ProduccionKwhMes.ToString(),
                    f.ProduccionAcumuladaKwh.ToString(),
                    f.MontoMes.ToString(),
                    f.MontoAcumulado.ToString()
                );

                lineas.Add(linea);
            }

            File.WriteAllLines(_rutaFacturas, lineas);
        }

        /// <summary>
        /// Agregar una factura manual al árbol y al historial.
        /// </summary>
        public void AgregarFactura(Factura factura)
        {
            if (factura == null) return;

            _arbolFacturas.Insertar(factura);
            _historial.Add(factura);

            GuardarEnArchivo();
        }

        /// <summary>
        /// Obtener facturas en orden (InOrden = ordenadas por ID).
        /// </summary>
        public List<Factura> ObtenerFacturasOrdenadas()
        {
            return _arbolFacturas.ObtenerTodasEnOrden();
        }

        /// <summary>
        /// Buscar factura por ID (BST).
        /// </summary>
        public Factura BuscarFacturaPorId(int id)
        {
            return _arbolFacturas.BuscarPorId(id);
        }

        public List<Factura> ObtenerHistorialPorCliente(string nombreCliente)
        {
            return _arbolFacturas.BuscarPorCliente(nombreCliente);
        }

        public IReadOnlyList<Factura> ObtenerHistorialCompleto()
        {
            return _historial.AsReadOnly();
        }
        public void EliminarFacturaPorId(int id)
        {
            _arbolFacturas.Eliminar(id);
            _historial.RemoveAll(f => f.IdFactura == id);
            GuardarEnArchivo();
        }
        public void ActualizarFactura(Factura facturaActualizada)
        {
            if (facturaActualizada == null) return;

            var existente = BuscarFacturaPorId(facturaActualizada.IdFactura);
            if (existente == null) return;

            // Copiar todos los campos menos el ID
            existente.Cliente = facturaActualizada.Cliente;
            existente.FechaEmision = facturaActualizada.FechaEmision;
            existente.MesNumero = facturaActualizada.MesNumero;
            existente.MesNombre = facturaActualizada.MesNombre;
            existente.CapacidadPlantaKw = facturaActualizada.CapacidadPlantaKw;
            existente.ProduccionKwhMes = facturaActualizada.ProduccionKwhMes;
            existente.ProduccionAcumuladaKwh = facturaActualizada.ProduccionAcumuladaKwh;
            existente.MontoMes = facturaActualizada.MontoMes;
            existente.MontoAcumulado = facturaActualizada.MontoAcumulado;

            GuardarEnArchivo();
        }
        private void CargarDesdeArchivo()
        {
            if (!File.Exists(_rutaFacturas))
                return;

            var lineas = File.ReadAllLines(_rutaFacturas);
            int maxId = 0;

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split(';');
                if (partes.Length < 11) continue;

                int id = int.Parse(partes[0]);
                string nombre = partes[1];
                string direccion = partes[2];
                long ticks = long.Parse(partes[3]);
                DateTime fecha = new DateTime(ticks);
                int mesNumero = int.Parse(partes[4]);
                string mesNombre = partes[5];
                double capacidad = double.Parse(partes[6], CultureInfo.InvariantCulture);
                double prodMes = double.Parse(partes[7], CultureInfo.InvariantCulture);
                double prodAcum = double.Parse(partes[8], CultureInfo.InvariantCulture);
                double montoMes = double.Parse(partes[9], CultureInfo.InvariantCulture);
                double montoAcum = double.Parse(partes[10], CultureInfo.InvariantCulture);

                var cliente = new Cliente
                {
                    Nombre = nombre,
                    Direccion = direccion
                };

                var factura = new Factura
                {
                    IdFactura = id,
                    Cliente = cliente,
                    FechaEmision = fecha,
                    MesNumero = mesNumero,
                    MesNombre = mesNombre,
                    CapacidadPlantaKw = capacidad,
                    ProduccionKwhMes = prodMes,
                    ProduccionAcumuladaKwh = prodAcum,
                    MontoMes = montoMes,
                    MontoAcumulado = montoAcum
                };

                _arbolFacturas.Insertar(factura);
                _historial.Add(factura);

                if (id > maxId) maxId = id;
            }

            _siguienteId = maxId + 1;
        }
    }
}
