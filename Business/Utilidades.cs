using System;

namespace Proyect_Sencom_Form.Business
{//clase de calculos para la factura
    public static class Utilidades
    {
        private static readonly string[] Meses =
        {
            "Enero","Febrero","Marzo","Abril","Mayo","Junio",
            "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"
        };

        public static string SeleccionarMes(int numeroMes)
        {
            if (numeroMes <= 0) numeroMes = 1;
            int idx = (numeroMes - 1) % 12;
            return Meses[idx];
        }

        public static double CalcularProduccionBaseMensual(double capacidadPlantaKw)
        {
            double eficiencia = capacidadPlantaKw * 0.2;
            double horasSolares = 4.5;
            double produccionDia = eficiencia * horasSolares;
            return produccionDia * 30;
        }

        public static double AplicarVariacionAleatoria(double produccionBase, Random random)
        {
            double factor = 0.95 + random.NextDouble() * 0.10;
            return produccionBase * factor;
        }
    }
}
