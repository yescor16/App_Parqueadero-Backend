using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.Tarifa_Vehiculo
{
    public class ObtenerTarifaPorVehiculo
    {
        private IUnidadDeTrabajo<Tarifa> TarifaRepositorio;
        public ObtenerTarifaPorVehiculo(IUnidadDeTrabajo<Tarifa> _repositorio)
        {
            this.TarifaRepositorio = _repositorio;
        }
        public List<Tarifa> Ejecutar(int idTipoVehiculo)
        {
            return TarifaRepositorio.repositorio<Tarifa>().EjecutarSPSinParametros("spObtenerTarifaporVehiculo " + idTipoVehiculo);
        }
    }
}
