using System.Collections.Generic;
using SGEDICALE.clases;
using SGEDICALE.modelo;


namespace SGEDICALE.controlador
{
    public class CPagoComprobante
    {

        public static bool insertar(PagoComprobante pago)
        {
            return MPagoComprobante.insertar(pago);
        }

    }
}
