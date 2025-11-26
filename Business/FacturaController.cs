using System;
using System.Collections.Generic;
using Proyect_Sencom_Form.Domain;

namespace Proyect_Sencom_Form.Business
{// clase de logica de factura
    public class FacturaController
    {
        private readonly ArbolFacturas _arbolFacturas;
        private readonly List<Factura> _historial;
        private readonly Random _random;
        private int _siguienteId = 1;
        private const double PRECIO_KWH = 0.15;

        public FacturaController()
        {
            _arbolFacturas = new ArbolFacturas();
            _historial = new List<Factura>();
            _random = new Random();
        }

        public List<Factura> GenerarFacturasSimuladas(Cliente cliente, double capacidadKw, int numeroMeses, DateTime fechaInicio)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            if (capacidadKw <= 0) throw new ArgumentException("Capacidad inválida.");
            if (numeroMeses <= 0) throw new ArgumentException("Meses inválidos.");

            double baseMensual = Utilidades.CalcularProduccionBaseMensual(capacidadKw);
            double prodAcum = 0;
            double factAcum = 0;
            var lista = new List<Factura>();

            for (int i = 1; i <= numeroMeses; i++)
            {
                double prodMes = Utilidades.AplicarVariacionAleatoria(baseMensual, _random);
                prodAcum += prodMes;
                double montoMes = prodMes * PRECIO_KWH;
                factAcum += montoMes;

                var f = new Factura
                {
                    IdFactura = _siguienteId++,
                    Cliente = cliente,
                    FechaEmision = fechaInicio.AddMonths(i - 1),
                    MesNumero = i,
                    MesNombre = Utilidades.SeleccionarMes(i),
                    CapacidadPlantaKw = capacidadKw,
                    ProduccionKwhMes = prodMes,
                    ProduccionAcumuladaKwh = prodAcum,
                    MontoMes = montoMes,
                    MontoAcumulado = factAcum
                };

                _arbolFacturas.Insertar(f);
                _historial.Add(f);
                lista.Add(f);
            }

            return lista;
        }

        public List<Factura> ObtenerHistorialPorCliente(string nombreCliente)
        {
            return _arbolFacturas.BuscarPorCliente(nombreCliente);
        }

        public List<Factura> ObtenerTodasLasFacturas()
        {
            return _arbolFacturas.ObtenerTodasEnOrden();
        }

        public Factura BuscarFacturaPorId(int id)
        {
            return _arbolFacturas.BuscarPorId(id);
        }

        public double CalcularMesesRecuperacionInversion(double inversion)
        {
            if (inversion <= 0) throw new ArgumentException("La inversión debe ser > 0.");

            if (_historial.Count == 0) throw new InvalidOperationException("No hay facturas para calcular promedio.");

            double suma = 0;
            foreach (var f in _historial) suma += f.MontoMes;
            double promedio = suma / _historial.Count;
            if (promedio <= 0) throw new InvalidOperationException("Promedio mensual inválido.");
            return inversion / promedio;
        }

        public IReadOnlyList<Factura> ObtenerHistorialCompleto()
        {
            return _historial.AsReadOnly();
        }
    }
}
