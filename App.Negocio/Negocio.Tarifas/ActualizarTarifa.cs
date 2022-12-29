using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.Tarifas
{
    public class ActualizarTarifa
    {
        private IUnidadDeTrabajo<Tarifa> TarifaRepositorio;
        public ActualizarTarifa(IUnidadDeTrabajo<Tarifa> _repositorio)
        {
            this.TarifaRepositorio = _repositorio;
        }
        public bool Ejecutar(Tarifa _tarifa)
        {
            return TarifaRepositorio.repositorio<Tarifa>().actualizar(_tarifa);
        }
    }
}
