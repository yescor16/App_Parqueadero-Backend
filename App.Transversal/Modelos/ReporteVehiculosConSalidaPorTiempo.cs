using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Transversal.Modelos
{
    public class ReporteVehiculosConSalidaPorTiempo : EntidadBase
    {
        public int id_tipoVehiculo { get; set; }
        public int id_propietario { get; set; }
        public int valor_tarifa { get; set; }
        public int valor_tiempo { get; set; }
        public int minutos_transcurridos { get; set; }
        public string telefono { get; set; }
        public string vehiculo { get; set; }
        public string email { get; set; }
        public string propietario { get; set; }
        public string fecha_ingreso { get; set; }
        public string fecha_salida { get; set; }
        public string placa { get; set; }
        public string numero_factura { get; set; }
        public bool aplicaDescuento { get; set; }

    }
}
