using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.OperacionesRegistroParqueadero
{
    public class IngresoRegistroParqueadero
    {
        private IUnidadDeTrabajo<RegistroParqueadero> RegistroParqueaderoRepositorio;
        public IngresoRegistroParqueadero(IUnidadDeTrabajo<RegistroParqueadero> _repositorio)
        {
            this.RegistroParqueaderoRepositorio = _repositorio;
        }
        public RegistroParqueadero Ejecutar(RegistroParqueadero _registroParqueadero)
        {
            return RegistroParqueaderoRepositorio.repositorio<RegistroParqueadero>().crear(_registroParqueadero);
        }
    }
}
