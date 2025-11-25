using System.Collections.Generic;
using Proyect_Sencom_Form.Domain;

namespace Proyect_Sencom_Form.Business
{//Clase para encapsular lógica de predicción de facturación.
    public class PrediccionIAService
    {
        public void EntrenarModelo(IEnumerable<Factura> historial)
        {
            // Sin implementación (solo placeholder para que compile).
        }

        public float PredecirMonto(int mesNumero, double produccionKwhMes, double capacidadPlantaKw)
        {
            // Predicción simple basada en la tarifa.
            return (float)(produccionKwhMes * 0.15);
        }
    }
}
