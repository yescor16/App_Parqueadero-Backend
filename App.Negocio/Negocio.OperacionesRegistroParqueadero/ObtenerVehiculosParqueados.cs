using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.OperacionesRegistroParqueadero
{
    public class ObtenerVehiculosParqueados
    {
        private IUnidadDeTrabajo<RegistroParqueadero> RegistroParqueaderoRepositorio;
        public ObtenerVehiculosParqueados(IUnidadDeTrabajo<RegistroParqueadero> _repositorio)
        {
            this.RegistroParqueaderoRepositorio = _repositorio;
        }
        public IEnumerable<RegistroParqueadero> Ejecutar()
        {
            return RegistroParqueaderoRepositorio.repositorio<RegistroParqueadero>().obtenerListadoPorCondicion(x => x.fecha_salida == "");
        }
    }
}
