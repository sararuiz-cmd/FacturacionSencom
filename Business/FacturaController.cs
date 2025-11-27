using System;
using System.Collections.Generic;
using Proyect_Sencom_Form.Domain;

namespace Proyect_Sencom_Form.Business
{
    public class FacturaController
    {
        private readonly ArbolFacturas _arbolFacturas;
        private readonly List<Factura> _historial;
        private int _siguienteId = 1;

        public FacturaController()
        {
            _arbolFacturas = new ArbolFacturas();
            _historial = new List<Factura>();
        }

        /// <summary>
        /// Agregar una factura manual al árbol y al historial.
        /// </summary>
        public void AgregarFactura(Factura factura)
        {
            if (factura == null) return;

            _arbolFacturas.Insertar(factura);   // guarda en BST
            _historial.Add(factura);            // guarda para IA
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
    }
}
