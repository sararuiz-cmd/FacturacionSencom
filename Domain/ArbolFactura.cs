using System;
using System.Collections.Generic;

namespace Proyect_Sencom_Form.Domain
{
    public class ArbolFacturas
    {
        private NodoFactura _raiz;

        public void Insertar(Factura factura)
        {
            if (factura == null) throw new ArgumentNullException(nameof(factura));
            _raiz = InsertarRec(_raiz, factura);
        }

        private NodoFactura InsertarRec(NodoFactura nodo, Factura factura)
        {
            if (nodo == null) return new NodoFactura(factura);

            if (factura.IdFactura < nodo.Factura.IdFactura)
                nodo.Izquierdo = InsertarRec(nodo.Izquierdo, factura);
            else if (factura.IdFactura > nodo.Factura.IdFactura)
                nodo.Derecho = InsertarRec(nodo.Derecho, factura);

            return nodo;
        }

        public Factura BuscarPorId(int id)
        {
            var n = BuscarRec(_raiz, id);
            return n?.Factura;
        }

        private NodoFactura BuscarRec(NodoFactura nodo, int id)
        {
            if (nodo == null) return null;
            if (id == nodo.Factura.IdFactura) return nodo;
            if (id < nodo.Factura.IdFactura) return BuscarRec(nodo.Izquierdo, id);
            return BuscarRec(nodo.Derecho, id);
        }

        public List<Factura> ObtenerTodasEnOrden()
        {
            var lista = new List<Factura>();
            InOrden(_raiz, lista);
            return lista;
        }

        private void InOrden(NodoFactura nodo, List<Factura> lista)
        {
            if (nodo == null) return;
            InOrden(nodo.Izquierdo, lista);
            lista.Add(nodo.Factura);
            InOrden(nodo.Derecho, lista);
        }

        public List<Factura> BuscarPorCliente(string nombreCliente)
        {
            nombreCliente = (nombreCliente ?? string.Empty).Trim().ToLower();
            var todas = ObtenerTodasEnOrden();
            var res = new List<Factura>();
            foreach (var f in todas)
            {
                var n = (f.Cliente?.Nombre ?? "").Trim().ToLower();
                if (n.Contains(nombreCliente))
                    res.Add(f);
            }
            return res;
        }
    }
}