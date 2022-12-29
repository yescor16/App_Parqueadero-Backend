using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.Reportes
{
    public class ObtenerVehiculosParqueadosPorTiempos
    {
        private IUnidadDeTrabajo<ReporteVehiculosConSalidaPorTiempo> Repositorio;
        public ObtenerVehiculosParqueadosPorTiempos(IUnidadDeTrabajo<ReporteVehiculosConSalidaPorTiempo> _repositorio)
        {
            this.Repositorio = _repositorio;
        }
        public List<ReporteVehiculosConSalidaPorTiempo> Ejecutar(RequestReporteVehiculosConSalidaPorTiempo fechas)
        {
            return Repositorio.repositorio<ReporteVehiculosConSalidaPorTiempo>().EjecutarSPSinParametros("SP_ReporteVehiculosConSalidaPorTiempos '" + fechas.fecha_ingreso + "','" + fechas.fecha_salida + "'");
        }
    }
}
