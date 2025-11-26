using System;

namespace Proyect_Sencom_Form.Domain
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaEmision { get; set; }

        public int MesNumero { get; set; }
        public string MesNombre { get; set; }

        public double CapacidadPlantaKw { get; set; }
        public double ProduccionKwhMes { get; set; }
        public double ProduccionAcumuladaKwh { get; set; }

        public double MontoMes { get; set; }
        public double MontoAcumulado { get; set; }

        public override string ToString()
        {
            return $"Factura {IdFactura} - {Cliente?.Nombre} - {MesNombre} - {MontoMes:C2}";
        }
    }
}
