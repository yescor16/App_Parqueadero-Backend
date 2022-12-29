using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.Tarifas
{
    public class CrearTarifa
    {
        private IUnidadDeTrabajo<Tarifa> TarifaRepositorio;
        public CrearTarifa(IUnidadDeTrabajo<Tarifa> _repositorio)
        {
            this.TarifaRepositorio = _repositorio;
        }
        public Tarifa Ejecutar(Tarifa _tarifa)
        {
            return TarifaRepositorio.repositorio<Tarifa>().crear(_tarifa);
        }
    }
}
