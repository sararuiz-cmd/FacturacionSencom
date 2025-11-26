namespace Proyect_Sencom_Form.Domain
{
    public class NodoFactura
    {
        public Factura Factura { get; set; }
        public NodoFactura Izquierdo { get; set; }
        public NodoFactura Derecho { get; set; }

        public NodoFactura(Factura factura)
        {
            Factura = factura;
        }
    }
}
